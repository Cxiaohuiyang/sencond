using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using SDK_Com;
using System.Threading;


namespace YGJZJL.Car
{
    /// <summary>
    /// �������࣬���ڲ���������
    /// </summary>
    class PoundRoom
    {
        #region private member variable

        //���ݱ�JL_POINTINFO�ֶ�ӳ��
        private string m_POINTID;//���������
        private string m_POINTNAME;//����������
        private string m_POINTTYPE;//�������������

        private string m_VIEDOIP;//Ӳ��¼���IP
        private string m_VIEDOPORT;//Ӳ��¼����˿�
        private string m_VIEDOUSER;//Ӳ��¼����û���
        private string m_VIEDOPWD;//Ӳ��¼�������

        private string m_MOXAIP;//MOXA��IP

        private string m_METERTYPE;//�Ǳ�����
        private string m_METERPARA;//�Ǳ����
        private string m_MOXAPORT;//�����Ǳ�MOXA���˿�        

        private string m_RTUIP;//RTUIP
        private string m_RTUPORT;//RTU�˿�

        private string m_PRINTERIP;//��ӡ������IP
        private string m_PRINTERNAME;//��ӡ������
        private string m_PRINTTYPECODE;//��ӡ�����ʹ���
        private int m_USEDPAPER;//����ֽ����
        private int m_TOTALPAPAR;//��ӡֽ������

        private string m_STATUS;//������״̬ IDLE-���� USE-���ڼ���
        private string m_ACCEPTTERMINAL;//�ӹܵ��ն�IP

        private string m_LEDPORT;//������MOXA���˿�
        private string m_LEDPARA;//������MOXA������
        private string m_LEDTYPE;//����������

        private string m_READERPORT;//������MOXA���˿�
        private string m_READERPARA;//������MOXA������
        private string m_READERTYPE;//����������

        private string m_DISPLAYPORT;//Һ����MOXA���˿�
        private string m_DISPLAYPARA;//Һ����MOXA������
        private string m_DISPLAYTYPE;//Һ��������

        private decimal m_ZEROVALUE;//��λֵ

        private decimal m_CLEARVALUE;//�����ȶ�ֵ

        //ʹ�ú����豸��־
        private bool m_bUseMeter;//�ɼ��Ǳ�����
        private bool m_bUseLED;//ʹ��LED
        private bool m_bUseReader;//ʹ�ö�����
        private bool m_bUseDisplay;//ʹ��Һ����
        private bool m_bUseRtu;//ʹ��Rtu

        //MOXA
        private CoolSerial m_CoolSerialForMeter;//�Ǳ�
        private CoolReader m_CoolReader;//������
        private CoolDisplay m_CoolDisplay;//Һ����
        private CoolSerial m_CoolSerialForLed;//LED

        //RTU
        private CoolRtu m_CoolRtu;//Rtu data collect
        private CoolRtu m_CoolRtuForCommand;//Rtu command send

        //�߳�
        private System.Threading.Thread m_hThread;//�߳�
        private bool m_bRunning;//�߳����п���

        //����
        private string m_szMeterData;//�Ǳ�ɼ�����
        private decimal m_MeterValue;//�Ǳ���������
        private decimal m_MeterPreData;//�Ǳ�ǰһ������
        private int m_nMeterStabTimes;//�Ǳ��ȶ�����

        private string m_szReaderGUID;//������ȫ��Ψһ��
        private string m_szReaderCardNo;//����������
        private byte[] m_szRtuData;//Rtu data

        //��λ
        private bool m_bDistributed;//�Ƿ���λ

        //sign
        private bool m_bSigned;//�ӹ�

        //����������ʾ
        private SoundPlayer m_SoundPlayer;//��������

        //Ӳ��¼���
        private SDK_Com.HKDVR m_VideoRecord;//Ӳ��¼�����
        private int m_VideoHandle;//Ӳ��¼��������SDK_Login��ȡ��ֵ
        private int m_Channel1;//ͨ��1���
        private int m_Channel2;//ͨ��2���
        private int m_Channel3;//ͨ��3���
        private int m_Channel4;//ͨ��4���
        private int m_Channel5;//ͨ��5���
        private int m_Channel6;//ͨ��6���
        private int m_Channel7;//ͨ��7���
        private int m_Channel8;//ͨ��8���
        private bool m_bTalk;//�Ƿ����ڶԽ�
        private int m_TalkID;//�Խ����
        private int m_AudioNum; //��ʹ����Ƶ��
        private bool m_IsFirstSend; //�Ƿ񲥷Ź�����
                
