using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Drawing;

namespace YGJZJL.Car
{
    /// <summary>
    /// Һ����ʾ���࣬���ڲ���Һ���������ô���ͨѶ
    /// </summary>
    class CoolDisplay
    {

        #region private member variable

        private SerialPort m_SerialPort;
        private string m_szDeviceType;//�豸���ͣ���ͬ�豸�Ĳ�ͬ������ͨ���α������д���
        private string m_szDeviceName;//�豸���ƣ�����������1#����Ҫ����д��־
        private string m_szStateInfo;//�豸״̬(�򿪻��߹ر�)
        private string m_szState;    //�豸״̬�����С�ʹ�ã�
        private bool m_bOpened;


        //���ڲ���
        private string m_szPortName;
        private int m_nBaudRate;
        private Parity m_Parity;
        private int m_nDataBits;
        private StopBits m_StopBits;

        #endregion

        #region constructor

        public CoolDisplay()
        {
            m_SerialPort = null;
            m_szDeviceType = "";
            m_szDeviceName = "";
            m_szStateInfo = "close";
            m_szState = "close";
            m_bOpened = false;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="szSerialParams">���ڲ��������������¸�ʽ��������,������,У��λ,����λ,ֹͣλ
        ///                                         �磺COM9,9600,N,8,1��COM2,115200,E,7,1.5</param>
        public CoolDisplay(string szSerialParams)
        {
            string[] strtmp = szSerialParams.Split(new char[] { ',' });
            PortName = strtmp[0];
            BaudRate = Convert.ToInt32(strtmp[1]);
            Parity = strtmp[2];
            DataBits = Convert.ToInt32(strtmp[3]);
            StopBits = strtmp[4];
        }

        #endregion

        #region methods

        /// <summary>
        /// ��ͨѶ��
        /// </summary>
        /// <returns></returns>
        public bool Open()
        {
            try
            {
                if (m_SerialPort == null || m_SerialPort.IsOpen == false)
                {
                    m_SerialPort = new SerialPort(m_szPortName, m_nBaudRate, m_Parity, m_nDataBits, m_StopBits);

                    m_SerialPort.Open();
                    m_szStateInfo = "open";
                    m_szState = "idle";
                    m_bOpened = true;
                    m_SerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(SerialPortErrorHandler);
                    return true;
                }
                else
                {
                    return true;                    
                }
            }
            catch (System.Exception exp)
            {
                WriteLog("�� " + PortName + " ʧ��");
                m_szStateInfo = "close";
                m_szState = "close";
                m_bOpened = false;
                return false;
            }
        }

        /// <summary>
        /// �ر�ͨѶ��
        /// </summary>
        /// <returns></returns>
        public bool Close()
        {
            try
            {
                if (m_SerialPort.IsOpen)
                {
                    m_SerialPort.Close();                    
                }

                m_szStateInfo = "close";
                m_szState = "close";
                m_bOpened = false;
                return true;
            }
            catch (System.Exception exp)
            {
                return false;
            }
        }

        /// <summary>
        /// ת���ַ���Ϊint����
        /// </summary>
        /// <param name="s">Ҫת�����ַ���</param>
        /// <returns></returns>
        private int[] StringToHexString(string s)
        {
            Encoding CnEnconding = Encoding.GetEncoding("GB2312");

            byte[] b = CnEnconding.GetBytes(s);
            int[] rel = new int[b.Length];
            string result = string.Empty;
            int i = 0;
            for (i = 0; i < b.Length; i++)//���ֽڱ�Ϊ16�����ַ�����%����
            {
                result += "%" + Convert.ToString(b[i], 16);
                rel[i] = Convert.ToInt32(b[i]);
            }

            return rel;
        }

        /// <summary>
        /// 24λ���ɫת16λ��ɫ
        /// </summary>
        /// <param name="rgb">���ɫ����</param>
        /// <returns></returns>
        private byte[] Get565FromARGB(Color rgb)
        {
            ushort ret = 0;

            ushort r = rgb.R;
            ushort g = rgb.G;
            ushort b = rgb.B;

            ret = (ushort)(((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3));

            byte[] retbyte = new byte[] { (byte)(ret >> 8), (byte)ret };
            return retbyte;
        }

        /// <summary>
        /// ��������ÿ��ִ��һ������ǰӦ���ô˷���
        /// </summary>
        /// <returns></returns>
        public bool ClearScreen()
        {
            if (m_bOpened == false)
            {
                return false;
            }

            byte[] strCommand = new byte[] { 0xAA, 0x52, 0xCC, 0x33, 0xC3, 0x3C };
            m_SerialPort.Write(strCommand, 0, strCommand.Length);

            return true;
        }

        /*
         * ���õ�ǰ��ɫ��(0x40)
         * TX: AA 40 <FC> <BC> CC 33 C3 3C
         * Rx: ��
         * <FC> ǰ��ɫ��ɫ��, 2 �ֽ� (16 bit, 65K color,565ģʽ), ��λĬ��ֵ�� 0xFFFF (��ɫ)��
         * <BC> ����ɫ��ɫ��, 2 �ֽ�(16 bit, 65K color,565ģʽ),��λĬ��ֵ�� 0x001F (��ɫ)��
         */
        /// <summary>
        /// ����ǰ��ɫ�ͱ���ɫ������98����������趨��ǰ��ɫ�������ã��ͻ��˵���98����ʱ���Ϊ����ʾһ�£����ʹ�ñ��������õ�ǰ��ɫ��Ϊ������ɫ
        /// </summary>
        /// <param name="colorFore">ǰ��ɫ</param>
        /// <param name="colorBack">����ɫ</param>
        /// <returns></returns>
        public bool SetDisplayColor(Color colorFore, Color colorBack)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            byte[] foreColor = Get565FromARGB(colorFore);
            byte[] backColor = Get565FromARGB(colorBack);

            byte[] strCommand = new byte[10];
            strCommand[0] = 0xAA;
            strCommand[1] = 0x40;

            strCommand[2] = foreColor[0];
            strCommand[3] = foreColor[1];
            strCommand[4] = backColor[0];
            strCommand[5] = backColor[1];

            strCommand[6] = 0xCC;
            strCommand[7] = 0x33;
            strCommand[8] = 0xC3;
            strCommand[9] = 0x3C;

            m_SerialPort.Write(strCommand, 0, 10);

            return true;
        }

        /// <summary>
        /// ��ָ��������ָ���ֿ��ָ����ʽ��ʾ�ַ���
        /// </summary>
        /// <param name="x">x����</param>
        /// <param name="y">y����</param>
        /// <param name="LibID">�ֿ�ѡ��ȡֵ��Χ0x00-0x3B</param>
        /// <param name="Mode">ѡ���ı���ʾģʽ�Լ����뷽ʽ</param>
        /// <param name="FontSize">�����С��Ŀǰ׼��ʹ�õ������ֿ�ֻ֧��1-7����ֻ��7�ܹ���ȷ��ʾ</param>
        /// <param name="ForeColor">������ɫ��һ�����Ӧ�ú�SetDisplayColor�������õ�ǰ��ɫһ��</param>
        /// <param name="BackColor">���屳��ɫ����ModeΪ0x8*ʱ����ɫ��������</param>
        /// <param name="strData">Ҫ��ʾ���ַ���</param>
        /// <returns></returns>
        public bool WriteText(ushort x, ushort y, byte LibID, byte Mode, byte FontSize, Color ForeColor, Color BackColor, string strData)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            int j = 0;
            int[] reVal;

            byte[] fore = Get565FromARGB(ForeColor);
            byte[] back = Get565FromARGB(BackColor);

            reVal = StringToHexString(strData);
            byte[] strCommand = new byte[255];
            strCommand[0] = 0xAA;
            strCommand[1] = 0x98;
            strCommand[2] = (byte)(x >> 8);
            strCommand[3] = (byte)x;
            strCommand[4] = (byte)(y >> 8);
            strCommand[5] = (byte)y;            
            strCommand[6] = LibID;//�ֿ�ѡ��ȡֵ��Χ0x00-0x3B
            strCommand[7] = Mode;//ѡ���ı���ʾģʽ�Լ����뷽ʽ
            strCommand[8] = FontSize;//�����С��Ŀǰ׼��ʹ�õ������ֿ�ֻ֧��1-7
            strCommand[9] = fore[0];
            strCommand[10] = fore[1];
            strCommand[11] = back[0];
            strCommand[12] = back[1];
            for (j = 0; j < reVal.Length; j++)
            {
                strCommand[j + 13] = (byte)(reVal[j]);
            }
            strCommand[reVal.Length + 13] = 0xCC;
            strCommand[reVal.Length + 14] = 0x33;
            strCommand[reVal.Length + 15] = 0xC3;
            strCommand[reVal.Length + 16] = 0x3C;

            m_SerialPort.Write(strCommand, 0, 17 + reVal.Length);

            return true;
        }

