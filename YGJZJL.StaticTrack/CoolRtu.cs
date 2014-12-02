using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace YGJZJL.StaticTrack
{
    /// <summary>
    /// Rtu�࣬Rtu����Modbus TCPͨѶЭ�����ͨ��
    /// </summary>
    class CoolRtu
    {
        #region private member variable

        private Socket m_hSocket;

        private string m_RtuIP;//rtu ip��ַ
        private int m_RtuPort;//rtu ͨѶ�˿�

        private string m_szDeviceName;//�豸���ƣ����������ƣ�
        private string m_szStateInfo;//�豸״̬

        private bool m_bOpened;
        private bool m_bRunning;

        //Rtu����
        private byte[] m_szData;

        //�߳�
        private System.Threading.Thread m_hThread;

        #endregion

        #region constructor

        public CoolRtu()
        {
            m_hSocket = null;
            m_RtuIP = "";
            m_RtuPort = 0;

            m_bRunning = false;
            m_szDeviceName = "";
            m_bOpened = false;
            m_szStateInfo = "";
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="strIP">IP��ַ</param>
        /// <param name="nPort">ͨѶ�˿�</param>
        public CoolRtu(string strIP, int nPort)
        {
            m_RtuIP = strIP;
            m_RtuPort = nPort;
        }

        #endregion

        #region methods

        /// <summary>
        /// �ͷ���������ͨѶ����
        /// </summary>
        public bool Connect2Server()
        {
            if (m_hSocket != null)
            {
                return true;
            }

            try
            {
                m_hSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                //���ý��ܳ�ʱʱ��Ϊ3��
                m_hSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);
                m_hSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);

                IPEndPoint remote = new IPEndPoint(IPAddress.Parse(m_RtuIP), m_RtuPort);

                //������Զ������������
                m_hSocket.Connect(remote);
                m_bOpened = true;
                m_szStateInfo = "open";
                
                return true;
            }
            catch (Exception error)
            {
                WriteLog(m_szDeviceName + ")��Rtu��������ʱ��������" + error.Message);
                m_bOpened = false;
                m_hSocket = null;
                m_szStateInfo = "close";
                
                return false;
            }
        }

        public void Close()
        {
            //�ر�����
            try
            {
                if (m_hSocket.Connected == true)
                {
                    m_hSocket.Close();
                    m_bOpened = false;
                    m_hSocket = null;
                    m_szStateInfo = "close";
                    WriteLog(m_szDeviceName + ")Rtu�����ر�");
                }
            }
            catch (System.Exception error)
            {
                WriteLog(m_szDeviceName + ")�ر�Rtuʱ��������" + error.Message);
            }
        }

        /// <summary>
        /// ��Rtu��������
        /// </summary>
        /// <param name="device">�豸��ַ��ͨ��ָRtu��ĳһģ��</param>
        /// <param name="Command">����,1-���Ĵ������ݣ�5-������Ȧ�����أ�״̬</param>
        /// <param name="AddrH">��ַƫ�Ƹ�8λ</param>
        /// <param name="AddrL">��ַƫ�Ƶ�8λ</param>
        /// <param name="DevH">��Ҫ�����ݸ�8λ</param>
        /// <param name="DevL">��Ҫ�ĸ�����8λ</param>
        /// <returns></returns>
        public byte[] RtuCommand(byte device, byte Command, byte AddrH, byte AddrL, byte DevH, byte DevL)
        {
            if (m_bOpened == false)
            {
                return null;
            }


            byte[] byteRet = new byte[20];
            byte[] byteout = new byte[12];
            int length = 0;

            byteout[0] = 0;
            byteout[1] = 0;
            byteout[2] = 0;
            byteout[3] = 0;
            byteout[4] = 0;
            byteout[5] = 6;
            byteout[6] = device;//�豸��ַ��ͨ��ָRtu��ĳһģ��
            byteout[7] = Command;
            byteout[8] = AddrH;
            byteout[9] = AddrL;
            byteout[10] = DevH;//��CommandΪ5ʱ��0xFF��ʾ��Ȧ�Ͽ���0x00��ʾ��Ȧ�պ�
            byteout[11] = DevL;

            length = 5 + byteout[5] + 1;

            try
            {
                int iLen = m_hSocket.Send(byteout, length, SocketFlags.None);
                System.Threading.Thread.Sleep(50);

                m_hSocket.Receive(byteRet);

                return byteRet;
            }
            catch (Exception error)
            {
                WriteLog(m_szDeviceName + ")RtuͨѶ����" + error.Message);
                m_bOpened = false;
                m_hSocket.Close();
                m_hSocket = null;
                m_szStateInfo = "δ����";
            }
            return null;
        }

        /// <summary>
        /// ����ͨѶ�̣߳����ڷ��������ʵ�����󣬲�Ӧ���ô˷���
        /// </summary>
        /// <returns></returns>
        public bool StartUse()
        {
            if (m_bOpened == false)
            {
                return false;
            }

            m_bRunning = true;
            m_hThread = new System.Threading.Thread(new System.Threading.ThreadStart(DeviceThread));
            m_hThread.Start();

            return true;
        }

        /// <summary>
        /// ���ݲɼ��߳�
        /// </summary>
        private void DeviceThread()
        {
            try
            {
                while (m_bRunning)
                {
                    try
                    {
                        System.Threading.Thread.Sleep(100);

                        m_szData = RtuCommand(1, 1, 0x50, 0x70, 0, 16);
                    }
                    catch (System.Exception error)
                    {
                        WriteLog(m_szDeviceName + ")Rtu����" + error.Message);
                        m_bOpened = false;
                        m_hSocket.Close();
                        m_hSocket = null;
                        m_szStateInfo = "δ����";
                    }
                }

                m_bOpened = false;

                //�ر�����
                try
                {
                    m_hSocket.Close();

                    m_szStateInfo = "close";
                    WriteLog(m_szDeviceName + ")Rtu�����ر�");
                }
                catch (System.Exception error)
                {
                    WriteLog(m_szDeviceName + ")�ر�Rtuʱ��������" + error.Message);
                }
            }
            catch (System.Exception exp)
            {
                WriteLog(m_szDeviceName + ")����" + exp.Message);
            }
        }

        /// <summary>
        /// ��ȡRtu�ɼ��������ݣ������������ݲɼ��߳�
        /// </summary>
        /// <returns></returns>
        public byte[] GetData()
        {
            return m_szData;
        }

        /// <summary>
        /// ֹͣʹ�ã��߳���ֹ
        /// </summary>
        public void StopUse()
        {
            m_bRunning = false;

            for (int i = 0; i < 50; i++)
            {
                if (m_bOpened == false)
                {
                    break;
                }

                System.Threading.Thread.Sleep(100);
            }

            m_bOpened = false;
        }

        private void WriteLog(string str)
        {
            try
            {
                string m_szRunPath = System.Environment.CurrentDirectory.ToString();
                //string m_szRunPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                if (!(System.IO.Directory.Exists(m_szRunPath + "\\log")))
                {
                    System.IO.Directory.CreateDirectory(m_szRunPath + "\\log");
                }

                string strDate = System.DateTime.Now.ToString("yyyyMMddhhmm");

                System.IO.TextWriter tw = new System.IO.StreamWriter(m_szRunPath + "\\log\\" + DeviceName + "-" + strDate + "_socket.log", true);

                tw.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                tw.WriteLine(str);
                tw.WriteLine("\r\n");

                tw.Close();
            }
            catch (Exception e)
            {
                ;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Rtu IP��ַ
        /// </summary>
        public string RtuIP
        {
            get
            {
                return m_RtuIP;
            }
            set
            {
                m_RtuIP = value;
            }
        }

        /// <summary>
        /// RtuͨѶ�˿�
        /// </summary>
        public int RtuPort
        {
            get
            {
                return m_RtuPort;
            }
            set
            {
                m_RtuPort = value;
            }
        }

        /// <summary>
        /// �豸����
        /// </summary>
        public string DeviceName
        {
            get
            {
                return m_szDeviceName;
            }
            set
            {
                m_szDeviceName = value;
            }
        }

        /// <summary>
        /// ״̬��Ϣ
        /// </summary>
        public string StateInfo
        {
            get
            {
                return m_szStateInfo;
            }
            set
            {
                m_szStateInfo = value;
            }
        }

        /// <summary>
        /// �Ƿ�򿪣�ֻ��
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return m_bOpened;
            }
        }
        #endregion


    }
}