        // ʱ��ͬ���߳�
        private Thread m_SynTimeThread;
        private bool m_SynTimeFlag;

        private string m_PointState; //������״̬

        #endregion


        #region constructor

        public PoundRoom()
        {
            m_POINTID = "";//���������
            m_POINTNAME = "";//����������
            m_POINTTYPE = "";//�������������

            m_VIEDOIP = "";//Ӳ��¼���IP
            m_VIEDOPORT = "";//Ӳ��¼����˿�
            m_VIEDOUSER = "";//Ӳ��¼����û���
            m_VIEDOPWD = "";//Ӳ��¼�������

            m_MOXAIP = "";//MOXA��IP

            m_METERTYPE = "";//�Ǳ�����
            m_METERPARA = "";//�Ǳ����
            m_MOXAPORT = "";//�����Ǳ�MOXA���˿�
            m_MeterPreData = 0;//�Ǳ�ǰһ������
            m_nMeterStabTimes = 0;//�Ǳ��ȶ�����

            m_RTUIP = "";//RTUIP
            m_RTUPORT = "";//RTU�˿�

            m_PRINTERIP = "";//��ӡ������IP
            m_PRINTERNAME = "";//��ӡ������
            m_PRINTTYPECODE = "";//��ӡ�����ʹ���
            m_USEDPAPER = 0;//����ֽ����
            m_TOTALPAPAR = 0;//��ӡֽ������
            m_STATUS = "";//������״̬
            m_ACCEPTTERMINAL = "";//�ӹܵ��ն�IP

            m_LEDPORT = "";//������MOXA���˿�
            m_LEDPARA = "";//������MOXA������
            m_LEDTYPE = "";//����������

            m_READERPORT = "";//������MOXA���˿�
            m_READERPARA = "";//������MOXA������
            m_READERTYPE = "";//����������

            m_DISPLAYPORT = "";//Һ����MOXA���˿�
            m_DISPLAYPARA = "";//Һ����MOXA������
            m_DISPLAYTYPE = "";//Һ��������

            m_CLEARVALUE = 0;//�����ȶ�ֵ

            //ʹ�ú����豸��־
            m_bUseMeter = false;//�ɼ��Ǳ�����
            m_bUseLED = false;//ʹ��LED
            m_bUseReader = false;//ʹ�ö�����
            m_bUseDisplay = false;//ʹ��Һ����
            m_bUseRtu = false;//ʹ��rtu

            //MOXA
            m_CoolSerialForMeter = null;//�Ǳ�
            m_CoolReader = null;//������
            m_CoolSerialForLed = null;//LED
            m_CoolDisplay = null;//Һ����

            //rtu
            m_CoolRtu = null;//rtu data collect
            m_CoolRtuForCommand = null;//rtu command send

            //�߳�
            m_hThread = null;//�߳�
            m_bRunning = false;//�߳����п���

            //����
            m_szMeterData = "";//�Ǳ�ɼ�����
            m_szReaderGUID = "";//������ȫ��Ψһ��
            m_szReaderCardNo = "";//����������
            m_szRtuData = null;//rtu data

            //�ӹ�
            m_bSigned = false;

            //��������
            m_SoundPlayer = null;

            //Ӳ��¼���
           // m_VideoRecord = null;
            m_VideoHandle = 0;
            m_Channel1 = 0;//ͨ��1���
            m_Channel2 = 0;//ͨ��2���
            m_Channel3 = 0;//ͨ��3���
            m_Channel4 = 0;//ͨ��4���
            m_Channel5 = 0;//ͨ��5���
            m_Channel6 = 0;//ͨ��6���
            m_Channel7 = 0;//ͨ��7���
            m_Channel8 = 0;//ͨ��8���
            m_bTalk = false;//�Ƿ����ڶԽ�
            m_TalkID = 0;//�Խ����
            m_AudioNum = 1; //��ʹ����Ƶ��
            m_IsFirstSend = true; //��δ���Ź�����

            
            m_PointState = ""; //������״̬
        }

        #endregion


        #region methods

        //private void SynTime()
        //{
        //    while (m_SynTimeFlag)
        //    {
        //        uint dwYear = (uint)System.DateTime.Now.Year;
        //        uint dwMonth = (uint)System.DateTime.Now.Month;
        //        uint dwDay = (uint)System.DateTime.Now.Day;
        //        uint dwHour = (uint)System.DateTime.Now.Hour;
        //        uint dwMinute = (uint)System.DateTime.Now.Minute;
        //        uint dwSecond = (uint)System.DateTime.Now.Second;
        //        int reVal = 0;