        /// <summary>
        /// ��ָ��������͸��������ʾ�ַ���
        /// </summary>
        /// <param name="x">x����</param>
        /// <param name="y">y����</param>
        /// <param name="ForeColor">������ɫ</param>
        /// <param name="strData">Ҫ��ʾ���ַ���</param>
        /// <returns></returns>
        public bool WriteText(ushort x, ushort y, Color ForeColor, string strData)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            int j = 0;
            int[] reVal;

            byte[] fore = Get565FromARGB(ForeColor);


            reVal = StringToHexString(strData);
            byte[] strCommand = new byte[255];
            strCommand[0] = 0xAA;
            strCommand[1] = 0x98;
            strCommand[2] = (byte)(x >> 8);
            strCommand[3] = (byte)x;
            strCommand[4] = (byte)(y >> 8);
            strCommand[5] = (byte)y;
            strCommand[6] = 0x23;//�ֿ�ѡ��ȡֵ��Χ0x00-0x3B
            strCommand[7] = 0x81;//ѡ���ı���ʾģʽ�Լ����뷽ʽ
            strCommand[8] = 0x03;//�����С��Ŀǰ׼��ʹ�õ������ֿ�ֻ֧��1-7
            strCommand[9] = fore[0];
            strCommand[10] = fore[1];
            strCommand[11] = 0x00;
            strCommand[12] = 0x1F;
            for (j = 0; j < reVal.Length; j++)
            {
                strCommand[j + 13] = (byte)(reVal[j]);
            }
            strCommand[reVal.Length + 13] = 0xCC;
            strCommand[reVal.Length + 14] = 0x33;
            strCommand[reVal.Length + 15] = 0xC3;
            strCommand[reVal.Length + 16] = 0x3C;

