using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;

namespace Core.Sip.Client.Meas
{
    public enum RtuCommand
    {
        READ_VALUE = 0X01,
        CLOSE_SWITCH ,
        OPEN_SWITCH
    }

    public enum SwitchStatus
    {
        OPEN = 0,
        CLOSE = 1
    }
    public class CoreRtu
    {
        #region <��Ա����>
        string _ipAddr;     // IP��ַ 
        ushort _port;       // �豸�˿� 1100
        Socket _socket;     // �׽���
        byte _dest = 1;     // �豸��ַ�� ͨ��ָRtu��ĳһģ��
        byte _DOAddrLow = 0x50;
        byte[] _DOAddrHight = null; 
        bool[] _DOValue = null;//DO״ֵ̬
        #endregion 

        #region <����>
        public string IP
        {
            get { return _ipAddr; }
            set { _ipAddr = value; }
        }

        public ushort Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public bool[] DO
        {
            get { return _DOValue; }
        }

        #endregion

        public CoreRtu()
        {
            _ipAddr = "10.25.3.11";
            _port =1100;
            // �豸��ַ
            _dest = 0x01;
            // DO ��ַ��λ
            _DOAddrLow = 0x50;

            // DO �ĸ�λ��ַ
            _DOAddrHight = new byte[6] { 0xDD, 0xDE, 0xDF, 0xE0, 0xE1, 0xE2 };

            // DO ֵ��ʼ��
            _DOValue = new bool[8];
        }
        #region <��������>
        
        public void init(string config)
        {            
            string[] strtmp = config.Split(new char[] { ':' });
            IP = strtmp[0];
            Port = Convert.ToUInt16(strtmp[1]);

            // �豸��ַ
            _dest = 0x01;
            // DO ��ַ��λ
            _DOAddrLow = 0x50;

             // DO �ĸ�λ��ַ
            _DOAddrHight = new byte[6]{0xDD,0xDE,0xDF,0xE0, 0xE1, 0xE2}; 

            // DO ֵ��ʼ��
            _DOValue = new bool[8];
           
        }

        protected void Request(RtuCommand cmd, byte varAddr)
        {
            byte[] obuffer = new byte[255];
            byte[] d = new byte[1];
            int len = 0;
            BitArray bits = null;
            Connect();
            SendCommand(cmd, varAddr);
            len = _socket.Receive(obuffer);
            _socket.Close();
            if (cmd == RtuCommand.READ_VALUE)
            {
                d[0] = obuffer[10];
                bits = new BitArray(d);
                for (int i = 0; i < bits.Length; i++)
                {
                    _DOValue[i] = bits.Get(i);
                }
            }
            else
            {
                d[0] = obuffer[0];
                bits = new BitArray(d);
            }
            
        }