        //        m_VideoRecord.SDK_SetupDeviceTime(m_VideoHandle, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, ref reVal);

        //        for (int i = 0; i < 60*10 ; i++)
        //        {
        //            if (m_SynTimeFlag)
        //                break;
        //            System.Threading.Thread.Sleep(1000);
        //        }
        //    }
        //}

        /// <summary>
        /// ����������Ҫ���豸ͨѶ�߳�
        /// </summary>
        public void StartUse()
        {
            //����ʱ��ͬ���߳�
            //if (m_VideoHandle > 0)
            //{
            //    m_SynTimeFlag = true;
            //    m_SynTimeThread = new Thread(new ThreadStart(SynTime));
            //    m_SynTimeThread.Start();
            //}

            int i = 0;//��10�Σ���ʱ�Ǳ�һ�λ�򲻿�
            if (UseMeter)
            {
                m_CoolSerialForMeter = new CoolSerial(METERPARA);
                m_CoolSerialForMeter.DeviceType = METERTYPE;//�Ǳ����ͣ�������δ�������
                m_CoolSerialForMeter.DeviceName = POINTNAME;
                while (m_CoolSerialForMeter.StateInfo != "open" && i < 10)
                {
                    m_CoolSerialForMeter.Open();
                    m_CoolSerialForMeter.StartUse();
                    i++;
                }
                                   
            }

            if (UseLED)
            {
                m_CoolSerialForLed = new CoolSerial(LEDPARA);
                m_CoolSerialForLed.DeviceType = LEDTYPE;//LED���ͣ�������δ�������
                m_CoolSerialForLed.DeviceName = POINTNAME;
                if (m_CoolSerialForLed.Open())
                {
                    //add code here
                }
            }

            if (UseReader)
            {
                m_CoolReader = new CoolReader(READERPARA);
                m_CoolReader.DeviceType = READERTYPE;//���������ͣ�������δ�������
                m_CoolReader.DeviceName = POINTNAME;
                if (m_CoolReader.Open())
                {
                    m_CoolReader.StartUse();
                }                
            }

            if (UseDisplay)
            {
                m_CoolDisplay = new CoolDisplay(DISPLAYPARA);
                m_CoolDisplay.DeviceType = DISPLAYTYPE;//Һ�������ͣ�������δ�������
                m_CoolDisplay.DeviceName = POINTNAME;
                m_CoolDisplay.Open();
            }

            if (UseRtu)
            {
                m_CoolRtu = new CoolRtu(RTUIP, Int32.Parse(RTUPORT));
                m_CoolRtu.DeviceName = POINTNAME;
                if (m_CoolRtu.Connect2Server())
                {
                    m_CoolRtu.StartUse();
                }

                m_CoolRtuForCommand = new CoolRtu(RTUIP, Int32.Parse(RTUPORT));
                m_CoolRtuForCommand.DeviceName = POINTNAME;
                if (m_CoolRtuForCommand.Connect2Server())
                {
                }

            }

            m_bRunning = true;
            m_hThread = new System.Threading.Thread(new System.Threading.ThreadStart(DataCollectThread));
            m_hThread.Start();
        }

        /// <summary>
        /// ���ݲɼ��߳�
        /// </summary>
        private void DataCollectThread()
        {
            try
            {
                while (m_bRunning)
                {
                    if (UseMeter)
                    {
                        MeterData = m_CoolSerialForMeter.StringData;
                        MeterValue = m_CoolSerialForMeter.DecimalData;
                    }
                    if (UseReader)
                    {
                        ReaderGUID = m_CoolReader.GUID;
                        CardNo = m_CoolReader.CardNo;
                    }
                    if (UseRtu)
                    {
                        m_szRtuData = m_CoolRtu.GetData();
                    }
                    
                    System.Threading.Thread.Sleep(100);//�������Ҫ�����߳���������
                }
            }
            catch (System.Exception exp)
            {
                WriteLog(POINTNAME + ")����" + exp.Message);
            }
        }