            m_SerialPort.Write(strCommand, 0, 17 + reVal.Length);

            return true;
        }

        /// <summary>
        /// ��ָ�������Ա�׼�ֿ��ϵͳԤ���ʽ��ʾ�ַ���
        /// </summary>
        /// <param name="x">x����</param>
        /// <param name="y">y����</param>
        /// <param name="Font">���壺       0x53: ��ʾ 8*8 ���� ASCII �ַ�����
        ///                                 0x54: ��ʾ 16*16 �������չ�뺺���ַ�����ASCII �ַ��԰�� 8*16 ������ʾ��
        ///                                 0x55: ��ʾ 32*32 ��������뺺���ַ�����ASCII �ַ��԰�� 16*32 ������ʾ��
        ///                                 0x6E: ��ʾ 12*12 �������չ�뺺���ַ�����ASCII �ַ��԰�� 6*12 ������ʾ��
        ///                                 0x6F: ��ʾ 24*24 ��������뺺���ַ�����ASCII �ַ��԰�� 12*24 ������ʾ��</param>
        /// <param name="strData">Ҫ��ʾ���ַ���</param>
        /// <returns></returns>
        public bool WriteText(ushort x, ushort y, byte Font, string strData)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            if (Font != 0x53 && Font != 0x54 && Font != 0x55 && Font != 0x6E && Font != 0x6F)
            {
                return false;
            }

            int i = 0;
            int j = 0;
            int[] reVal;