        protected void SendCommand(RtuCommand cmd, byte varAddr)
        {
            byte[] cmdBuf = new byte[12];
            //cmdBuf.SetValue(0x00, 0);
            for (int i = 0; i < 5; i++) cmdBuf[i] = 0; 
     
            switch ((RtuCommand)cmd)
            {
                case RtuCommand.READ_VALUE:
                     cmdBuf[5] = 6;
                     cmdBuf[6] = _dest;
                     cmdBuf[7] = 1;
                     cmdBuf[8] = _DOAddrLow;
                     cmdBuf[9] = 0x70;
                     cmdBuf[10] = 0;
                     cmdBuf[11] = 16;
                     break;
                case RtuCommand.OPEN_SWITCH:
                     cmdBuf[5] = 6;
                     cmdBuf[6] = _dest;
                     cmdBuf[7] = 5;
                     cmdBuf[8] = _DOAddrLow;
                     cmdBuf[9] = Convert.ToByte(varAddr - 1);
                     cmdBuf[10] = 0;
                     cmdBuf[11] = 0;
                     break;
                case RtuCommand.CLOSE_SWITCH:
                     cmdBuf[5] = 6;
                     cmdBuf[6] = _dest;
                     cmdBuf[7] = 5;
                     cmdBuf[8] = _DOAddrLow;
                     cmdBuf[9] = Convert.ToByte(varAddr - 1);
                     cmdBuf[10] = 0xFF;
                     cmdBuf[11] = 0;
                     break;
            }
            int len = 5 + cmdBuf[5] + 1;
            _socket.Send(cmdBuf, len, SocketFlags.None);
        }

       
        protected void Connect()
        {
            //���ý��ܳ�ʱʱ��Ϊ2��͵�ַ����
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 20000);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
            IPEndPoint epRemote = new IPEndPoint(IPAddress.Parse(IP), Port);
            try
            {
                // ��������
                _socket.Connect(epRemote);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void OpenSwitch(int index)
        {
            Request(RtuCommand.OPEN_SWITCH,_DOAddrHight[index]);
        }
        public void CloseSwith(int index)
        {
            Request(RtuCommand.CLOSE_SWITCH, _DOAddrHight[index]);
        }

        public bool[] ReadDO()
        {
            Request(RtuCommand.READ_VALUE, (byte)0x00);
            return _DOValue;
        }
        #endregion
 /*
        public byte[] RTU_BIND(IPAddress destip, int port, byte dest, string cmdtype ,int addr)
        {
            Socket socket;
            byte[] finalmsg;
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 20000);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
                //����1ָ������IP��ַ���˴�ָ���п��õ�IP��ַ��������2ָ�������õĶ˿�
                //IPEndPoint myHost = new IPEndPoint(IPAddress.Any, 1595);
                //������IP��ַ�Ͷ˿����׽��ְ󶨣�Ϊ������׼��
                //socket.Bind(myHost);
                //����Զ���ն�IP��ַ�Ͷ˿ڣ�ʵ��ʹ��ʱӦΪԶ������IP��ַ����Ϊ��
                //��������׼��
                IPEndPoint remote = new IPEndPoint(destip, port);
                //������Զ������������
                socket.Connect(remote);
                finalmsg = new byte[20];//��󷵻��ֽ�
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
            //��Զ���ն˷�����Ϣ
            try
            {
                byte[] byteout = new byte[255];
                int length;
                switch (cmdtype)
                {
                    case "ReadVal":
                        byteout = this.ReadVal(dest);
                        break;
                    case "OpenSwitch":
                        byteout = this.OpenSwitch(dest,addr);
                        break;
                    case "CloseSwitch":
                        byteout = this.CloseSwitch(dest,addr);
                        break;                   
                    default:
                        break;
                }
                //length=byteout[1]+2;
                //byteout[5]Ϊ����λ
                length = 5 + byteout[5] + 1;
                int iLen = socket.Send(byteout, length, SocketFlags.None);
            }
            catch (Exception err)
            {
                //����̨����쳣��Ϣ����ɾ����ָ�����������ͨ��try-catch��ø��쳣
                Console.WriteLine(err.ToString());
                //�׳�һ���쳣��Ϣ
                throw new Exception(err.Message);
            }
            //���´����ǵȴ����ܷ���ȷ����Ϣ��ʹ���ͷ�֪����������ִ��Ч��
            //�ӱ��ذ󶨵�IP��ַ�Ͷ˿ڽ���Զ���ն˵����ݣ����ؽ��յ��ֽڻ��ֽ�����length = socket.Receive(bytes);
            byte[] byin = new byte[255];
            //byte[] byin = socket.Receive(bytes);
            try { socket.Receive(byin); }
            catch (Exception err) { throw new Exception(err.Message); }
            //���ֻ��֪������ɢ�豸��״̬��Ҳ����DRTU_RVMSG��������һ���ֽں������豸״̬��Ϣ��ʹ�õ�ʱ���ٶԸ��ֽڽ�����������Ҫ��һλ��Ϣ
            socket.ReceiveTimeout = 2000;
            try
            {
                switch (cmdtype)
                {
                    case "ReadVal":
                        finalmsg = this.RecVal(byin);
                        break;
                    default:
                        break;
                }
                ////�ر��׽���
                socket.Close();
                return finalmsg;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


        public byte[] RecVal(byte[] rec)
        {
            byte[] suceed = new byte[1];//
            //suceed[0] = rec[9];
            suceed[0] = rec[10];
            //suceed[1] = rec[9];
            return suceed;
        }

        //���ش򿪿��ƣ��Ĵ�����ʼ��ַ��2
        public byte[] OpenSwitch(byte dest, int addr)
        {
            //���ĸ�ʽ:0-4������ID 5������ 6���豸ID 7�������� 8-9���Ĵ�����ַ 10-11���Ĵ�����ַƫ��
            byte[] byout = new byte[12];
            byout[0] = 0;
            byout[1] = 0;
            byout[2] = 0;
            byout[3] = 0;
            byout[4] = 0;
            byout[5] = 6;
            byout[6] = dest;
            byout[7] = 5;
            byout[8] = 0x50;
            byout[9] = Convert.ToByte(addr-1);
            byout[10] = 0;
            byout[11] = 0;
                      
            return byout;
        }

        public byte[] CloseSwitch(byte dest, int addr)
        {
            //���ĸ�ʽ:0-4������ID 5������ 6���豸ID 7�������� 8-9���Ĵ�����ַ 10-11���Ĵ�����ַƫ��
            byte[] byout = new byte[12];

            byout[0] = 0;
            byout[1] = 0;
            byout[2] = 0;
            byout[3] = 0;
            byout[4] = 0;
            byout[5] = 6;
            byout[6] = dest;
            byout[7] = 5;
            byout[8] = 0x50;
            byout[9] = Convert.ToByte(addr-1);
            byout[10] = 0xFF;
            byout[11] = 0;

            return byout;
        }

        public byte[] ReadVal(byte dest)
        {
            //���ĸ�ʽ:0-4������ID 5������ 6���豸ID 7�������� 8-9���Ĵ�����ַ 10-11���Ĵ�����ַƫ��
            byte[] byout = new byte[12];

            byout[0] = 0;
            byout[1] = 0;
            byout[2] = 0;
            byout[3] = 0;
            byout[4] = 0;
            byout[5] = 6;
            byout[6] = dest;
            byout[7] = 1;
            byout[8] = 0x50;
            byout[9] = 0x70;
            byout[10] = 0;
            byout[11] = 16;

            return byout;
        }
 */ 

    }
}