        /// <summary>
        /// ֹͣ���е��豸ͨѶ�߳�
        /// </summary>
        public void StopUse()
        {  
            m_bRunning = false;

            //ֹͣʱ��ͬ���߳�
            //if (m_SynTimeThread != null)
            //{
            //    m_SynTimeFlag = false;
            //    Thread.Sleep(1000);
            //    m_SynTimeThread.Abort();
            //}

            if (UseMeter)
            {
                if (m_CoolSerialForMeter != null)
                {
                    m_CoolSerialForMeter.StopUse();
                }
            }

            if (UseLED)
            {
                if (m_CoolSerialForLed != null)
                {
                    m_CoolSerialForLed.StopUse();
                }
            }

            if (UseReader)
            {
                if (m_CoolReader != null)
                {
                    m_CoolReader.StopUse();
                    m_CoolReader.Close();
                }
            }

            if (UseDisplay)
            {
                if (m_CoolDisplay != null)
                {
                    m_CoolDisplay.Close();
                }
            }

            if (UseRtu)
            {
                if (m_CoolRtu != null)
                {
                    m_CoolRtu.StopUse();
                }
                if (m_CoolRtuForCommand != null)
                {
                    m_CoolRtuForCommand.Close();
                }
            }
            
            System.Threading.Thread.Sleep(200);
        }

        /// <summary>
        /// ����ҵ�񵽴�ʱ�ڱ�������������ʾ����Ա���в���
        /// </summary>
        /// <param name="location"></param>
        public void PlaySound(string location)
        {
            if (m_SoundPlayer == null)
            {
                m_SoundPlayer = new SoundPlayer();
            }

            m_SoundPlayer.SoundLocation = location;
            m_SoundPlayer.Load();
            m_SoundPlayer.Play();
        }