            reVal = StringToHexString(strData);
            byte[] strCommand = new byte[255];
            strCommand[i++] = 0xAA;
            strCommand[i++] = Font;
            strCommand[i++] = (byte)(x >> 8);
            strCommand[i++] = (byte)x;
            strCommand[i++] = (byte)(y >> 8);
            strCommand[i++] = (byte)y;
            
            for (j = 0; j < reVal.Length; j++)
            {
                strCommand[i++] = (byte)(reVal[j]);
            }
            strCommand[i++] = 0xCC;
            strCommand[i++] = 0x33;
            strCommand[i++] = 0xC3;
            strCommand[i++] = 0x3C;

            m_SerialPort.Write(strCommand, 0, i);

            return true;
        }

        /// <summary>
        /// ȫ����ʾͼƬ
        /// </summary>
        /// <param name="PictureID">���е�ͼƬID</param>
        /// <returns></returns>
        public bool DrawPicture(int PictureID)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            byte[] pid = new byte[] { (byte)(PictureID >> 24), (byte)((PictureID << 8) >> 24), (byte)((PictureID << 16) >> 24), (byte)PictureID };

            byte[] strCommand = null;
            if (pid[0] > 0)
            {
                strCommand = new byte[] { 0xAA, 0x70, pid[0], pid[1], pid[2], pid[3], 0xCC, 0x33, 0xC3, 0x3C };
            }
            else if (pid[1] > 0)
            {
                strCommand = new byte[] { 0xAA, 0x70, pid[1], pid[2], pid[3], 0xCC, 0x33, 0xC3, 0x3C };
            }
            else if (pid[2] > 0)
            {
                strCommand = new byte[] { 0xAA, 0x70, pid[2], pid[3], 0xCC, 0x33, 0xC3, 0x3C };
            }
            else
            {
                strCommand = new byte[] { 0xAA, 0x70, pid[3], 0xCC, 0x33, 0xC3, 0x3C };
            }

            m_SerialPort.Write(strCommand, 0, strCommand.Length);

            return true;
        }

        /// <summary>
        /// ��ʾ����ͼ
        /// </summary>
        /// <param name="PictureID">ͼƬ�ڿ��е�ID</param>
        /// <param name="left">ǰ������-��</param>
        /// <param name="top">ǰ������-��</param>
        /// <param name="right">ǰ������-��</param>
        /// <param name="bottom">ǰ������-��</param>
        /// <param name="x">��ͼ����x</param>
        /// <param name="y">��ͼ����y</param>
        /// <returns></returns>
        public bool DrawClipPicture(int PictureID, ushort left, ushort top, ushort right, ushort bottom, ushort x, ushort y)
        {
            if (m_bOpened == false)
            {
                return false;
            }

            int i = 0;

            byte[] strCommand = new byte[255];

            strCommand[i++] = 0xAA;
            strCommand[i++] = 0x71;

            byte[] pid = new byte[] { (byte)(PictureID >> 24), (byte)((PictureID << 8) >> 24), (byte)((PictureID << 16) >> 24), (byte)PictureID };

            if (pid[0] > 0)
            {
                strCommand[i++] = pid[0];
                strCommand[i++] = pid[1];
                strCommand[i++] = pid[2];
                strCommand[i++] = pid[3];
            }
            else if (pid[1] > 0)
            {
                strCommand[i++] = pid[1];
                strCommand[i++] = pid[2];
                strCommand[i++] = pid[3];
            }
            else if (pid[2] > 0)
            {
                strCommand[i++] = pid[2];
                strCommand[i++] = pid[3];
            }
            else
            {
                strCommand[i++] = pid[3];
            }


            strCommand[i++] = (byte)(left >> 8);
            strCommand[i++] = (byte)left;
            strCommand[i++] = (byte)(top >> 8);
            strCommand[i++] = (byte)top;

            strCommand[i++] = (byte)(right >> 8);
            strCommand[i++] = (byte)right;
            strCommand[i++] = (byte)(bottom >> 8);
            strCommand[i++] = (byte)bottom;

            strCommand[i++] = (byte)(x >> 8);
            strCommand[i++] = (byte)x;
            strCommand[i++] = (byte)(y >> 8);
            strCommand[i++] = (byte)y;

            strCommand[i++] = 0xCC;
            strCommand[i++] = 0x33;
            strCommand[i++] = 0xC3;
            strCommand[i++] = 0x3C;

            m_SerialPort.Write(strCommand, 0, i);

            return true;
        }

        private void SerialPortErrorHandler(object o, SerialErrorReceivedEventArgs e)
        {
            m_szStateInfo = e.EventType.ToString();
            WriteLog("SerialPortErrorHandler:" + e.EventType.ToString());
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

                System.IO.TextWriter tw = new System.IO.StreamWriter(m_szRunPath + "\\log\\" + DeviceName + "_" + PortName + "-" + strDate + "_Display.log", true);

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

        #region ����
        
        /// <summary>
        /// �豸����
        /// </summary>
        public string DeviceType
        {
            get
            {
                return m_szDeviceType;
            }
            set
            {
                m_szDeviceType = value;
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
        /// ״̬��Ϣ
        /// </summary>
        public string State
        {
            get
            {
                return m_szState;
            }
            set
            {
                m_szState = value;
            }
        }
        /// <summary>
        /// �豸�˿�����
        /// </summary>
        public string PortName
        {
            get
            {
                return m_szPortName;
            }
            set
            {
                m_szPortName = value;
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public int BaudRate
        {
            get
            {
                return m_nBaudRate;
            }
            set
            {
                m_nBaudRate = value;
            }
        }

        /// <summary>
        /// У��λ
        /// </summary>
        public string Parity
        {
            get
            {
                if (m_Parity == System.IO.Ports.Parity.None)
                {
                    return "NONE";
                }
                else if (m_Parity == System.IO.Ports.Parity.Odd)
                {
                    return "ODD";
                }
                else if (m_Parity == System.IO.Ports.Parity.Even)
                {
                    return "EVEN";
                }
                else if (m_Parity == System.IO.Ports.Parity.Mark)
                {
                    return "MARK";
                }
                else if (m_Parity == System.IO.Ports.Parity.Space)
                {
                    return "SPACE";
                }
                return "unknown";
            }
            set
            {
                if (value.ToUpper() == "NONE")
                {
                    m_Parity = System.IO.Ports.Parity.None;
                }
                else if (value.ToUpper() == "ODD")
                {
                    m_Parity = System.IO.Ports.Parity.Odd;
                }
                else if (value.ToUpper() == "EVEN")
                {
                    m_Parity = System.IO.Ports.Parity.Even;
                }
                else if (value.ToUpper() == "MARK")
                {
                    m_Parity = System.IO.Ports.Parity.Mark;
                }
                else if (value.ToUpper() == "SPACE")
                {
                    m_Parity = System.IO.Ports.Parity.Space;
                }
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public int DataBits
        {
            get
            {
                return m_nDataBits;
            }
            set
            {
                m_nDataBits = value;
            }
        }

        /// <summary>
        /// ֹͣλ
        /// </summary>
        public string StopBits
        {
            get
            {
                if (m_StopBits == System.IO.Ports.StopBits.None)
                {
                    return "0";
                }
                else if (m_StopBits == System.IO.Ports.StopBits.One)
                {
                    return "1";
                }
                else if (m_StopBits == System.IO.Ports.StopBits.Two)
                {
                    return "2";
                }
                else if (m_StopBits == System.IO.Ports.StopBits.OnePointFive)
                {
                    return "1.5";
                }

                return "unknown";
            }
            set
            {
                if (value.ToUpper() == "0")
                {
                    m_StopBits = System.IO.Ports.StopBits.None;
                }
                else if (value.ToUpper() == "1")
                {
                    m_StopBits = System.IO.Ports.StopBits.One;
                }
                else if (value.ToUpper() == "2")
                {
                    m_StopBits = System.IO.Ports.StopBits.Two;
                }
                else if (value.ToUpper() == "1.5")
                {
                    m_StopBits = System.IO.Ports.StopBits.OnePointFive;
                }
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