        /// <summary>
        /// ����ҵ�����ʱ��ն���������,�޸�Һ����״̬
        /// </summary>
        /// <param name="location"></param>
        public void ClearReader()
        {
            m_CoolReader.CardNo = "";
            m_CoolReader.GUID = "";
            m_CoolDisplay.State = "idle";

        }
        /// <summary>
        /// ����ҵ�����ʱ��ն���������(������Guid��)
        /// </summary>
        public void ClearCardNoAndGuid()
        {
            m_CoolReader.CardNo = "";
            m_CoolReader.GUID = "";
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
        public bool SendRtuCommand(byte device, byte Command, byte AddrH, byte AddrL, byte DevH, byte DevL)
        {
            byte[] retByte = m_CoolRtuForCommand.RtuCommand(device, Command, AddrH, AddrL, DevH, DevL);
            if (retByte == null || retByte.Length == 0)
            {
                return false;
            }

            return retByte[0] == Command ? true : false;
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

                System.IO.TextWriter tw = new System.IO.StreamWriter(m_szRunPath + "\\log\\" + POINTID + "-" + strDate + "_pound.log", true);

                tw.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                tw.WriteLine(str);
                tw.WriteLine("\r\n");

                tw.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// ������ID
        /// </summary>
        public string POINTID
        {
            get
            {
                return m_POINTID;
            }
            set
            {
                m_POINTID = value;
            }
        }

        /// <summary>
        /// ����������
        /// </summary>
        public string POINTNAME
        {
            get
            {
                return m_POINTNAME;
            }
            set
            {
                m_POINTNAME = value;
            }
        }

        /// <summary>
        /// ����������
        /// </summary>
        public string POINTTYPE
        {
            get
            {
                return m_POINTTYPE;
            }
            set
            {
                m_POINTTYPE = value;
            }
        }

        /// <summary>
        /// Ӳ��¼���IP
        /// </summary>
        public string VIEDOIP
        {
            get
            {
                return m_VIEDOIP;
            }
            set
            {
                m_VIEDOIP = value;
            }
        }

        /// <summary>
        /// Ӳ��¼����˿�
        /// </summary>
        public string VIEDOPORT
        {
            get
            {
                return m_VIEDOPORT;
            }
            set
            {
                m_VIEDOPORT = value;
            }
        }

        /// <summary>
        /// Ӳ��¼����û���
        /// </summary>
        public string VIEDOUSER
        {
            get
            {
                return m_VIEDOUSER;
            }
            set
            {
                m_VIEDOUSER = value;
            }
        }

        /// <summary>
        /// Ӳ��¼�����������
        /// </summary>
        public string VIEDOPWD
        {
            get
            {
                return m_VIEDOPWD;
            }
            set
            {
                m_VIEDOPWD = value;
            }
        }

        /// <summary>
        /// �����Ǳ�����
        /// </summary>
        public string METERTYPE
        {
            get
            {
                return m_METERTYPE;
            }
            set
            {
                m_METERTYPE = value;
            }
        }

        /// <summary>
        /// �����Ǳ���ͨѶ���������������¸�ʽ��������,������,У��λ,����λ,ֹͣλ���磺COM9,9600,N,8,1��COM2,115200,E,7,1.5
        /// </summary>
        public string METERPARA
        {
            get
            {
                return m_METERPARA;
            }
            set
            {
                m_METERPARA = value;
            }
        }

        /// <summary>
        /// �����Ǳ�ǰһ�����ݶ���ֵ
        /// </summary>
         public decimal MeterPreData
        {
            get
            {
                return m_MeterPreData;
            }
            set
            {
                m_MeterPreData = value;
            }
        }

        /// <summary>
        /// �����Ǳ��ȶ�����
        /// </summary>
        public int MeterStabTimes
        {
            get
            {
                return m_nMeterStabTimes;
            }
            set
            {
                m_nMeterStabTimes = value;
            }
        }       

        /// <summary>
        /// MOXA����IP��ַ�������ã��Գ�����Ӱ��
        /// </summary>
        public string MOXAIP
        {
            get
            {
                return m_MOXAIP;
            }
            set
            {
                m_MOXAIP = value;
            }
        }

        /// <summary>
        /// �����Ǳ�ʹ��MOXA���ض˿�
        /// </summary>
        public string MOXAPORT
        {
            get
            {
                return m_MOXAPORT;
            }
            set
            {
                m_MOXAPORT = value;
            }
        }

        /// <summary>
        /// Rtu IP��ַ
        /// </summary>
        public string RTUIP
        {
            get
            {
                return m_RTUIP;
            }
            set
            {
                m_RTUIP = value;
            }
        }

        /// <summary>
        /// RtuͨѶ�˿�
        /// </summary>
        public string RTUPORT
        {
            get
            {
                return m_RTUPORT;
            }
            set
            {
                m_RTUPORT = value;
            }
        }

        /// <summary>
        /// Ʊ�ݴ�ӡ��IP��ַ�������ã��Գ�����Ӱ��
        /// </summary>
        public string PRINTERIP
        {
            get
            {
                return m_PRINTERIP;
            }
            set
            {
                m_PRINTERIP = value;
            }
        }

        /// <summary>
        /// Ʊ�ݴ�ӡ�����ƣ���ӡʱ�������Ƶ��ö�Ӧ�Ĵ�ӡ��
        /// </summary>
        public string PRINTERNAME
        {
            get
            {
                return m_PRINTERNAME;
            }
            set
            {
                m_PRINTERNAME = value;
            }
        }

        /// <summary>
        /// Ʊ�ݴ�ӡ�����ʹ��룬��ӡ����ֽʱ��ȡ�ܵ�ֽ����
        /// </summary>
        public string PRINTTYPECODE
        {
            get
            {
                return m_PRINTTYPECODE;
            }
            set
            {
                m_PRINTTYPECODE = value;
            }
        }

        /// <summary>
        /// Ʊ�ݴ�ӡ��ʣ��ֽ����
        /// </summary>
        public int USEDPAPER
        {
            get
            {
                return m_USEDPAPER;
            }
            set
            {
                m_USEDPAPER = value;
            }
        }

        /// <summary>
        /// Ʊ�ݴ�ӡ����ֽ��
        /// </summary>
        public int TOTALPAPAR
        {
            get
            {
                return m_TOTALPAPAR;
            }
            set
            {
                m_TOTALPAPAR = value;
            }
        }

        /// <summary>
        /// ������״̬��USE-���ڼ�����IDLE-����
        /// </summary>
        public string STATUS
        {
            get
            {
                return m_STATUS;
            }
            set
            {
                m_STATUS = value;
            }
        }

        /// <summary>
        /// ��δʹ�ô�����
        /// </summary>
        public string ACCEPTTERMINAL
        {
            get
            {
                return m_ACCEPTTERMINAL;
            }
            set
            {
                m_ACCEPTTERMINAL = value;
            }
        }

        /// <summary>
        /// LEDʹ��MOXA���ض˿ڣ������ã��Գ�����Ӱ��
        /// </summary>
        public string LEDPORT
        {
            get
            {
                return m_LEDPORT;
            }
            set
            {
                m_LEDPORT = value;
            }
        }

        /// <summary>
        /// LEDͨѶ������������������
        /// </summary>
        public string LEDPARA
        {
            get
            {
                return m_LEDPARA;
            }
            set
            {
                m_LEDPARA = value;
            }
        }
        
        /// <summary>
        /// LED����
        /// </summary>
        public string LEDTYPE
        {
            get
            {
                return m_LEDTYPE;
            }
            set
            {
                m_LEDTYPE = value;
            }
        }

        /// <summary>
        /// ������MOXA���˿ڣ������ã��Գ�����Ӱ��
        /// </summary>
        public string READERPORT
        {
            get
            {
                return m_READERPORT;
            }
            set
            {
                m_READERPORT = value;
            }
        }

        /// <summary>
        /// ����������ͨѶ���������������¸�ʽ�����ں�,�����ʡ��磺9,9600��2,115200
        /// </summary>
        public string READERPARA
        {
            get
            {
                return m_READERPARA;
            }
            set
            {
                m_READERPARA = value;
            }
        }

        /// <summary>
        /// ���������ͣ���������RF-35�����ݿ���Ӧ���Ƴ�RF35
        /// </summary>
        public string READERTYPE
        {
            get
            {
                return m_READERTYPE;
            }
            set
            {
                m_READERTYPE = value;
            }
        }

        /// <summary>
        /// Һ����MOXA�˿ڣ������ã��Գ�����Ӱ��
        /// </summary>
        public string DISPLAYPORT
        {
            get
            {
                return m_DISPLAYPORT;
            }
            set
            {
                m_DISPLAYPORT = value;
            }
        }

        /// <summary>
        /// Һ��������ͨѶ���������������¸�ʽ��������,������,У��λ,����λ,ֹͣλ���磺COM9,9600,N,8,1��COM2,115200,E,7,1.5
        /// </summary>
        public string DISPLAYPARA
        {
            get
            {
                return m_DISPLAYPARA;
            }
            set
            {
                m_DISPLAYPARA = value;
            }
        }

        /// <summary>
        /// Һ�������ͣ�������ĿӦΪEBN15
        /// </summary>
        public string DISPLAYTYPE
        {
            get
            {
                return m_DISPLAYTYPE;
            }
            set
            {
                m_DISPLAYTYPE = value;
            }
        }

        /// <summary>
        /// ���ֵ����Ϊ�ϳ��ж�
        /// </summary>
        public decimal ZEROVALUE
        {
            get
            {
                return m_ZEROVALUE;
            }
            set
            {
                m_ZEROVALUE = value;
            }
        }

        /// <summary>
        /// �Ƿ�ɼ������Ǳ�
        /// </summary>
        public bool UseMeter
        {
            get
            {
                return m_bUseMeter;
            }
            set
            {
                m_bUseMeter = value;
            }
        }

        /// <summary>
        /// �Ƿ��ж�����
        /// </summary>
        public bool UseReader
        {
            get
            {
                return m_bUseReader;
            }
            set
            {
                m_bUseReader = value;
            }
        }

        /// <summary>
        /// �Ƿ���Һ����
        /// </summary>
        public bool UseDisplay
        {
            get
            {
                return m_bUseDisplay;
            }
            set
            {
                m_bUseDisplay = value;
            }
        }

        /// <summary>
        /// �Ƿ���LED
        /// </summary>
        public bool UseLED
        {
            get
            {
                return m_bUseLED;
            }
            set
            {
                m_bUseLED = value;
            }
        }

        /// <summary>
        /// �Ƿ���Rtu
        /// </summary>
        public bool UseRtu
        {
            get
            {
                return m_bUseRtu;
            }
            set
            {
                m_bUseRtu = value;
            }
        }

        /// <summary>
        /// �����Ǳ�ԭʼͨѶ����
        /// </summary>
        public string MeterData
        {
            get
            {
                return m_szMeterData;
            }
            set
            {
                m_szMeterData = value;
            }
        }


        /// <summary>
        /// �����Ǳ�����
        /// </summary>
        public decimal MeterValue
        {
            get
            {
                return m_MeterValue;
            }
            set
            {
                m_MeterValue = value;
            }
        }


        /// <summary>
        /// ������GUID
        /// </summary>
        public string ReaderGUID
        {
            get
            {
                return m_szReaderGUID;
            }
            set
            {
                m_szReaderGUID = value;
            }
        }

        /// <summary>
        /// ��֤�����Ǻ�
        /// </summary>
        public string CardNo
        {
            get
            {
                return m_szReaderCardNo;
            }
            set
            {
                m_szReaderCardNo = value;
            }
        }

        /// <summary>
        /// RtuͨѶԭʼ����
        /// </summary>
        public byte[] RtuData
        {
            get
            {
                return m_szRtuData;
            }
            set
            {
                m_szRtuData = value;
            }
        }

        /// <summary>
        /// ��δʹ��
        /// </summary>
        public bool Distributed
        {
            get
            {
                return m_bDistributed;
            }
            set
            {
                m_bDistributed = value;
            }
        }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool Signed
        {
            get
            {
                return m_bSigned;
            }
            set
            {
                m_bSigned = value;
            }
        }

        /// <summary>
        /// �������������������������������
        /// </summary>
        public CoolDisplay Display
        {
            get
            {
                return m_CoolDisplay;
            } 
        }

        /// <summary>
        /// Ӳ��¼���
        /// </summary>
        public SDK_Com.HKDVR VideoRecord
        {
            get
            {
                return m_VideoRecord;
            }
            set
            {
                m_VideoRecord = value;
            }
        }

        /// <summary>
        /// Ӳ��¼��������SDK_Login��ȡ��ֵ
        /// </summary>
        public int VideoHandle
        {
            get
            {
                return m_VideoHandle;
            }
            set
            {
                m_VideoHandle = value;
            }
        }

        /// <summary>
        /// ͨ��1���
        /// </summary>
        public int Channel1
        {
            get
            {
                return m_Channel1;
            }
            set
            {
                m_Channel1 = value;
            }
        }

        /// <summary>
        /// ͨ��2���
        /// </summary>
        public int Channel2
        {
            get
            {
                return m_Channel2;
            }
            set
            {
                m_Channel2 = value;
            }
        }

        /// <summary>
        /// ͨ��3���
        /// </summary>
        public int Channel3
        {
            get
            {
                return m_Channel3;
            }
            set
            {
                m_Channel3 = value;
            }
        }

        /// <summary>
        /// ͨ��4���
        /// </summary>
        public int Channel4
        {
            get
            {
                return m_Channel4;
            }
            set
            {
                m_Channel4 = value;
            }
        }

        /// <summary>
        /// ͨ��5���
        /// </summary>
        public int Channel5
        {
            get
            {
                return m_Channel5;
            }
            set
            {
                m_Channel5 = value;
            }
        }

        /// <summary>
        /// ͨ��6���
        /// </summary>
        public int Channel6
        {
            get
            {
                return m_Channel6;
            }
            set
            {
                m_Channel6 = value;
            }
        }

        /// <summary>
        /// ͨ��7���
        /// </summary>
        public int Channel7
        {
            get
            {
                return m_Channel7;
            }
            set
            {
                m_Channel7 = value;
            }
        }

        /// <summary>
        /// ͨ��8���
        /// </summary>
        public int Channel8
        {
            get
            {
                return m_Channel8;
            }
            set
            {
                m_Channel8 = value;
            }
        }

        /// <summary>
        /// �Ƿ����ڶԽ�
        /// </summary>
        public bool Talk
        {
            get
            {
                return m_bTalk;
            }
            set
            {
                m_bTalk = value;
            }
        }

        /// <summary>
        /// �Խ����
        /// </summary>
        public int TalkID
        {
            get
            {
                return m_TalkID;
            }
            set
            {
                m_TalkID = value;
            }
        }

        /// <summary>
        /// �����ȶ�ֵ�������������Ҫ�����ֵ֮��
        /// </summary>
        public decimal CLEARVALUE
        {
            get
            {
                return m_CLEARVALUE;
            }
            set
            {
                m_CLEARVALUE = value;
            }
        }


        /// <summary>
        /// ��ʹ�õ���Ƶ������
        /// </summary>
        public int AUDIONUM
        {
            get
            {
                return m_AudioNum;
            }
            set
            {
                m_AudioNum = value;
            }
        }

        /// <summary>
        /// �Ƿ񲥷Ź�����
        /// </summary>
        public bool ISFIRSTSEND
        {
            get
            {
                return m_IsFirstSend;
            }
            set
            {
                m_IsFirstSend = value;
            }
        }

        /// <summary>
        /// ������״̬ 0�����ã�1����ʽ����
        /// </summary>
        public string POINTSTATE
        {
            get
            {
                return m_PointState;
            }
            set
            {
                m_PointState = value;
            }
        }
        #endregion

        ////Ӳ�̳�ʼ��
        //private void playVedio()
        //{
        //    sdk = new SDK_Com.HKDVR();/*
        //    int nRet = sdk.SDK_Init();
        //    if (nRet == 0)
        //    {
        //        MessageBox.Show("SDK_Init Error");
        //    }*/

        //}

        ////����Ӳ��¼��
        //private void addYPLX()
        //{
        //    if (m_lLoginID >= 0)
        //    {
        //        MessageBox.Show("shut down first");
        //        return;
        //    }

        //    //SDK��ʼ��
        //    int nRet = sdk.SDK_Init();
        //    if (nRet == 0)
        //    {
        //        MessageBox.Show("SDK_Init Error");
        //    }

        //    //Ӳ��¼�����½ 
        //    //������IP �˿� �û��� ���� 
        //    //���أ���½���
        //    m_lLoginID = sdk.SDK_Login("10.25.168.252", 8000, "admin", "12345");

        //    if (m_lLoginID < 0)
        //        return;

        //    //����Ƶ 
        //    //������ͨ���� ����ģʽ ��ʾ��� 
        //    //���أ���Ƶ���
        //    lRealHandle = sdk.SDK_RealPlay(1, 0, (int)VideoChannel1.Handle);
        //    lRealHandle1 = sdk.SDK_RealPlay(2, 0, (int)VideoChannel2.Handle);
        //    //����Ƶ
        //    //��������Ƶ�������Ƶͨ����Ӧ��һ·��Ƶ
        //    System.Threading.Thread.Sleep(500);
        //    sdk.SDK_OpenSound(lRealHandle);
        //    sdk.SDK_SetVolume(65500);
        //}

        ////����
        //private bool SendCustomVoiceData(string strFileName)
        //{
        //    int reVal = 0;
        //    if (m_bSendingData == true)
        //    {
        //        return false;
        //    }

        //    m_bSendingData = true;

        //    if (m_lTalkHandle >= 0)
        //    {
        //        //ֹͣ�Խ�
        //        sdk.SDK_StopTalk();
        //        m_lTalkHandle = -1;
        //        button2.Text = "start talk";
        //    }

        //    //�Զ�����������
        //    //�������ļ�·������������׼������Ƶ��Ϊ16000��16λ��������ͨ������ȡ��PCM��Ƶ����
        //    reVal = sdk.SDK_SendData(strFileName);
        //    textBox1.Text = reVal.ToString();


        //    m_bSendingData = false;

        //    return true;
        //}
        ////������ɶԽ�
        //private void sendWC()
        //{

        //    SendCustomVoiceData("D:\\�������1.wav");//�ṩ�ļ�·��
        //}
        ////�����Խ�
        //private void sendDJ()
        //{
        //    if (m_lTalkHandle == -1)
        //    {
        //        //��ʼ�Խ�
        //        //���أ��Խ����
        //        m_lTalkHandle = sdk.SDK_StartTalk();
        //        if (m_lTalkHandle >= 0)
        //        {
        //            button2.Text = "stop talk";
        //        }
        //    }
        //    else
        //    {
        //        //�رնԽ�
        //        sdk.SDK_StopTalk();
        //        m_lTalkHandle = -1;
        //        button2.Text = "start talk";
        //    }
        //}
        ////�ر���Ƶ
        //private void stopYP()
        //{
        //    //�ر���Ƶ
        //    //��������Ӧ��Ƶ�������Ƶͨ����Ӧ��һ·��Ƶ
        //    sdk.SDK_CloseSound(lRealHandle);

        //    if (lRealHandle > 0)
        //    {
        //        //�ر���Ƶ
        //        //��������Ƶ���
        //        sdk.SDK_StopRealPlay(lRealHandle);
        //    }
        //    //Ӳ��¼����ǳ�
        //    sdk.SDK_Logout();
        //    //SDK��Դ�ͷ�
        //    sdk.SDK_Cleanup();

        //    m_lLoginID = -1;
        //    m_lTalkHandle = -1;
        //    lRealHandle = -1;

        //}
        ////��Ƶ��ȡ
        //private void pictureJP()
        //{
        //    string strTime =  DateTime.Now.ToString("yyyyMMddhhmmss");
        //    string jldmc = this.txtJLD.Text.Trim();

        //    int i = sdk.SDK_CapturePicture(1, @"d:\\" + jldmc + "" + strTime + "1.jpg");
        //    int i1 = sdk.SDK_CapturePicture(2, @"d:\\" + jldmc + "" + strTime + "2.jpg");
        //}
        ////��Ƶ�ϼ�ʱ��
        //private void andTime()
        //{
        //    int iYear = System.DateTime.Now.Year;
        //    int iMonth = System.DateTime.Now.Month;
        //    int iDay = System.DateTime.Now.Day;
        //    int iHour = System.DateTime.Now.Hour;
        //    int iMinute = System.DateTime.Now.Minute;
        //    int iSecond = System.DateTime.Now.Second;
        //    int a = sdk.SDK_ConfigTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);
        //} 

    }
}
