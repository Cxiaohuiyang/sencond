using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using YGJZJL.PublicComponent;
using CoreFS.CA06;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using SDK_Com;
using YGJZJL.CarSip.Client;
//using SerialCommlib;

namespace YGJZJL.StaticTrack
{
    public partial class TrackWeightForIron : FrmBase
    {
        #region ��������
        //У�ӣ�
        public delegate void CorrentionPicture();//У��ץͼί��
        private CorrentionPicture m_MainThreadCorrentionPicture;//����У��ί�б���

        private string _curPath = System.Environment.CurrentDirectory;
       

        BaseInfo baseinfo = new BaseInfo();
        BaseInfo objBi = null;  //ʹ�ù��ö���

        BaseInfo PicInfo;  //ͼƬ��Ϣ����
        private string correntionWeight = "";
        private string correntionWeightNo = "";
     
        string strGroup ="";//���� Table_CA02_UserOrder.Static_T_CA02_UserOrder.GetUserOrderName(CoreFS.SA06.CoreUserInfo.UserInfo.GetUserGroup()).ToString(); //����
      
       

        //���������Ϣ�̣߳�������Ϣ��+1���棩
        private Thread SaveBaseInfoThread;

        YGJZJL.CarSip.Client.App.CoreApp app = null;
     

        

     

       

        //��һ�μ���
        bool bFirst = false;

     

        //Ƥ�ؼ�����
        string strTareWeightPoint = "";

        //Ƥ�ؼ���Ա
        string strTareWeightPerson = "";

        //Ƥ�ؼ���ʱ��
        string strTareWeightTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //ë�ؼ�����
        string strGrossWeightPoint = "";

        //ë�ؼ���Ա
        string strGrossWeightPerson = "";

        //ë�ؼ���ʱ��
        string strGrossWeightTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        //ë�ؼ������
        string strGrossWeightShift = "";

        //ë�ؼ�������
        string strGrossWeightGroup = "";

        //Ƥ�ؼ������
        string strTareWeightShift = "";

        //Ƥ�ؼ�������
        string strTareWeightGroup = "";


        //������Ϣ����
        GetBaseInfo getbaseinfo = null;
        MoreBaseInfo frm = null;
       
       

        //��ǰ·��
        string m_szRunPath = "";

        //�Ƿ��ֹ�¼��
        bool bSglr = false;

        
       
        //��Ƶ���
        int relhandle1 = 0;
        int relhandle2 = 0;
        int relhandle3 = 0;
        int relhandle4 = 0;
        bool BigChannel = false;
        int m_CurSelBigChannel = -1;
        //��Ƶ���Ƶ�ͨ����
        int intChanel = 0;
        //ͼƬ����
        //private string fileName1;      //ͼƬ1��������
        //private string fileName2;      //ͼƬ2��������

        //��Ƶ���
        int talkID;
        int loghandle;
        bool bYYBB = false;      //��ˮ�ϳ�ʱ����������������
        //�Ƿ�򿪶Խ���0--δ�򿪣�1--�򿪡�
        int isTalk;

        //������
        string strOptNo = "";

        //�Ǳ����Ӵ���
        public SerialCommlibMulti comTs = new SerialCommlibMulti();

      

        public string p_FS_WEIGHTNO = ""; //�����ţ�GUID��
        public string PointID = "";       //���������
        public string PicWeight = "";

        //������Ӧ�̶߳���
        private Thread commThread1;       //���ڼ���߳� K12 ��ͷƺ150t��̬��

   

        public int hComm1;                //�߳�1���Ӿ��
        public int hComm2;                //�߳�2���Ӿ��

       

     

      

       

      

        bool bSave;

        #endregion

        bool ifExistFirstWeight = false;
        bool ifExistWeightPlan = false;



        private int m_nPointCount;//���������
       


        #region �������壨��ִ���ʽ��
        private ProductPoundRoom[] m_PoundRoomArray;//��̬��������������
        private bool m_bRunningForPoundRoom;//�������߳����п���
        private bool m_bPoundRoomThreadClosed;//�������̹߳رտ���
        private string stRunPath = "";//��������·��
        private System.Threading.Thread m_hThreadForPoundRoom;//�������߳̾��
        public delegate void CapPicture();//ץͼί��
        private CapPicture m_MainThreadCapPicture;//����ί�б���
        private int m_iSelectedPound;//ѡ��ļ��������������ڼ������л�ʱRecordClose�ȷ���ʹ��
        public string m_AlarmVoicePath = ""; //�����ļ�·��

        # endregion

        //��ý�������IP�˿�
        private string _videoServerIp = "";
        private string _videoServerPort = "";

        private System.Data.DataTable m_MaterialTable = new System.Data.DataTable();//������Ӧ�����ڴ��;�����а�����Ӧ���������ص��ñ�
        public System.Data.DataTable tempMaterial = new System.Data.DataTable();  //������ʱ�����ڰ���ɸѡ��������ɸѡ

        private System.Data.DataTable m_ReveiverTable = new System.Data.DataTable();//�ջ���
        public System.Data.DataTable tempReveiver = new System.Data.DataTable();

        private System.Data.DataTable m_SenderTable = new System.Data.DataTable();//������
        public System.Data.DataTable tempSender = new System.Data.DataTable();

        private System.Data.DataTable m_ProviderTable = new System.Data.DataTable();//��Ӧ��
        public System.Data.DataTable tempProvider = new System.Data.DataTable();

        private System.Data.DataTable m_TransTable = new System.Data.DataTable();//���˷�
        public System.Data.DataTable tempTrans = new System.Data.DataTable();

        private System.Data.DataTable m_CarNoTable = new System.Data.DataTable();//����
        public System.Data.DataTable tempCarNo = new System.Data.DataTable();

        private System.Data.DataTable m_FlowTable = new System.Data.DataTable();//�����
        public System.Data.DataTable tempFlow = new System.Data.DataTable();

        private System.Data.DataTable m_LoadPointTable = new System.Data.DataTable();//װ����
        public System.Data.DataTable tempLoadPoint = new System.Data.DataTable();

        private System.Data.DataTable m_UnLoadPointTable = new System.Data.DataTable();//ж����
        public System.Data.DataTable tempUnLoadPoint = new System.Data.DataTable();

        private System.Windows.Forms.ListBox m_List = new System.Windows.Forms.ListBox(); //�����б��
        private string m_ListType = "";  //�����б������ 

        #region ���캯��

        /// <summary>
        /// ���캯������ʼ������
        /// </summary>
        public TrackWeightForIron()
        {
            InitializeComponent();
            m_szRunPath = System.Environment.CurrentDirectory;
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        /// <summary>
        /// ��ѯ����������Ϣ
        /// </summary>
        /// 

        private void addSoundFile(string sBfid)
        {           
            if (uDridSound.Rows.Count > 0)
            {
                dataSet1.Tables[2].Clear();
            }

            dataSet1.Tables[2].Rows.Add();
            dataSet1.Tables[2].Rows[0][0] = "�������";
            dataSet1.Tables[2].Rows[0][1] = "";
            dataSet1.Tables[2].Rows[0][2] = "";
            dataSet1.Tables[2].Rows.Add();
            dataSet1.Tables[2].Rows[1][0] = "�����";
            dataSet1.Tables[2].Rows[1][1] = "";
            dataSet1.Tables[2].Rows[1][2] = "";
            dataSet1.Tables[2].Rows.Add();
            dataSet1.Tables[2].Rows[2][0] = "��ǰ��";
            dataSet1.Tables[2].Rows[2][1] = "";
            dataSet1.Tables[2].Rows[2][2] = "";
            uDridSound.Refresh();
        }



        private void BaseOperation()
        {
            //���ϻ�������
            if (this.cbMaterial.Text.Trim().Length > 0)
            {
                if (this.cbMaterial.SelectedValue != null)
                    try
                    {
                        getbaseinfo.SetNonBaseData(PointID, cbMaterial.SelectedValue.ToString().Trim(), "SetWLData");
                    }
                catch(Exception e)
                    {

                }

            }

            //��������������
            if (this.cbSender.Text.Trim().Length > 0)
            {
                if (this.cbSender.SelectedValue != null)

                    getbaseinfo.SetNonBaseData(PointID, this.cbSender.SelectedValue.ToString().Trim(), "SetGYDWData");

            }

            //�ջ�����������
            if (this.cbReceiver.Text.Trim().Length > 0)
            {
                if (this.cbReceiver.SelectedValue != null)

                    getbaseinfo.SetNonBaseData(PointID, this.cbReceiver.SelectedValue.ToString().Trim(), "SetSHDWData");

            }

            //���˷���������
            if (this.cbTrans.Text.Trim().Length > 0)
            {
                if (this.cbTrans.SelectedValue != null)

                    getbaseinfo.SetNonBaseData(PointID, this.cbTrans.SelectedValue.ToString().Trim(), "SetCYDWData");

            }

            ////�����������
            //if (this.cbFlow.Text.Trim().Length > 0)
            //{
            //    if (this.cbFlow.SelectedValue != null)
            //        getbaseinfo.SetNonBaseData(strWeightPoint, this.cbFlow.Text.Trim(), "SetLXData");
            //}


        }

        private bool check()
        {
            if (tb_POTNO.Text.Trim().Length <= 0)
            {
                MessageBox.Show("�����복Ƥ�ţ�");
                tb_POTNO.Focus();
                return false;
            }

            if (tb_POTNO.Text.Trim().Length > 20)
            {
                MessageBox.Show("��Ƥ����Ϣ���ܴ���20λ�������½������룡");
                tb_POTNO.Focus();
                return false;
            }

            if (cbMaterial.SelectedValue == null)
            {
                MessageBox.Show("��ѡ���������ƣ�");
                cbMaterial.Focus();
                return false;
            }

            if (cbSender.SelectedValue == null)
            {
                MessageBox.Show("��ѡ�񷢻���λ��");
                cbSender.Focus();
                return false;
            }

            if (cbReceiver.SelectedValue == null)
            {
                MessageBox.Show("��ѡ���ջ���λ��");
                cbReceiver.Focus();
                return false;
            }

            return true;
        }

        

        private void initCommpent()
        {
            bSglr = false;
            bYYBB = false;
            btnBC.Enabled = false;
            Refresh();
        }

       


        //�洢��������(���ڵ�һ�μ������)
        private bool saveData()  
        {
            string strTmpTable, strTmpField, strTmpValue;
            string strGrossWeightTime = "";
            string strTareWeightTime = "";
            if (Convert.ToDouble(this.txtMeterWeight.Text) > Convert.ToDouble(dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString()))//�Ǳ����ݴ���һ�α��е����ݣ�˵����ǰ�������ذ�
            {
                strGrossWeightTime = objBi.GetServerTime();
                strGrossWeightTime = Convert.ToDateTime(strGrossWeightTime).ToString("yyyy-MM-dd HH:mm:ss");

                strGrossWeightShift = txtBc.Text;
                strGrossWeightGroup = strGroup;

                strTareWeightTime = dsQuery.Tables[0].Rows[0]["FD_WEIGHTTIME"].ToString();

                strTareWeightPoint = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPOINT"].ToString();
                strTareWeightPerson = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPERSON"].ToString();

                strTareWeightShift = dsQuery.Tables[0].Rows[0]["FS_SHIFT"].ToString();
                strTareWeightGroup = dsQuery.Tables[0].Rows[0]["FS_GROUP"].ToString();

                strGrossWeightPoint = PointID;
                strGrossWeightPerson = txtJly.Text;
                PicWeight = txtWeight.Text;
            }
            else//�Ǳ�����С��һ�α��е�������˵����ǰ�������ǿճ�
            {
                strTareWeightTime = objBi.GetServerTime();
                strTareWeightTime = Convert.ToDateTime(strTareWeightTime).ToString("yyyy-MM-dd HH:mm:ss");
                strGrossWeightTime = dsQuery.Tables[0].Rows[0]["FD_WEIGHTTIME"].ToString();

                strTareWeightPoint = PointID;
                strTareWeightPerson = txtJly.Text;
                strTareWeightShift = txtBc.Text;
                strTareWeightGroup = strGroup;

                //strTareWeightTime = objBi.GetServerTime();

                strGrossWeightPoint = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPOINT"].ToString();
                strGrossWeightPerson = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPERSON"].ToString();
                PicWeight = txtTareWeight.Text;
            }

            string strPotno = tb_POTNO.Text.Trim();
            string strFlow = cbFlow.SelectedValue != null ? cbFlow.SelectedValue.ToString() : "";
            string strMaterial = cbMaterial.SelectedValue != null ? cbMaterial.SelectedValue.ToString() : "";
            string strSender = cbSender.SelectedValue != null ? cbSender.SelectedValue.ToString() : "";
            string strReceiver = cbReceiver.SelectedValue != null ? cbReceiver.SelectedValue.ToString() : "";
            string strTrans = cbTrans.SelectedValue != null ? cbTrans.SelectedValue.ToString() : "";
            string strGrossWeight = this.txtWeight.Text;
            string strTareWeight =this.txtTareWeight.Text ;
            string strNetWeight = this.txtNetWeight.Text;

            string strStoveno = this.tb_Stoveno.Text.Trim();
            string strStoveSeatno = this.cb_StoveSeatno.Text.ToString();
            //PicWeight = p_FN_GROSSWEIGHT;
            //string p_FD_ACCOUNTDATE = p_FD_GROSSTIME.Substring(0,10);



            strTmpTable = "DT_STATICTRACKWEIGHT_WEIGHT";
            strTmpField = "FS_WEIGHTNO,FS_MATERIAL,FS_WEIGHTTYPE,FS_SENDERSTORENO,FS_RECEIVERSTORENO,"//1
                        + " FS_POTNO,FN_GROSSWEIGHT,FS_GROSSPERSON,FS_GROSSPOINT,FD_GROSSTIME,"//2
                        + "FN_TAREWEIGHT,FS_TAREPERSON,FS_TAREPOINT,FD_TARETIME,FN_NETWEIGHT,"//3
                        + "FN_YKL,FN_TSPEED,FN_GSPEED,FS_GROSSSHIFT,FS_GROSSGROUP,"//4
                        + "FS_TARESHIFT,FS_TAREGROUP,FS_RECEIVEFLAG,"//5
                        + " FS_RECEIVER,FD_RECEIVETIME,FS_MEMO,FS_TRANS ,FS_STOVENO,FS_STOVESEATNO";//6


            strTmpValue = "'" + p_FS_WEIGHTNO + "','" + strMaterial + "','" + strFlow + "','" + strSender + "','" + strReceiver + "','"//1
                + strPotno + "','" + strGrossWeight + "','" + strGrossWeightPerson + "','" + strGrossWeightPoint + "',to_date('" + strGrossWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'"//2
                + strTareWeight + "','" + strTareWeightPerson + "','" + strTareWeightPoint + "',to_date('" + strTareWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'"+strNetWeight+"','"//3
                + "" + "','" + "" + "','" +""+"','"+ strGrossWeightShift + "','" + strGrossWeightGroup + "','"//4
                + strTareWeightShift+"','"+strTareWeightGroup+"','"+""+"','"//5
                + "" + "','" + "" + "" + "','" + ""+"','"+strTrans+"','"+strStoveno+"','"+strStoveSeatno+"'";//6
            
            CoreClientParam ccpLog = new CoreClientParam();
            ccpLog.ServerName = "ygjzjl.base.QueryData";
            ccpLog.MethodName = "insertDataInfo";

            ccpLog.ServerParams = new object[] { strTmpTable, strTmpField, strTmpValue };

            try
            {
                this.ExecuteNonQuery(ccpLog, CoreInvokeType.Internal);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "���ݱ���ʧ�ܣ�");
                return false;
            }

            if (ccpLog.ReturnCode == 0)
            {
                
                MessageBox.Show("���ݱ���ɹ���");
                BaseOperation();
                DeleteFirstData();//ɾ����Ӧһ������
                app.Dvr.SendWavFile(_curPath + "\\qcsound\\�������.wav");
                setClear();
                return true;
            }
            else
            {
                MessageBox.Show("���ݱ���ʧ�ܣ�");
                return false;
            }
        }

        //�洢��������(���ڵ�һ�μ������)
        private bool saveDataForSglr()
        {
            string strTmpTable, strTmpField, strTmpValue;
            string strGrossWeightTime = "";
            string strTareWeightTime = "";

            strOptNo = Guid.NewGuid().ToString();
            p_FS_WEIGHTNO = strOptNo;
            
                strTareWeightTime = objBi.GetServerTime();
                strTareWeightTime = Convert.ToDateTime(strTareWeightTime).ToString("yyyy-MM-dd HH:mm:ss");
                ;

                strTareWeightPoint = PointID;
                strTareWeightPerson = txtJly.Text;
                strTareWeightShift = txtBc.Text;
                strTareWeightGroup = strGroup;

                //strTareWeightTime = objBi.GetServerTime();

                //strGrossWeightPoint = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPOINT"].ToString();
                //strGrossWeightPerson = dsQuery.Tables[0].Rows[0]["FS_WEIGHTPERSON"].ToString();
                PicWeight = txtTareWeight.Text;


            string strPotno = tb_POTNO.Text.Trim();
            string strFlow = cbFlow.SelectedValue != null ? cbFlow.SelectedValue.ToString() : "";
            string strMaterial = cbMaterial.SelectedValue != null ? cbMaterial.SelectedValue.ToString() : "";
            string strSender = cbSender.SelectedValue != null ? cbSender.SelectedValue.ToString() : "";
            string strReceiver = cbReceiver.SelectedValue != null ? cbReceiver.SelectedValue.ToString() : "";
            string strTrans = cbTrans.SelectedValue != null ? cbTrans.SelectedValue.ToString() : "";
            string strGrossWeight = this.txtWeight.Text;
            string strTareWeight = this.txtTareWeight.Text;
            string strNetWeight = this.txtNetWeight.Text;

            //PicWeight = p_FN_GROSSWEIGHT;
            //string p_FD_ACCOUNTDATE = p_FD_GROSSTIME.Substring(0,10);
            string strStoveno = this.tb_Stoveno.Text.Trim();
            string strStoveSeatno = this.cb_StoveSeatno.Text.ToString();


            strTmpTable = "DT_STATICTRACKWEIGHT_WEIGHT";
            strTmpField = "FS_WEIGHTNO,FS_WEIGHTTYPE,"//1
                        + " FS_POTNO,FN_GROSSWEIGHT,FS_GROSSPERSON,FS_GROSSPOINT,FD_GROSSTIME,"//2
                        + "FN_TAREWEIGHT,FS_TAREPERSON,FS_TAREPOINT,FD_TARETIME,FN_NETWEIGHT,"//3
                        + "FS_GROSSSHIFT,FS_GROSSGROUP,"//4
                        + "FS_TARESHIFT,FS_TAREGROUP,FS_RECEIVEFLAG,"//5
                        + " FS_RECEIVER,FD_RECEIVETIME,FS_MEMO ,FS_STOVENO,FS_STOVESEATNO ";//6


            strTmpValue = "'" + p_FS_WEIGHTNO + "','"  + strFlow +  "','"//1
                + strPotno + "','" + strGrossWeight + "','" + strTareWeightPerson + "','" + strTareWeightPoint + "',to_date('" + strTareWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'"//2
                + strTareWeight + "','" + strTareWeightPerson + "','" + strTareWeightPoint + "',to_date('" + strTareWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'" + strNetWeight + "','"//3
                + strTareWeightShift + "','" + strTareWeightGroup + "','"//4
                + strTareWeightShift + "','" + strTareWeightGroup + "','" + "" + "','"//5
                + "" + "','" + "" + "" + "','" + "" + "','"  + strStoveno + "','" + strStoveSeatno + "'";//6

            CoreClientParam ccpLog = new CoreClientParam();
            ccpLog.ServerName = "ygjzjl.base.QueryData";
            ccpLog.MethodName = "insertDataInfo";

            ccpLog.ServerParams = new object[] { strTmpTable, strTmpField, strTmpValue };

            try
            {
                this.ExecuteNonQuery(ccpLog, CoreInvokeType.Internal);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message + "���ݱ���ʧ�ܣ�");
                return false;
            }

            if (ccpLog.ReturnCode == 0)
            {

                MessageBox.Show("���ݱ���ɹ���");
                BaseOperation();
                DeleteFirstData();//ɾ����Ӧһ������
                app.Dvr.SendWavFile(_curPath + "\\qcsound\\�������.wav");
                setClear();
                return true;
            }
            else
            {
                MessageBox.Show("���ݱ���ʧ�ܣ�");
                return false;
            }
            m_bRunningForPoundRoom = true;//�������ݴ����߳�
        }

        /// <summary>
        /// �洢��Ƥ����Ϣ
        /// </summary>
        /// <param name="sTrainTare">��Ƥ����</param>
        /// <param name="sTrainNo">����</param>
        /// <returns>��-�ɹ�����-ʧ��</returns>
        private bool saveTareInfo(string sTrainTare, string sTrainNo)
        {
            CoreClientParam ccp = new CoreClientParam();

            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryData";

            ccp.ServerParams = new object[] { "BT_IRONTARE", "FS_CH", " AND FS_CH='" + sTrainNo + "'", "" };
            System.Data.DataTable dtTmp = new System.Data.DataTable();
            ccp.SourceDataTable = dtTmp;
            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            }
            catch (Exception)
            {
                return false;
            }

            if (dtTmp.Rows.Count > 0)
            {
                ccp.MethodName = "check_UpdateInfo";
                ccp.ServerParams = new object[] { "BT_IRONTARE", "FF_WEIGHT=" + sTrainTare, "FS_CH='" + sTrainNo + "'" };
                this.ExecuteNonQuery(ccp, CoreInvokeType.Internal);
            }
            else
            {
                ccp.MethodName = "insertDataInfo";
                ccp.ServerParams = new object[] { "BT_IRONTARE", "FS_CH,FF_WEIGHT", "'" + sTrainNo + "'," + sTrainTare };
                this.ExecuteNonQuery(ccp, CoreInvokeType.Internal);
            }

            return true;
        }

        private void setClear()
        {
            tb_POTNO.Text = "";
            tb_POTNO.Focus();
            txtTareWeight.Text = "";
            txtNetWeight.Text = "";
            txtWeight.Text = "";
            
        }

        private void WriteLog(string str)
        {
            //if (System.IO.Directory.Exists(m_szRunPath + "\\log") == false)
            //{
            //    System.IO.Directory.CreateDirectory(m_szRunPath + "\\log");
            //}

            //if (System.IO.Directory.Exists(m_szRunPath + "\\uploaddata") == false)
            //{
            //    System.IO.Directory.CreateDirectory(m_szRunPath + "\\uploaddata");
            //}

            //string strDate = System.DateTime.Now.ToString("yyyyMMdd");
            //System.IO.TextWriter tw = new System.IO.StreamWriter(m_szRunPath + "\\log\\test.log", true);

            //tw.WriteLine(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //tw.WriteLine(str);
            //tw.WriteLine("\r\n");

            //tw.Close();
        }


        //�����ڴ���ʽ
        private void BuildMyTable()
        {
            DataColumn dc;
            //������Ӧ����
            dc = new DataColumn("FS_PointNo".ToUpper()); m_MaterialTable.Columns.Add(dc);
            dc = new DataColumn("FS_MATERIALNO".ToUpper()); m_MaterialTable.Columns.Add(dc);
            dc = new DataColumn("fs_materialname".ToUpper()); m_MaterialTable.Columns.Add(dc);
            dc = new DataColumn("FS_HELPCODE".ToUpper()); m_MaterialTable.Columns.Add(dc);
            dc = new DataColumn("fn_times".ToUpper()); m_MaterialTable.Columns.Add(dc);

            //������Ӧ�ջ���λ��
            dc = new DataColumn("FS_PointNo".ToUpper()); m_ReveiverTable.Columns.Add(dc);
            dc = new DataColumn("FS_Receiver".ToUpper()); m_ReveiverTable.Columns.Add(dc);
            dc = new DataColumn("fs_memo".ToUpper()); m_ReveiverTable.Columns.Add(dc);
            dc = new DataColumn("FS_HELPCODE".ToUpper()); m_ReveiverTable.Columns.Add(dc);
            dc = new DataColumn("fn_times".ToUpper()); m_ReveiverTable.Columns.Add(dc);

            //������Ӧ������λ��
            dc = new DataColumn("FS_PointNo".ToUpper()); m_SenderTable.Columns.Add(dc);
            dc = new DataColumn("FS_SUPPLIER".ToUpper()); m_SenderTable.Columns.Add(dc);
            dc = new DataColumn("FS_SUPPLIERName".ToUpper()); m_SenderTable.Columns.Add(dc);
            dc = new DataColumn("FS_HELPCODE".ToUpper()); m_SenderTable.Columns.Add(dc);
            dc = new DataColumn("fn_times".ToUpper()); m_SenderTable.Columns.Add(dc);

            //������Ӧ��Ӧ��λ��λ��
            dc = new DataColumn("FS_PointNo".ToUpper()); m_ProviderTable.Columns.Add(dc);
            dc = new DataColumn("FS_PROVIDER".ToUpper()); m_ProviderTable.Columns.Add(dc);
            dc = new DataColumn("FS_PROVIDERNAME".ToUpper()); m_ProviderTable.Columns.Add(dc);
            dc = new DataColumn("FS_HELPCODE".ToUpper()); m_ProviderTable.Columns.Add(dc);
            dc = new DataColumn("fn_times".ToUpper()); m_ProviderTable.Columns.Add(dc);

            //������Ӧ���˵�λ��
            dc = new DataColumn("FS_PointNo".ToUpper()); m_TransTable.Columns.Add(dc);
            dc = new DataColumn("FS_TransNo".ToUpper()); m_TransTable.Columns.Add(dc);
            dc = new DataColumn("FS_TRANSNAME".ToUpper()); m_TransTable.Columns.Add(dc);
            dc = new DataColumn("FS_HELPCODE".ToUpper()); m_TransTable.Columns.Add(dc);
            dc = new DataColumn("fn_times".ToUpper()); m_TransTable.Columns.Add(dc);

            //������Ӧ���ű�  FS_POINTNO, FS_CARNO, FN_TIMES
            dc = new DataColumn("FS_POINTNO".ToUpper()); m_CarNoTable.Columns.Add(dc);
            dc = new DataColumn("FS_CARNO".ToUpper()); m_CarNoTable.Columns.Add(dc);
            dc = new DataColumn("FN_TIMES".ToUpper()); m_CarNoTable.Columns.Add(dc);

            //����� FS_TYPECODE, FS_TYPENAME
            dc = new DataColumn("FS_TYPENAME".ToUpper()); m_FlowTable.Columns.Add(dc);
            dc = new DataColumn("FS_FLOW".ToUpper()); m_FlowTable.Columns.Add(dc);
            dc = new DataColumn("FS_POINTNO".ToUpper()); m_FlowTable.Columns.Add(dc);
            dc = new DataColumn("FN_TIMES".ToUpper()); m_FlowTable.Columns.Add(dc);

            // װ���� FS_TYPECODE, FS_TYPENAME
            dc = new DataColumn("FS_LOADPOINTNAME".ToUpper()); this.m_LoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FS_LOAD".ToUpper()); m_LoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FS_POINTNO".ToUpper()); m_LoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FN_TIMES".ToUpper()); m_LoadPointTable.Columns.Add(dc);


            // ж���� FS_TYPECODE, FS_TYPENAME
            dc = new DataColumn("FS_UNLOADPOINTNAME".ToUpper()); this.m_UnLoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FS_UNLOAD".ToUpper()); m_UnLoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FS_POINTNO".ToUpper()); m_UnLoadPointTable.Columns.Add(dc);
            dc = new DataColumn("FN_TIMES".ToUpper()); m_UnLoadPointTable.Columns.Add(dc);
        }

        //���ذ�����Ӧ���ϻ�����Ϣ   

        private void DownLoadMaterial()
        {
            try
            {
                string strSql = "select A.FS_PointNo, A.FS_MATERIALNO, b.fs_materialname, b.FS_HELPCODE, a.fn_times ";
                strSql += " from Bt_Pointmaterial A, It_Material B, Bt_Point C ";
                strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.Fs_Materialno = B.Fs_Wl and C.Fs_Pointtype = 'JG' ";
                strSql += "  order by a.fn_times desc ";

                CoreClientParam ccp = new CoreClientParam();
                ccp.ServerName = "ygjzjl.base.QueryData";//kiscicplat
                ccp.MethodName = "queryByClientSql";
                ccp.ServerParams = new object[] { strSql };
                ccp.SourceDataTable = this.m_MaterialTable;

                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex)
            {
                Console.Write("�����쳣:" + ex.Message + "\n");
                Console.Read();
            }
        }
        //���ذ�����Ӧ�ջ���λ��Ϣ
        private void DownLoadReceiver()
        {
            string strSql = "select A.FS_PointNo, A.FS_Receiver, b.fs_memo, b.FS_HELPCODE, a.fn_times ";
            strSql += " from Bt_PointReceiver A, It_Store B, Bt_Point C ";
            strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_Receiver = B.Fs_SH and C.Fs_Pointtype = 'JG' ";
            strSql += "  order by a.fn_times desc ";


            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_ReveiverTable;
            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        }

        //���ذ�����Ӧ������λ��Ϣ  ,add by zzy
        private void DownLoadSender()
        {
            string strSql = "select A.FS_PointNo, A.FS_SUPPLIER, b.FS_SUPPLIERNAME, b.FS_HELPCODE, a.fn_times ";
            strSql += " from Bt_Pointsupplier A, IT_SUPPLIER B, Bt_Point C ";
            strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_SUPPLIER = B.Fs_GY  and C.Fs_Pointtype = 'JG' ";
            strSql += "  order by a.fn_times desc ";



            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_SenderTable;

            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        }



        //���ذ����Թ�Ӧ��λ��Ϣ  ,add by zzy 
        private void DownLoadProvider()
        {
            string strSql = "select A.FS_PointNo, A.FS_PROVIDER, b.FS_PROVIDERNAME, b.FS_HELPCODE, a.fn_times ";
            strSql += " from BT_POINTPROVIDER A, IT_PROVIDER B, Bt_Point C ";
            strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_PROVIDER = B.FS_SP and C.Fs_Pointtype = 'JG' ";
            strSql += "  order by a.fn_times desc ";


            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_ProviderTable;

            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        }


        //���ذ����Գ��˵�λ��Ϣ  ,add by zzy 
        private void DownLoadTrans()
        {
            string strSql = "select A.FS_PointNo, A.FS_TransNo, b.FS_TRANSNAME, b.FS_HELPCODE, a.fn_times ";
            strSql += " from Bt_PointTrans A, BT_Trans B, Bt_Point C ";
            strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_TransNo = B.Fs_CY and C.Fs_Pointtype = 'JG' ";
            strSql += "  order by a.fn_times desc ";


            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_TransTable;
            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        }



        //���ذ�����Ӧ������Ϣ  ,add by zzy 
        private void DownLoadCarNo()
        {
            string strSql = "select FS_POINTNO, FS_CARNO, FN_TIMES From BT_POINTCARNO order by FN_TIMES desc ";

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_CarNoTable;

            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);


        }

        //����������Ϣ  ,add by zzy 
        private void DownLoadFlow()
        {
            string strSql = "select FS_POINTNO, FS_FLOW ,FN_TIMES,a.fs_typename  From bt_pointflow m left join bt_weighttype a on m.fs_flow = a.fs_typecode order by FN_TIMES ";

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { strSql };
            ccp.SourceDataTable = this.m_FlowTable;
            m_FlowTable.Clear();
            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

        }
        //���ذ�����Ӧװ���������Ϣ   

        //private void DownLoadLoadPoint()
        //{
        //    try
        //    {
        //        string strSql = "select A.FS_PointNo, A.FS_LOAD, b.FS_LOADPOINTNAME, b.FS_HELPCODE, a.fn_times ";
        //        strSql += " from BT_POINTLOAD A, It_LOADPOINT B, Bt_Point C ";
        //        strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_LOAD = B.Fs_ZH and C.Fs_Pointtype = 'QC' ";
        //        strSql += "  order by a.fn_times desc ";

        //        CoreClientParam ccp = new CoreClientParam();
        //        ccp.ServerName = "ygjzjl.base.QueryData";//kiscicplat
        //        ccp.MethodName = "queryByClientSql";
        //        ccp.ServerParams = new object[] { strSql };
        //        ccp.SourceDataTable = this.m_LoadPointTable;

        //        this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write("�����쳣:" + ex.Message + "\n");
        //        Console.Read();
        //    }
        //}
        ////���ذ�����Ӧж���������Ϣ   

        //private void DownLoadUnLoadPoint()
        //{
        //    try
        //    {
        //        string strSql = "select A.FS_PointNo, A.FS_UNLOAD, b.FS_UNLOADPOINTNAME, b.FS_HELPCODE, a.fn_times ";
        //        strSql += " from BT_POINTUNLOAD A, It_UNLOADPOINT B, Bt_Point C ";
        //        strSql += " where A.Fs_pointno = C.Fs_Pointcode and A.FS_UNLOAD = B.Fs_XH and C.Fs_Pointtype = 'QC' ";
        //        strSql += "  order by a.fn_times desc ";

        //        CoreClientParam ccp = new CoreClientParam();
        //        ccp.ServerName = "ygjzjl.base.QueryData";//kiscicplat
        //        ccp.MethodName = "queryByClientSql";
        //        ccp.ServerParams = new object[] { strSql };
        //        ccp.SourceDataTable = this.m_UnLoadPointTable;

        //        this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write("�����쳣:" + ex.Message + "\n");
        //        Console.Read();
        //    }
        //}


        //������ɸѡ������Ϣ
        private void BandPointMaterial(string PointID)
        {
            DataRow[] drs = null;

            tempMaterial = m_MaterialTable.Clone();

            drs = this.m_MaterialTable.Select("FS_PointNo ='" + PointID + "'", "FN_TIMES desc");

            tempMaterial.Clear();
            foreach (DataRow dr in drs)
            {
                tempMaterial.Rows.Add(dr.ItemArray);
            }

            DataRow drz = tempMaterial.NewRow();
            tempMaterial.Rows.InsertAt(drz, 0);
            this.cbMaterial.DataSource = tempMaterial;
            cbMaterial.DisplayMember = "fs_materialname";
            cbMaterial.ValueMember = "FS_MATERIALNO";
        }

        //������ɸѡ�ջ���λ
        private void BandPointReceiver(string PointID)
        {
            DataRow[] drs = null;

            this.tempReveiver = this.m_ReveiverTable.Clone();

            drs = this.m_ReveiverTable.Select("FS_PointNo ='" + PointID + "'", "FN_TIMES desc");

            this.tempReveiver.Clear();
            foreach (DataRow dr in drs)
            {
                this.tempReveiver.Rows.Add(dr.ItemArray);
            }

            DataRow drz = this.tempReveiver.NewRow();
            this.tempReveiver.Rows.InsertAt(drz, 0);
            this.cbReceiver.DataSource = this.tempReveiver;
            this.cbReceiver.DisplayMember = "FS_MEMO";
            this.cbReceiver.ValueMember = "FS_Receiver";
        }

        //������ɸѡ������λ
        private void BandPointSender(string PointID)
        {
            DataRow[] drs = null;

            this.tempSender = this.m_SenderTable.Clone();

            drs = this.m_SenderTable.Select("FS_PointNo ='" + PointID + "'", "FN_TIMES desc");

            this.tempSender.Clear();
            foreach (DataRow dr in drs)
            {
                this.tempSender.Rows.Add(dr.ItemArray);
            }

            DataRow drz = this.tempSender.NewRow();
            this.tempSender.Rows.InsertAt(drz, 0);
            this.cbSender.DataSource = this.tempSender;
            this.cbSender.DisplayMember = "FS_SUPPLIERNAME";
            this.cbSender.ValueMember = "FS_SUPPLIER";
        }




        //������ɸѡ���˵�λ
        private void BandPointTrans(string PointID)
        {
            DataRow[] drs = null;

            this.tempTrans = this.m_TransTable.Clone();

            drs = this.m_TransTable.Select("FS_PointNo ='" + PointID + "'", "FN_TIMES desc");

            this.tempTrans.Clear();
            foreach (DataRow dr in drs)
            {
                this.tempTrans.Rows.Add(dr.ItemArray);
            }

            DataRow drz = this.tempTrans.NewRow();
            this.tempTrans.Rows.InsertAt(drz, 0);
            this.cbTrans.DataSource = this.tempTrans;
            cbTrans.DisplayMember = "FS_TRANSNAME";
            cbTrans.ValueMember = "FS_TRANSNO";

        }



        //������ɸѡ����

        private void BandPointFlow(string PointID)
        {
            DataRow[] drs = null;

            this.tempFlow = this.m_FlowTable.Clone();

            drs = this.m_FlowTable.Select("FS_PointNo ='" + PointID + "'", "FN_TIMES desc");

            this.tempFlow.Clear();
            foreach (DataRow dr in drs)
            {
                this.tempFlow.Rows.Add(dr.ItemArray);
            }

            DataRow drz = this.tempFlow.NewRow();
            this.tempFlow.Rows.InsertAt(drz, 0);
            this.cbFlow.DataSource = this.tempFlow;
            cbFlow.DisplayMember = "fs_typename";
            cbFlow.ValueMember = "fs_flow";
            //cbCH1.ValueMember = "FS_TRANSNO";

        }

        private void InitConfig()
        {
            //����������
            this.panel9.Controls.Add(m_List);
            m_List.Size = new Size(157, 80);
            m_List.Visible = false;
            m_List.ScrollAlwaysVisible = true;
            m_List.BringToFront();
            m_List.Click += new EventHandler(m_List_Click);
            m_List.KeyPress += new KeyPressEventHandler(m_List_KeyPress);
            m_List.Leave += new EventHandler(m_List_Leave);


        }


        private void MoltenInfo_One_Load(object sender, EventArgs e)
        {
            this.BilletInfo_GD_Fill_Panel.Controls.Add(picFDTP);
           
        
            PicInfo = new BaseInfo(this.ob);
            getbaseinfo = new GetBaseInfo(this.ob);
            objBi = new BaseInfo(this.ob);
           
            txtJly.Text = CoreFS.SA06.CoreUserInfo.UserInfo.GetUserName();
          
            txtBc.Text = Table_CA02_UserOrder.Static_T_CA02_UserOrder.GetUserOrderName(CoreFS.SA06.CoreUserInfo.UserInfo.GetUserOrder()).ToString();//���
            strGroup = Table_CA02_UserGroup.Static_T_CA02_UserGroup.GetUserGroupName(CoreFS.SA06.CoreUserInfo.UserInfo.GetUserGroup()); ; //����

            //PointID = "K12";
            stRunPath = System.Environment.CurrentDirectory;
            if (Constant.RunPath == "")
            {

                Constant.RunPath = System.Environment.CurrentDirectory;
            }

      
            QueryJLDData(); //��ѯ��������Ϣ
            OpenPound();//�򿪼�����

            RecordOpen(0);//���Ӽ�����Ӳ��¼���
        
            PointID = m_PoundRoomArray[0].POINTID;
            txtJld.Text = m_PoundRoomArray[0].POINTNAME;
            InitConfig();
            this.BuildMyTable();//�����ڴ���ʽ
            this.DownLoadMaterial(); //���ذ�����Ӧ������Ϣ���ڴ��
            this.DownLoadReceiver();  //���ذ�����Ӧ�ջ���λ��Ϣ���ڴ��
            this.DownLoadSender();  //���ذ�����Ӧ������λ��Ϣ���ڴ��
            this.DownLoadTrans();  //���ذ�����Ӧ���˵�λ��Ϣ���ڴ��
            this.DownLoadCarNo(); //���ذ�����Ӧ������Ϣ���ڴ��
            this.DownLoadFlow();//���ذ�����Ӧ������Ϣ���ڴ��
            //this.DownLoadLoadPoint();//���ذ�����Ӧװ������Ϣ���ڴ��
            //this.DownLoadUnLoadPoint();//���ذ�����Ӧж������Ϣ���ڴ��

            this.BandPointMaterial(PointID); //�󶨰�������
            this.BandPointReceiver(PointID); //�󶨰����ջ���λ
            this.BandPointSender(PointID); //�󶨰���������λ
            this.BandPointTrans(PointID); //�󶨰������˵�λ
            this.BandPointFlow(PointID);//��������Ϣ
            //GetLXData();//��������Ϣ

            this.cb_StoveSeatno.SelectedIndex = 0;
            this.cbFlow.SelectedIndex = 0;

            addSoundFile(PointID);
            queryHistoryDataByDate();
            queryFirstDataByAll();

            try
            {

                BeginPoundRoomThread();//��ִ���ʽ

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
          
           
            btnDS.Enabled = false;
            btnBC.Enabled = false;
            bSglr = false;
           


        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            //�ֶμ��
            if (!CheckInPut())
            { 
                return; 
            }

            if (DialogResult.No == MessageBox.Show("�Ƿ񱣴����ݣ�������ǡ����������������ݣ�������񡱣������������ݣ�", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
              
                if (!ifExistFirstWeight)//���һ�α���û�������
                {
                    if (bSglr && txtWeight.Text != "" && txtTareWeight.Text == "")
                    {
                        bSave=saveDataForSglr("first");
                        bFirst = true;
                    }
                    else if (!bSglr&&txtWeight.Text != "" && txtTareWeight.Text == "")
                    {
                        bSave = saveData("first");//����һ������
                        bFirst = true;
                    }
                    else if (bSglr && txtWeight.Text != "" && txtTareWeight.Text != "")
                    {
                        bSave=saveDataForSglr();
                        bFirst = false;
                    }


                }
                else//���һ�α��������Ӧ�޺ŵ����ݣ����ڶ��α��в�������������¼��ɾ��һ�α��м�¼
                {
                    
                    
                    {
                        bSave = saveData();//�����������
                        bFirst = false;
                    }
                    
                }
           
                queryHistoryDataByDate();
                queryFirstDataByAll();
      

                if (bSave)
                {
                    //�洢ͼƬ��Ϣ
                    m_MainThreadCapPicture = new CapPicture(MainThreadCapPicture);
                    Invoke(m_MainThreadCapPicture); //��ί��ץͼ
                    
                 

                    bSave = false;
                    txtWeight.ReadOnly = true;
                    txtWeight.BackColor = Color.Bisque;
                }

                //m_AlarmVoicePath = Constant.RunPath + "\\sound\\ProductComplete.wav";
                //AutoAlarmVoice();
            initCommpent();
        }

        private void MainThreadCapPicture()
        {

            string strNumber = "KgJtp";

            string FilePath1 = m_szRunPath + "\\Pic\\" + strNumber + "1";
            string FilePath2 = m_szRunPath + "\\Pic\\" + strNumber + "2";
           
            //ץ��һ��ͼ
            try
            {
              app.Dvr.CapturePicture(1, FilePath1 + ".BMP");
                Thread.Sleep(200);
            }
            catch (System.Exception error)
            {
                MessageBox.Show(error.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ץ�ڶ���ͼ
            try
            {
               app.Dvr.CapturePicture(2, FilePath2 + ".BMP");
                Thread.Sleep(200);
            }
            catch (System.Exception error)
            {
                MessageBox.Show(error.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            byte[] TP1 = GetImageFile(FilePath1, 1);
           
            byte[] TP2 = GetImageFile(FilePath2, 2);
           

            if (bFirst)
            {
                this.GraspAndSaveTSImage(TP1, TP2, this.strOptNo);  
            }
            else
            {
                this.UpdateTSTPData(TP1, TP2, this.strOptNo);    
            }
        }

        //add by luobin
        private byte[] GetImageFile(string FilePath, int index)
        {
            byte[] FileContent;

            if (System.IO.File.Exists(FilePath + ".BMP") == true)
            {
                Bitmap img = new Bitmap(FilePath + ".BMP");

                System.Drawing.Image newimage = System.Drawing.Image.FromFile(FilePath + ".BMP");

                //if (index == 1)
                //{
                    Graphics g = Graphics.FromImage(newimage);
                    g.DrawImage(newimage, 0, 0, newimage.Width, newimage.Height);
                    Font f = new Font("����", 28);
                    Brush b = new SolidBrush(Color.Red);

                    g.DrawString(this.PicWeight + " ��", f, b, 100, 20);
                //}

                //ת����JPG   
                newimage.Save(FilePath + ".JPG", System.Drawing.Imaging.ImageFormat.Jpeg);
                img.Dispose();
                newimage.Dispose();
                FileContent = System.IO.File.ReadAllBytes(FilePath + ".JPG");

                return FileContent;
            }

            FileContent = new byte[1];

            return FileContent;
        }


        //����һ�μ�������ͼƬ  add by luobin
        public void GraspAndSaveTSImage(byte[] pic1, byte[] pic2, string strTPID)
        {
            try
            {
                CoreClientParam ccp = new CoreClientParam();
                ccp.ServerName = "ygjzjl.statictrackweight.StaticWeight";
                ccp.MethodName = "SaveTsTpData";
                ccp.ServerParams = new object[] { strTPID, pic1, pic2 };

                this.ExecuteNonQuery(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //������μ�����ˮͼƬ  add by luobin
        public void UpdateTSTPData(byte[] pic1, byte[] pic2, string strTPID)
        {
            try
            {
                CoreClientParam ccp = new CoreClientParam();
                ccp.ServerName = "ygjzjl.statictrackweight.StaticWeight";
                ccp.MethodName = "UpdateTSTPData";
                ccp.ServerParams = new object[] { strTPID, pic1, pic2 };

                this.ExecuteNonQuery(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoltenInfo_One_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Control c = GetNextControl(this.ActiveControl, true);
                bool ok = SelectNextControl(this.ActiveControl, true, true, true, true);
                if (ok && c != null)
                {
                    if (c is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)c).SelectAll();
                    }
                    if (c.TabIndex == 12) return;
                }
            }
        }

        private void txtGh_Leave(object sender, EventArgs e)
        {

        }

        //private void btnDS_Click(object sender, EventArgs e)
        //{
        //    if (txtTRAINNO.Text.Trim().Length <= 0)
        //    {
        //        MessageBox.Show("�����복Ƥ�ţ���дZS��ͷ����");
        //        txtTRAINNO.Focus();
        //        return;
        //    }
        //    btnBC.Enabled = true;
        //    txtWeight.Text = txtMeterWeight.Text;
        //}

        private void btnQL_Click(object sender, EventArgs e)
        {
            if (comTs.hComm != -1)
            {
                comTs.SetZeroCmd();
            }
        }

               

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            if (PointID == "")
            {
                MessageBox.Show("���Ƚ��а����ӹܲ�����");
                return;
            }

            switch (e.Tool.Key.ToString())
            {
                case "find":
                {
                    if (this.dateRQ.Value > this.dtpEnd.Value)
                    {
                        MessageBox.Show("��ʼ���ڱ���С�ڽ�������!");
                        return;
                    }
                    queryHistoryDataByDate();
                    queryFirstDataByAll();
                    break;
                }
                case "Aedio":
                {
                    HandleTalk(0);
                  
                    break;
                }
                case "btCorrention":
                {

                    string strPoint = PointID;
                    string operater = txtJly.Text; //����Ա
                    string shift = txtBc.Text;//���
                    string term = Table_CA02_UserOrder.Static_T_CA02_UserOrder.GetUserOrderName(CoreFS.SA06.CoreUserInfo.UserInfo.GetUserGroup()).ToString(); ;//����
                    correntionWeight = txtMeterWeight.Text.Trim();//����,�ַ���
                    correntionWeightNo = Guid.NewGuid().ToString();
                    if (!baseinfo.correntionInformation(correntionWeightNo, strPoint, operater, shift, term, correntionWeight))
                    {
                        return;
                    }
                    CorrentionSaveImage();
                    MessageBox.Show("У����ɣ�����");
                    break;
                }
            }
        }


        private void uDridSound_ClickCell(object sender, ClickCellEventArgs e)
        {
            if (uDridSound.ActiveRow.Index < 0) return;

            //&&Ҫ�޸�&&
            this.Cursor = Cursors.WaitCursor;

            if (isTalk == 1)
            {
                RecordClose(0);
            
            }

            int waveTimeLen = 2000;
            FileInfo fi;

            switch (uDridSound.ActiveRow.Index)
            {
                case 0:
                    m_PoundRoomArray[0].VideoRecord.SDK_SendData(m_szRunPath + "\\qcsound\\�������.wav");
                    fi = new FileInfo(m_szRunPath + " \\qcsound\\�������.wav");
                    waveTimeLen = Convert.ToInt32((fi.Length - 54) / 16 + 500);
                    break;
                case 1:
                    m_PoundRoomArray[0].VideoRecord.SDK_SendData(m_szRunPath + "\\sound\\�����.wav");
                    fi = new FileInfo(m_szRunPath + " \\sound\\�����.wav");
                    waveTimeLen = Convert.ToInt32((fi.Length - 54) / 16 + 500);
                    break;
                case 2:
                    m_PoundRoomArray[0].VideoRecord.SDK_SendData(m_szRunPath + "\\sound\\��ǰ��.wav");
                    fi = new FileInfo(m_szRunPath + " \\sound\\��ǰ��.wav");
                    waveTimeLen = Convert.ToInt32((fi.Length - 54) / 16 + 500);
                    break;
            }
            
            System.Threading.Thread.Sleep(waveTimeLen);

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// �رմ���ʱ���ر��߳�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoltenInfo_One_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.SaveBaseInfoThread != null)
            {
                if (SaveBaseInfoThread.IsAlive == true || SaveBaseInfoThread.IsAlive == false)
                {
                    this.SaveBaseInfoThread.Abort();
                    this.SaveBaseInfoThread = null;
                }
            }

            if (commThread1 != null)
            {
                if (commThread1.IsAlive)
                {
                    commThread1.Abort();
                    if (!comTs.commThreadAlive1) return;
                    comTs.commThreadAlive1 = false;

                    if (comTs.Close(comTs.hComm1))
                    {
                        comTs.CommCount = 0;
                    }
                }
            }

          
                RecordClose(0);
                
           
        }

        private void cmbLx_Leave(object sender, EventArgs e)
        {
            if (cbFlow.Text.Trim().Length > 20)
            {
                MessageBox.Show("������Ϣ���ܴ���20λ�������½������룡");
                cbFlow.Focus();
                return;
            }
        }

        private void cmbWlmc_Leave(object sender, EventArgs e)
        {
            if (cbMaterial.Text.Length > 100)
            {
                MessageBox.Show("�������Ʋ��ܴ���100λ��50�����֣��������½������룡");
                cbMaterial.Focus();
            }
        }

        private void cmbFhdw_Leave(object sender, EventArgs e)
        {
            if (cbSender.Text.Trim().Length > 100)
            {
                MessageBox.Show("������λ���ܴ���100λ��50�����֣��������½������룡");
                cbSender.Focus();
                return;
            }
        }

        private void cmbShdw_Leave(object sender, EventArgs e)
        {
            if (cbReceiver.Text.Trim().Length > 100)
            {
                MessageBox.Show("�ջ���λ���ܴ���100λ��50�����֣��������½������룡");
                cbReceiver.Focus();
                return;
            }
        }

       
        private void PicUpLoad()
        {
            string addText = PicWeight + " ��";

            if (bFirst)
            {
                PicInfo.GraspAndSaveTSImage(VideoChannel1, VideoChannel2, strOptNo, addText);
                Thread.Sleep(500);
                PicInfo.UpdateTSTPData(VideoChannel1, VideoChannel2, strOptNo, addText);
            }
            else
            {
                PicInfo.UpdateTSTPData(VideoChannel1, VideoChannel2, strOptNo, addText);
            }
        }

        #region ˫����ʾ��ͼ���ٴ�˫���ر�

        private void pic11_Click(object sender, EventArgs e)
        {
            intChanel = 0;

            ((Panel)VideoChannel1.Parent).BorderStyle = BorderStyle.Fixed3D;
            ((Panel)VideoChannel2.Parent).BorderStyle = BorderStyle.None;
            ((Panel)VideoChannel3.Parent).BorderStyle = BorderStyle.None;
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            intChanel = 1;

            ((Panel)VideoChannel1.Parent).BorderStyle = BorderStyle.None;
            ((Panel)VideoChannel2.Parent).BorderStyle = BorderStyle.Fixed3D;
            ((Panel)VideoChannel3.Parent).BorderStyle = BorderStyle.None;
        }

        private void picBf_Click(object sender, EventArgs e)
        {
            intChanel = 2;

            ((Panel)VideoChannel1.Parent).BorderStyle = BorderStyle.None;
            ((Panel)VideoChannel2.Parent).BorderStyle = BorderStyle.None;
            ((Panel)VideoChannel3.Parent).BorderStyle = BorderStyle.Fixed3D;
        }

       

        /// <summary>
        /// �رմ�ͼ���ӣ���ԭСͼ����
        /// </summary>
        private void CloseBigPicture()
        {           

            if (BigChannel  && m_CurSelBigChannel >= 0)
            {
                picFDTP.Visible = false;
                bool a = app.Dvr.StopRealPlay(m_CurSelBigChannel+1);
                BigChannel = false;

                if (m_CurSelBigChannel == 0)
                {
                    app.Dvr.CloseSound();
                    VideoChannel1.Refresh();

                    a=app.Dvr.RealPlay(1,  VideoChannel1.Handle);
                   
                    app.Dvr.OpenSound();
                    app.Dvr.SetVolume(65500);                   
                }
                if (m_CurSelBigChannel ==1)
                {
                    app.Dvr.CloseSound();
                    VideoChannel2.Refresh();

                    app.Dvr.RealPlay(2,  VideoChannel2.Handle);

                    app.Dvr.OpenSound();
                    app.Dvr.SetVolume(65500);         
                }
                if (m_CurSelBigChannel == 2)
                {
                    app.Dvr.CloseSound();
                    VideoChannel3.Refresh();

                    app.Dvr.RealPlay(3,  VideoChannel3.Handle);

                    app.Dvr.OpenSound();
                    app.Dvr.SetVolume(65500);         
                }     
                m_CurSelBigChannel = -1;
                picFDTP.Refresh();
            }
           
            else
            {
                picFDTP.Visible = false;
                picFDTP.Refresh();
            }
            
        }  

        private void picFDTP_DoubleClick(object sender, EventArgs e)
        {
            CloseBigPicture();
        }

        private void pic11_DoubleClick(object sender, EventArgs e)
        {
            CloseBigPicture();
            OpenBigPicture(0);
            VideoChannel1.Refresh();

        }

      

        #endregion

        private void btnSglr_Click(object sender, EventArgs e)
        {
            bSglr = true;
            m_bRunningForPoundRoom = false;
            txtWeight.ReadOnly = false;
            txtWeight.Focus();
            btnBC.Enabled = true;
            txtWeight.BackColor = Color.White;
        }

        private void btnWc_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (isTalk == 1)
            {
                
                m_PoundRoomArray[0].VideoRecord.SDK_StopTalk();
            }
            try
            {
                m_PoundRoomArray[0].VideoRecord.SDK_SendData(m_szRunPath + "\\sound\\������� ��һ��.wav");
                FileInfo fi = new FileInfo(m_szRunPath + " \\sound\\������� ��һ��.wav");
                int waveTimeLen = Convert.ToInt32((fi.Length - 54) / 16 + 500);

                System.Threading.Thread.Sleep(waveTimeLen);

                this.Cursor = Cursors.Default;
            }
            catch (Exception er)
            { 

            }
        }
        /// <summary>
        /// У��ץͼ������
        /// </summary>
        private void CorrentionSaveImage()
        {
            m_MainThreadCorrentionPicture = new CorrentionPicture(MainThreadCorrentionPicture);
            Invoke(m_MainThreadCorrentionPicture); //��ί��ץͼ
        }


        /// <summary>
        /// У�ӽ�ͼ����
        /// </summary>
        private void MainThreadCorrentionPicture()
        {
            //m_GraspImageSign = 1; //���Ϊ1�����´β����ٿ����߳�
            string stRunPath = System.Environment.CurrentDirectory;
            string strNumber = PointID;
            string fileName1 = strNumber + "corrention1.bmp";

         
            //ץ��һ��ͼ
            try
            {
                //m_PoundRoomArray[i].VideoRecord.SDK_CapturePicture(m_PoundRoomArray[i].Channel1, stRunPath + "\\JZPicture\\" + fileName1);
                m_PoundRoomArray[0].VideoRecord.SDK_CapturePicture(m_PoundRoomArray[0].Channel1, stRunPath + "\\JZPicture\\" + fileName1);
                Thread.Sleep(200);
            }
            catch (System.Exception error)
            {
                MessageBox.Show(error.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            baseinfo.GraspAndSaveCorrentionImage(fileName1, correntionWeightNo, correntionWeight);
        }

        private void btnTrainTare_Click(object sender, EventArgs e)
        {
            string strTmpTrainNo, strTmpTrainTare;

            strTmpTrainNo = tb_POTNO.Text.Trim();
            strTmpTrainTare = txtTareWeight.Text.Trim();

            if ((strTmpTrainNo == "") || (strTmpTrainTare == ""))
            {
                MessageBox.Show("�����복Ƥ����������Ϊ�գ�");
                return;
            }

            if(saveTareInfo(strTmpTrainTare, strTmpTrainNo))
                MessageBox.Show("���ŵĳ�Ƥ��������ɹ���");
            else
                MessageBox.Show("���ŵĳ�Ƥ��������ʧ�ܣ�");
        }

        private bool saveData(string first)
        {
           
            string strTmpTable, strTmpField, strTmpValue;
            strOptNo = Guid.NewGuid().ToString();
            p_FS_WEIGHTNO = strOptNo;

            strTareWeightTime = objBi.GetServerTime();
            strTareWeightTime = Convert.ToDateTime(strTareWeightTime).ToString("yyyy-MM-dd HH:mm:ss");
            strTareWeightPoint = PointID;
            strTareWeightPerson = txtJly.Text;
            strTareWeightShift = txtBc.Text;
            strTareWeightGroup = strGroup;
            string strPotno = tb_POTNO.Text.Trim();
            string strFlow = cbFlow.SelectedValue != null ? cbFlow.SelectedValue.ToString() : "";
            //string strMaterial = cbMaterial.SelectedValue != null ? cbMaterial.SelectedValue.ToString() : "";
            //string strSender = cbSender.SelectedValue != null ? cbSender.SelectedValue.ToString() : "";
            //string strReceiver = cbReceiver.SelectedValue != null ? cbReceiver.SelectedValue.ToString() : "";
            //string strTrans = cbTrans.SelectedValue != null ? cbTrans.SelectedValue.ToString() : "";

            string strStoveno = this.tb_Stoveno.Text.Trim();
            string strStoveSeatno = this.cb_StoveSeatno.Text.ToString();
           
            string strWEIGHT = this.txtMeterWeight.Text.Trim();
            PicWeight = strWEIGHT;

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "insertDataInfo";

            strTmpTable = "DT_STATICTRACKFIRSTWEIGHT";
            strTmpField = " FS_WEIGHTNO,FS_POTNO,FS_WEIGHTTYPE,"
                        + " FN_WEIGHT,FS_WEIGHTPERSON,FD_WEIGHTTIME,FS_WEIGHTPOINT,FS_SHIFT,FS_GROUP,FS_STOVENO,FS_STOVESEATNO";
            strTmpValue = "'" + strOptNo + "','" + strPotno + "','" + strFlow
                        + "','" + strWEIGHT + "','" + strTareWeightPerson + "',to_date('" + strTareWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'"
                        + strTareWeightPoint + "','" + strTareWeightShift + "','" + strTareWeightGroup + "','"
                        + strStoveno + "','" + strStoveSeatno + "'";

            ccp.ServerParams = new object[] { strTmpTable, strTmpField, strTmpValue };

            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

            }
            catch (Exception)
            {
            }
            if (ccp.ReturnCode == 0)
            {

                MessageBox.Show("���ݱ���ɹ���");
                BaseOperation();
                setClear();
                app.Dvr.SendWavFile(_curPath + "\\qcsound\\�������.wav");
                return true;
            }
            else
            {
                MessageBox.Show("���ݱ���ʧ�ܣ�");
                return false;
            }


        }

        private bool saveDataForSglr(string first)
        {

            string strTmpTable, strTmpField, strTmpValue;
            strOptNo = Guid.NewGuid().ToString();
            p_FS_WEIGHTNO = strOptNo;

            strTareWeightTime = objBi.GetServerTime();
            strTareWeightTime = Convert.ToDateTime(strTareWeightTime).ToString("yyyy-MM-dd HH:mm:ss");
            strTareWeightPoint = PointID;
            strTareWeightPerson = txtJly.Text;
            strTareWeightShift = txtBc.Text;
            strTareWeightGroup = strGroup;
            string strPotno = tb_POTNO.Text.Trim();
            string strFlow = cbFlow.SelectedValue != null ? cbFlow.SelectedValue.ToString() : "";
            //string strMaterial = cbMaterial.SelectedValue != null ? cbMaterial.SelectedValue.ToString() : "";
            //string strSender = cbSender.SelectedValue != null ? cbSender.SelectedValue.ToString() : "";
            //string strReceiver = cbReceiver.SelectedValue != null ? cbReceiver.SelectedValue.ToString() : "";
            //string strTrans = cbTrans.SelectedValue != null ? cbTrans.SelectedValue.ToString() : "";

            string strStoveno = this.tb_Stoveno.Text.Trim();
            string strStoveSeatno = this.cb_StoveSeatno.Text.ToString();

            string strWEIGHT = txtWeight.Text.Trim();
            PicWeight = strWEIGHT;

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "insertDataInfo";

            strTmpTable = "DT_STATICTRACKFIRSTWEIGHT";
            strTmpField = " FS_WEIGHTNO,FS_POTNO,FS_WEIGHTTYPE,"
                        + " FN_WEIGHT,FS_WEIGHTPERSON,FD_WEIGHTTIME,FS_WEIGHTPOINT,FS_SHIFT,FS_GROUP,FS_STOVENO,FS_STOVESEATNO";
            strTmpValue = "'" + strOptNo + "','" + strPotno + "','" + strFlow
                        + "','" + strWEIGHT + "','" + strTareWeightPerson + "',to_date('" + strTareWeightTime + "','yyyy-MM-dd hh24:mi:ss'),'" 
                        + strTareWeightPoint + "','" + strTareWeightShift + "','" + strTareWeightGroup + "','"
                        + strStoveno + "','" + strStoveSeatno+"'";


            ccp.ServerParams = new object[] { strTmpTable, strTmpField, strTmpValue };

            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

            }
            catch (Exception)
            {
            }
            if (ccp.ReturnCode == 0)
            {

                MessageBox.Show("���ݱ���ɹ���");
                BaseOperation();
                setClear();
                app.Dvr.SendWavFile(_curPath + "\\qcsound\\�������.wav");
                return true;
            }
            else
            {
                MessageBox.Show("���ݱ���ʧ�ܣ�");
                return false;
            }


            m_bRunningForPoundRoom = true;//�������ݴ����߳�
        }

        //���ݹ޺Ų�ѯ��һ�μ���������Ϣ
        private bool queryFirstDataByTrainNo()
        {
            //string sql = " and FS_WEIGHTPOINT='" + PointID + "' and FS_POTNO = '" + txtGh.Text.Trim() + "'";
            string sql = "select t.fs_weightno,t.fs_material, t.fs_weighttype, t.fs_senderstoreno, t.fs_receiverstoreno,t.fs_shift,t.fs_group,"
                         + "  t.fs_trainno, t.fn_weight, t.fs_weightperson,to_char(t.fd_weighttime,'yyyy-MM-dd hh24:mi:ss') as fd_weighttime, t.fs_weightpoint,t.fs_deleteflag,fs_deleteuser, "
                         + " t.fd_deletedate, t.fs_transno,t.FS_STOVENO,t.FS_STOVESEATNO, ma.fs_materialname as fs_materialname,  fh.fs_suppliername as fs_sender,  sh.fs_memo as fs_receiver,"
                         +" lx.fs_typename as fs_typename, jld.fs_pointname as fs_pointname,  cy.fs_transname as fs_trans from dt_statictrackfirstweight t ,"
                         +" it_material  ma,  it_supplier fh,  it_store sh,  bt_weighttype lx,  bt_point jld,  bt_trans cy "
                         + " where t.fs_material = ma.fs_wl(+)  and t.fs_senderstoreno = fh.fs_gy(+) and t.fs_receiverstoreno = sh.fs_sh(+) "
                         + " and t.fs_weighttype = lx.fs_typecode(+)   and t.fs_weightpoint = jld.fs_pointcode(+)  and t.fs_transno = cy.fs_cy(+) "
                         + " and t.FS_POTNO='" + tb_POTNO.Text.Trim() + "' and t.FS_WEIGHTPOINT='K38' and t.fs_deleteflag='0'";
            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { sql };
            dsQuery.Tables[0].Clear();
            ccp.SourceDataTable = dsQuery.Tables[0];

          
            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("�����쳣��" + ex1.Message + "��������ִ�б��������");
                return false;
            }
            if (dsQuery.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToDouble(this.txtMeterWeight.Text) > Convert.ToDouble(dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString()))
                {
                    txtWeight.Text = txtMeterWeight.Text;
                    txtTareWeight.Text = this.dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString();
                    txtNetWeight.Text = (Convert.ToDouble(this.txtWeight.Text) - Convert.ToDouble(txtTareWeight.Text)).ToString();
                    PicWeight = txtWeight.Text;


                    strGrossWeightTime = objBi.GetServerTime();

                }
                else
                {
                    txtTareWeight.Text = txtMeterWeight.Text;
                    txtWeight.Text = dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString();
                    txtNetWeight.Text = (Convert.ToDouble(txtWeight.Text) - Convert.ToDouble(txtTareWeight.Text)).ToString();

                    PicWeight = txtTareWeight.Text;
                }

                p_FS_WEIGHTNO = dsQuery.Tables[0].Rows[0]["FS_WEIGHTNO"].ToString();
                cbFlow.Text = dsQuery.Tables[0].Rows[0]["FS_TYPENAME"].ToString();
                //cbMaterial.Text = dsQuery.Tables[0].Rows[0]["FS_MATERIALNAME"].ToString();
                //cbSender.Text = dsQuery.Tables[0].Rows[0]["FS_SENDER"].ToString();
                //cbReceiver.Text = dsQuery.Tables[0].Rows[0]["FS_RECEIVER"].ToString();
                //cbTrans.Text = dsQuery.Tables[0].Rows[0]["FS_TRANS"].ToString();
                strOptNo = p_FS_WEIGHTNO;

                tb_Stoveno.Text = dsQuery.Tables[0].Rows[0]["FS_STOVENO"].ToString();
                cb_StoveSeatno.Text = dsQuery.Tables[0].Rows[0]["FS_STOVESEATNO"].ToString();
                this.strGrossWeightShift = dsQuery.Tables[0].Rows[0]["fs_shift"].ToString();
                this.strGrossWeightGroup = dsQuery.Tables[0].Rows[0]["fs_group"].ToString();
                return true;//�����һ�������򷵻�true
            }

            else 
            {
                txtWeight.Text = txtMeterWeight.Text;
                txtTareWeight.Text = "";
                txtNetWeight.Text = "";
                return false;//���û��һ�������򷴻�false
            }
        }

        private void queryFirstData()
        {
            string strTmpTable, strTmpField, strTmpWhere, strTmpOrder;

            strTmpTable = "dt_firstironweight M,it_mrp fh,it_store sh";
            strTmpField = "FS_WEIGHTNO,FS_POTNO,FS_PRODUCTNO,FS_ITEMNO,FS_MATERIAL,FS_MATERIALNAME,FS_WEIGHTTYPE,"
                + "FS_SENDERSTROENO,fh.FS_MEMO AS FS_SENDER,sh.fs_memo as FS_RECEIVER,FD_WEIGHTTIME,FS_RECEIVESTORE,FS_STOVENO,FS_STOVESEATNO";

            strTmpWhere = " and m.FS_SENDERSTROENO=fh.FS_FH AND M.FS_RECEIVESTORE=sh.FS_SH and FS_WEIGHTPOINT='" + PointID + "'";
           
            strTmpOrder = "ORDER BY FD_WEIGHTTIME";

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryData";
            ccp.ServerParams = new object[] { strTmpTable, strTmpField, strTmpWhere, strTmpOrder };
            dataSet1.Tables[1].Clear();

            ccp.SourceDataTable = dataSet1.Tables[3];
            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            
        }

        private bool QueryPlan(string strTrainNo)//��ѯԤ��
        {
            this.dataSet2.Tables["��̬�����Ԥ����"].Clear();
            string strTmpTable, strTmpField, strTmpOrder, strTmpWhere;

            CoreClientParam ccp = new CoreClientParam();
            strTmpTable = "DT_STATICTRACKPLAN M,IT_MATERIAL MA,IT_SUPPLIER FH,IT_STORE SH,BT_WEIGHTTYPE LX,BT_POINT JLD,BT_TRANS CY ";
            strTmpField = " FS_WEIGHTNO,FS_MATERIAL,FS_WEIGHTTYPE,FS_SENDERSTROENO,FS_RECEIVESTORENO,"
                        + " FS_TRAINNO,FS_WEIGHTPOINT,FS_DEPARTMENT,FS_USER,TO_CHAR(FD_TIMES,'yyyy-MM-dd hh24:mi:ss') AS FD_TIMES, MA.FS_MATERIALNAME AS FS_MATERIALNAME,FH.FS_SUPPLIERNAME AS FS_SENDER,SH.FS_MEMO AS FS_RECEIVER ,LX.FS_TYPENAME AS FS_WEIGHTTYPE ,JLD.FS_POINTNAME AS FS_WEIGHTPOINT,CY.FS_TRANSNAME AS FS_TRANS ";
            strTmpWhere = " AND M.FS_MATERIAL=MA.FS_WL(+) AND M.FS_SENDERSTROENO=FH.FS_GY(+) AND M.FS_RECEIVESTORENO=SH.FS_SH(+) AND M.FS_WEIGHTTYPE=LX.FS_TYPECODE(+) AND M.FS_WEIGHTPOINT=JLD.FS_POINTCODE(+) AND M.FS_TRANS=CY.FS_CY(+) ";
            if (strTrainNo != "")
            {
                strTmpWhere += " AND FS_TRAINNO like '%" + strTrainNo + "%'";
            }


            strTmpOrder = " order by fd_times desc";

            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryData";
            ccp.ServerParams = new object[] { strTmpTable, strTmpField, strTmpWhere, strTmpOrder };
            ccp.SourceDataTable = this.dataSet2.Tables["��̬�����Ԥ����"];


            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

            }
            catch (Exception)
            {
            }
            if (this.dataSet2.Tables["��̬�����Ԥ����"].Rows.Count > 0)
            {
                cbFlow.Text = this.dataSet2.Tables["��̬�����Ԥ����"].Rows[0]["FS_WEIGHTTYPE"].ToString();
                cbMaterial.Text = this.dataSet2.Tables["��̬�����Ԥ����"].Rows[0]["FS_MATERIALNAME"].ToString();
                cbSender.Text = this.dataSet2.Tables["��̬�����Ԥ����"].Rows[0]["FS_SENDER"].ToString();
                cbReceiver.Text = this.dataSet2.Tables["��̬�����Ԥ����"].Rows[0]["FS_RECEIVER"].ToString();
                cbTrans.Text = this.dataSet2.Tables["��̬�����Ԥ����"].Rows[0]["FS_TRANS"].ToString();
                return true;
            }

            else
            {
                return false;
            }

            
        }


        private bool CheckInPut()//������
        {

            if (this.tb_POTNO.Text == "")
            {
                MessageBox.Show("�޺Ų���Ϊ�գ�");
                this.tb_POTNO.Focus();
                return false;

            }
            if (this.cbFlow.Text == "")
            {
                MessageBox.Show("������Ϊ�գ�");
                this.tb_POTNO.Focus();
                return false;
            }
            if (this.tb_Stoveno.Text == "")
            {
                MessageBox.Show("¯�Ų���Ϊ�գ�");
                this.tb_Stoveno.Focus();
                return false;
            }
            if (this.cb_StoveSeatno.Text == "")
            {
                MessageBox.Show("¯���Ų���Ϊ�գ�");
                this.cb_StoveSeatno.Focus();
                return false;
            }
            if (this.tb_Stoveno.Text.Substring(0, 1) != this.cb_StoveSeatno.Text)
            {
                MessageBox.Show("¯��" + tb_Stoveno.Text+"��¯����"+this.cb_StoveSeatno.Text+"��ƥ�䣬��˶Ժ��ٱ��棡");
                this.tb_Stoveno.Focus();
                return false;
            }

            return true;

        }
      

         //�������ڲ�ѯ��һ�μ���������Ϣ
        private void queryFirstDataByAll()
        {
            string strBeginDateTime = this.dateRQ.Value.ToString("yyyy-MM-dd 00:00:00");
            string strEndDateTime = this.dateRQ.Value.ToString("yyyy-MM-dd 23:59:59");
           
            string sql = "select t.FS_WEIGHTNO,t.FS_MATERIAL, lx.fs_typename as FS_WEIGHTTYPE, t.FS_SENDERSTORENO, t.FS_RECEIVERSTORENO,t.FS_SHIFT,t.FS_GROUP,"
                         + "  t.FS_TRAINNO, to_char(t.fn_weight,'999.000') as FN_WEIGHT, t.FS_WEIGHTPERSON,to_char(t.fd_weighttime,'yyyy-MM-dd hh24:mi:ss') as FD_WEIGHTTIME, t.FS_WEIGHTPOINT,  t.FS_DELETEFLAG,  t.FS_DELETEUSER,"
                         + " to_char(t.fd_deletedate,'yyyy-MM-dd hh24:mi:ss') as FD_DELETEDATE, t.FS_TRANSNO, ma.fs_materialname as FS_MATERIALNAME,  fh.fs_suppliername as FS_SENDER,  sh.fs_memo as FS_RECEIVER,t.fs_potno,t.fs_stoveno,t.fs_stoveseatno, "
                         + " lx.fs_typename as FS_TYPENAME, jld.fs_pointname as FS_POINTNAME,  cy.fs_transname as FS_TRANS from dt_statictrackfirstweight t ,"
                         + " it_material  ma,  it_supplier fh,  it_store sh,  bt_weighttype lx,  bt_point jld,  bt_trans cy "
                         + " where t.fs_material = ma.fs_wl(+) and t.fs_senderstoreno = fh.fs_gy(+)  and t.fs_receiverstoreno = sh.fs_sh(+) "
                         + " and t.fs_weighttype = lx.fs_typecode(+)   and t.fs_weightpoint = jld.fs_pointcode(+)  and t.fs_transno = cy.fs_cy(+) "
                         + " and   t.fs_deleteflag!='1' and t.FS_WEIGHTPOINT='"+PointID+"' order by fd_weighttime desc";
            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { sql };
            dataSet2.Tables["��̬�����һ�μ�������"].Clear();
            ccp.SourceDataTable = this.dataSet2.Tables["��̬�����һ�μ�������"];


            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex1)
            {
               
             
            }
        }

        //�������ڲ�ѯ��ʷ����������Ϣ
        private void queryHistoryDataByDate()
        {
            string strBeginDateTime = this.dateRQ.Value.ToString("yyyy-MM-dd 00:00:00");
            string strEndDateTime = this.dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59");

            string sql = "select t.fs_weightno,t.fs_material, lx.fs_typename as FS_WEIGHTTYPE, t.fs_senderstoreno, t.fs_receiverstoreno,"
                         + "  t.fs_trainno, t.fs_grossperson,to_char(t.fd_grosstime,'yyyy-MM-dd hh24:mi:ss') as fd_grosstime,  "
                         + " t.fs_tareperson,to_char(t.fd_taretime,'yyyy-MM-dd hh24:mi:ss') as fd_taretime,t.fs_grossshift,t.fs_grossgroup,"
                         + " t.fs_tareshift,t.fs_taregroup, to_char(t.fn_grossweight,'999.000') as fn_grossweight, to_char(t.fn_tareweight,'999.000') as fn_tareweight,to_char(t.fn_netweight,'999.000') as fn_netweight, t.fs_memo,"
                         + " t.fs_trans, ma.fs_materialname as fs_materialname,  fh.fs_suppliername as fs_sender,  sh.fs_memo as fs_receiver,t.fs_potno,t.fs_stoveno,t.fs_stoveseatno,"
                         + " lx.fs_typename as fs_typename, a.fs_pointname as fs_grosspoint, b.fs_pointname as fs_tarepoint, cy.fs_transname as fs_trans from DT_STATICTRACKWEIGHT_WEIGHT t ,"
                         + " it_material  ma,  it_supplier fh,  it_store sh,  bt_weighttype lx,  bt_point a,bt_point b,  bt_trans cy "
                         + " where t.fs_material = ma.fs_wl(+) and t.fs_senderstoreno = fh.fs_gy(+) and t.fs_receiverstoreno = sh.fs_sh(+)"
                         + " and t.fs_weighttype = lx.fs_typecode(+)  and t.fs_grosspoint = a.fs_pointcode(+) and t.fs_tarepoint=b.fs_pointcode(+) and t.fs_trans = cy.fs_cy(+)"
                         + " and t.fd_grosstime between to_date('" + strBeginDateTime + "','yyyy-MM-dd hh24:mi:ss') and to_date('" + strEndDateTime + "','yyyy-MM-dd hh24:mi:ss') and t.fs_deleteflag!='1' and t.fs_grosspoint='"+PointID+"' order by fd_grosstime desc";
            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { sql };
            this.dataSet2.Tables["��̬�������μ�������"].Clear();
            ccp.SourceDataTable = this.dataSet2.Tables["��̬�������μ�������"];


            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            }
            catch (Exception ex1)
            {
              

            }
        }

        private void DeleteFirstData()
        {
            string strTmpTable, strTmpWhere;
            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "DeleteData";

            strTmpTable = "DT_STATICTRACKFIRSTWEIGHT";

            strTmpWhere = " FS_WEIGHTNO='" + p_FS_WEIGHTNO + "'";

            ccp.ServerParams = new object[] { strTmpTable, strTmpWhere };

            try
            {
                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

            }
            catch (Exception)
            {
            }
        }


        private void m_List_Click(object sender, EventArgs e)   //˫��ѡ�����������б��е�����
        {
            if (m_List.Text.Trim().Length == 0)
            {
                return;
            }
            switch (m_ListType)
            {
                case "Material":
                    this.cbMaterial.Text = m_List.Items[m_List.SelectedIndex].ToString();
                    this.cbMaterial.Focus();
                    m_List.Visible = false;
                    break;
                case "Reveiver":
                    this.cbReceiver.Text = m_List.Items[m_List.SelectedIndex].ToString();
                    this.cbReceiver.Focus();
                    m_List.Visible = false;
                    break;
                case "Sender":
                    this.cbSender.Text = m_List.Items[m_List.SelectedIndex].ToString();
                    this.cbSender.Focus();
                    m_List.Visible = false;
                    break;

                case "Trans":
                    this.cbTrans.Text = m_List.Items[m_List.SelectedIndex].ToString();
                    this.cbTrans.Focus();
                    m_List.Visible = false;
                    break;

                default:
                    m_List.Visible = false;
                    break;
            }
        }

        private void m_List_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = "";
            switch (m_ListType)
            {
                case "Material":
                    if (e.KeyChar == 13 && m_List.SelectedIndex >= 0)
                    {
                        this.cbMaterial.Text = m_List.Items[m_List.SelectedIndex].ToString();
                        cbMaterial.Focus();
                        m_List.Visible = false;
                    }

                    else if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
                    {
                        m_List.Items.Clear();

                        this.cbMaterial.Focus();
                        text = cbMaterial.Text + e.KeyChar;
                        cbMaterial.Text = text;
                        cbMaterial.SelectionStart = cbMaterial.Text.Length;
                    }
                    break;
                case "Reveiver":
                    if (e.KeyChar == 13 && m_List.SelectedIndex >= 0)
                    {
                        this.cbReceiver.Text = m_List.Items[m_List.SelectedIndex].ToString();
                        cbReceiver.Focus();
                        m_List.Visible = false;
                    }

                    else if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
                    {
                        m_List.Items.Clear();

                        cbReceiver.Focus();
                        text = cbReceiver.Text + e.KeyChar;
                        cbReceiver.Text = text;
                        cbReceiver.SelectionStart = cbReceiver.Text.Length;
                    }
                    break;
                case "Sender":
                    if (e.KeyChar == 13 && m_List.SelectedIndex >= 0)
                    {
                        this.cbSender.Text = m_List.Items[m_List.SelectedIndex].ToString();
                        cbSender.Focus();
                        m_List.Visible = false;
                    }

                    else if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
                    {
                        m_List.Items.Clear();

                        cbSender.Focus();
                        text = cbSender.Text + e.KeyChar;
                        cbSender.Text = text;
                        cbSender.SelectionStart = cbSender.Text.Length;
                    }
                    break;

                case "Trans":
                    if (e.KeyChar == 13 && m_List.SelectedIndex >= 0)
                    {
                        this.cbTrans.Text = m_List.Items[m_List.SelectedIndex].ToString();
                        cbTrans.Focus();
                        m_List.Visible = false;
                    }

                    else if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
                    {
                        m_List.Items.Clear();

                        cbTrans.Focus();
                        text = cbTrans.Text + e.KeyChar;
                        cbTrans.Text = text;
                        cbTrans.SelectionStart = cbTrans.Text.Length;
                    }
                    break;
                default:
                    break;
            }

        }

        void m_List_Leave(object sender, EventArgs e)
        {

        }

        private void btMaterial_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)(sender);
            frm = new MoreBaseInfo(this, Btn.Tag.ToString(), this.ob);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btTrans_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)(sender);
            MoreBaseInfo frm = new MoreBaseInfo(this, Btn.Tag.ToString(), this.ob);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btSender_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)(sender);
            MoreBaseInfo frm = new MoreBaseInfo(this, Btn.Tag.ToString(), this.ob);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btReceiver_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button Btn = (System.Windows.Forms.Button)(sender);
            MoreBaseInfo frm = new MoreBaseInfo(this, Btn.Tag.ToString(), this.ob);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void cbSender_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_List == null)
                {
                    return;
                }

                if (m_List.Focused == false)
                {
                    m_List.Visible = false;
                }
                if (this.cbSender.SelectedValue == null || this.cbSender.SelectedValue.ToString().Trim() == "")
                {
                    if (m_List.Visible == false)
                    {
                        cbSender.Text = "";
                    }
                }
              
            }
            catch (System.Exception exp)
            {

            }
        }

        private void cbTrans_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_List == null)
                {
                    return;
                }

                if (m_List.Focused == false)
                {
                    m_List.Visible = false;
                }
                if (this.cbTrans.SelectedValue == null || this.cbTrans.SelectedValue.ToString().Trim() == "")
                {
                    if (m_List.Visible == false)
                    {
                        cbTrans.Text = "";
                    }
                }
               
            }
            catch (System.Exception exp)
            {

            }
        }

        private void cbMaterial_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_List == null)
                {
                    return;
                }

                if (m_List.Focused == false)
                {
                    m_List.Visible = false;
                }
                if (this.cbMaterial.SelectedValue == null || this.cbMaterial.SelectedValue.ToString().Trim() == "")
                {
                    if (m_List.Visible == false)
                    {
                        cbMaterial.Text = "";
                    }
                }
               
            }
            catch (System.Exception exp)
            {

            }
        }

        private void cbReceiver_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_List == null)
                {
                    return;
                }

                if (m_List.Focused == false)
                {
                    m_List.Visible = false;
                }
                if (this.cbReceiver.SelectedValue == null || this.cbReceiver.SelectedValue.ToString().Trim() == "")
                {
                    if (m_List.Visible == false)
                    {
                        cbReceiver.Text = "";
                    }
                }
               
            }
            catch (System.Exception exp)
            {

            }
        }

        private void ChangeString(ComboBox combox)
        {

            System.Windows.Forms.ComboBox cb = combox;
            for (int i = 0; i < cb.Text.Length; i++)
            {
                int isChange = 0;
                char newChar = FullCodeToHalfCode(cb.Text[i], ref isChange);
                if (isChange == 1)
                {
                    cb.Text = cb.Text.Replace(cb.Text[i], newChar);
                    cb.SelectionStart = i + 1;
                }
            }
            combox.Text = cb.Text;


        }

        /*ȫ���ַ��ӵ�unicode�����65281~65374   
         ����ַ��ӵ�unicode�����33~126   
         ��ֵ65248
         �ո�Ƚ�����,ȫ��Ϊ       12288,���Ϊ       32 
       */
        private char FullCodeToHalfCode(char c, ref int isChange)
        {
            //�õ�c�ı���
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(c.ToString());

            int H = Convert.ToInt32(bytes[1]);
            int L = Convert.ToInt32(bytes[0]);

            //�õ�unicode����
            int value = H * 256 + L;

            //��ȫ��
            if (value >= 65281 && value <= 65374)
            {
                int halfvalue = value - 65248;//65248��ȫ��Ǽ�Ĳ�ֵ��
                byte halfL = Convert.ToByte(halfvalue);

                bytes[0] = halfL;
                bytes[1] = 0;
                isChange = 1;
            }
            else if (value == 12288)
            {
                int halfvalue = 32;
                byte halfL = Convert.ToByte(halfvalue);

                bytes[0] = halfL;
                bytes[1] = 0;
                isChange = 1;
            }
            else
            {
                isChange = 0;
                return c;
            }

            //��bytesת�����ַ�
            string ret = System.Text.Encoding.Unicode.GetString(bytes);

            return Convert.ToChar(ret);
        }
        

        private void cbMaterial_TextChanged(object sender, EventArgs e)
        {
            if (this.cbMaterial.Text.Trim().Length == 0 || this.cbMaterial.Text.Trim() == "System.Data.DataRowView")
            {
                m_List.Hide();
                return;
            }

           
            if (m_List == null || this.cbMaterial.Focused == false)
            {
                return;
            }

            ChangeString(cbMaterial);//ȫ��ת��Ϊ��ǣ�������ѭ��

            for (int i = 0; i < cbMaterial.Text.Length; i++)
            {
                if (Char.IsLower(cbMaterial.Text[i]) == false && Char.IsUpper(cbMaterial.Text[i]) == false)  //�Ƿ���ĸ
                {
                    m_List.Visible = false;
                    return;
                }
            }

            m_ListType = "Material";
            m_List.Location = new System.Drawing.Point(69, 90);

            string text = this.cbMaterial.Text;
            text = text.ToUpper();

            DataRow[] matchRows = null;

            if (tempMaterial.Rows.Count > 0)
            {
                matchRows = this.tempMaterial.Select("FS_HELPCODE LIKE '%" + text + "%'", "FN_TIMES desc");

                m_List.Items.Clear();
                foreach (DataRow dr in matchRows)
                {
                    m_List.Items.Add(dr["FS_MaterialName"].ToString());
                }
                m_List.Visible = true;
            }
        }

        private void cbTrans_TextChanged(object sender, EventArgs e)
        {
            if (this.cbTrans.Text.Trim().Length == 0 || this.cbTrans.Text.Trim() == "System.Data.DataRowView")
            {
                m_List.Hide();
                return;
            }

         
            if (m_List == null || this.cbTrans.Focused == false)
            {
                return;
            }

            ChangeString(cbTrans);//ȫ��ת��Ϊ��ǣ�������ѭ��

            for (int i = 0; i < cbTrans.Text.Length; i++)
            {
                if (Char.IsLower(cbTrans.Text[i]) == false && Char.IsUpper(cbTrans.Text[i]) == false)  //�Ƿ���ĸ
                {
                    m_List.Visible = false;
                    return;
                }
            }

            m_ListType = "Material";
            m_List.Location = new System.Drawing.Point(316, 90);

            string text = this.cbTrans.Text;
            text = text.ToUpper();

            DataRow[] matchRows = null;

            if (this.tempTrans.Rows.Count > 0)
            {
                matchRows = this.tempTrans.Select("FS_HELPCODE LIKE '%" + text + "%'", "FN_TIMES desc");

                m_List.Items.Clear();
                foreach (DataRow dr in matchRows)
                {
                    m_List.Items.Add(dr["FS_TRANSNAME"].ToString());
                }
                m_List.Visible = true;
            }
        }

        private void cbSender_TextChanged(object sender, EventArgs e)
        {
             if (this.cbSender.Text.Trim().Length == 0 || this.cbSender.Text.Trim() == "System.Data.DataRowView")
            {
                m_List.Hide();
                return;
            }

            if (m_List == null || this.cbSender.Focused == false)
            {
                return;
            }

            ChangeString(cbSender);//ȫ��ת��Ϊ��ǣ�������ѭ��

            for (int i = 0; i < cbSender.Text.Length; i++)
            {
                if (Char.IsLower(cbSender.Text[i]) == false && Char.IsUpper(cbSender.Text[i]) == false)  //�Ƿ���ĸ
                {
                    m_List.Visible = false;
                    return;
                }
            }

            m_ListType = "Sender";
            m_List.Location = new System.Drawing.Point(69, 138);

            string text = this.cbSender.Text;
            text = text.ToUpper();

            DataRow[] matchRows = null;

            if (this.tempSender.Rows.Count > 0)
            {
                matchRows = this.tempSender.Select("FS_HELPCODE LIKE '%" + text + "%'", "FN_TIMES desc");

                m_List.Items.Clear();
                foreach (DataRow dr in matchRows)
                {
                    m_List.Items.Add(dr["FS_MEMO"].ToString());
                }
                m_List.Visible = true;
            }
        }

        private void cbReceiver_TextChanged(object sender, EventArgs e)
        {
            if (this.cbReceiver.Text.Trim().Length == 0 || this.cbReceiver.Text.Trim() == "System.Data.DataRowView")
            {
                m_List.Hide();
                return;
            }

           

            if (m_List == null || cbReceiver.Focused == false)
            {
                return;
            }

            ChangeString(cbReceiver);//ȫ��ת��Ϊ��ǣ�������ѭ��

            for (int i = 0; i < cbReceiver.Text.Length; i++)
            {
                if (Char.IsLower(cbReceiver.Text[i]) == false && Char.IsUpper(cbReceiver.Text[i]) == false)  //�Ƿ���ĸ
                {
                    m_List.Visible = false;
                    return;
                }
            }

            m_ListType = "Reveiver";
            m_List.Location = new System.Drawing.Point(318, 140);

            string text = this.cbReceiver.Text;
            text = text.ToUpper();

            DataRow[] matchRows = null;

            matchRows = this.tempReveiver.Select("FS_HELPCODE LIKE '%" + text + "%'", "FN_Times desc");

            m_List.Items.Clear();
            foreach (DataRow dr in matchRows)
            {
                m_List.Items.Add(dr["FS_Memo"].ToString());
            }
            m_List.Visible = true;
        }

        /// <summary>
        /// �����ݿ��ȡ��������(DHS��Ŀʵʩ��Ҫ����Ӧ�޸�,���̶ܹ���K02)
        /// </summary>
        private void GetLXData()//�ͻ��˼Ӳ���������kiscicplat.common.queryByClient
        {

            string sql = " select DISTINCT FS_TYPECODE,FS_TYPENAME,FS_HELPCODE FROM BT_WEIGHTTYPE A  ";
            CoreClientParam ccp = new CoreClientParam();
           
            ccp.ServerName = "ygjzjl.base.QueryData";
            ccp.MethodName = "queryByClientSql";
            ccp.ServerParams = new object[] { sql };
            System.Data.DataTable dtLX = new System.Data.DataTable();
            ccp.SourceDataTable = dtLX;
            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);

            if (dtLX.Rows.Count > 0)
            {
                DataRow dr = dtLX.NewRow();
                dtLX.Rows.InsertAt(dr, 0);

                this.cbFlow.DataSource = dtLX;
                cbFlow.DisplayMember = "FS_TYPENAME";
                cbFlow.ValueMember = "FS_TYPECODE";

                cbFlow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
                cbFlow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            }
            else
            {
                cbFlow.DataSource = dtLX;
            }
        }

        /// <summary>
        /// �������ݿ��ѯBT_POINT�����ʼ��������
        /// </summary>
        /// <param name="dt"></param>
        private void InitPound(DataTable dt)//��ִ���ʽ
        {
            try
            {
                
                //�����������б�������Ϣ�Ӳ�ѯ������� JL_POINTINFO ��ȡ
                m_nPointCount = dt.Rows.Count;
                m_PoundRoomArray = new ProductPoundRoom[m_nPointCount];
                int i = 0;
                for (i = 0; i < m_nPointCount; i++)
                {
                    m_PoundRoomArray[i] = new ProductPoundRoom();
                    m_PoundRoomArray[i].POINTID = dt.Rows[i]["FS_POINTCODE"].ToString().Trim();
                    m_PoundRoomArray[i].POINTNAME = dt.Rows[i]["FS_POINTNAME"].ToString().Trim();
                    m_PoundRoomArray[i].POINTTYPE = dt.Rows[i]["FS_POINTTYPE"].ToString().Trim();

                    m_PoundRoomArray[i].VIEDOIP = dt.Rows[i]["FS_VIEDOIP"].ToString().Trim();
                    m_PoundRoomArray[i].VIEDOPORT = dt.Rows[i]["FS_VIEDOPORT"].ToString().Trim();
                    m_PoundRoomArray[i].VIEDOUSER = dt.Rows[i]["FS_VIEDOUSER"].ToString().Trim();
                    m_PoundRoomArray[i].VIEDOPWD = dt.Rows[i]["FS_VIEDOPWD"].ToString().Trim();

                    m_PoundRoomArray[i].METERTYPE = dt.Rows[i]["FS_METERTYPE"].ToString().Trim();
                    m_PoundRoomArray[i].METERPARA = dt.Rows[i]["FS_METERPARA"].ToString().Trim();
                    m_PoundRoomArray[i].MOXAIP = dt.Rows[i]["FS_MOXAIP"].ToString().Trim();
                    m_PoundRoomArray[i].MOXAPORT = dt.Rows[i]["FS_MOXAPORT"].ToString().Trim();

                    m_PoundRoomArray[i].RTUIP = dt.Rows[i]["FS_RTUIP"].ToString().Trim();
                    m_PoundRoomArray[i].RTUPORT = dt.Rows[i]["FS_RTUPORT"].ToString().Trim();

                    m_PoundRoomArray[i].PRINTERIP = dt.Rows[i]["FS_PRINTERIP"].ToString().Trim();
                    m_PoundRoomArray[i].PRINTERNAME = dt.Rows[i]["FS_PRINTERNAME"].ToString().Trim();
                    m_PoundRoomArray[i].PRINTTYPECODE = dt.Rows[i]["FS_PRINTTYPECODE"].ToString().Trim();
                    m_PoundRoomArray[i].USEDPAPER = Convert.ToInt32(dt.Rows[i]["FN_USEDPRINTPAPER"].ToString().Length > 0 ? dt.Rows[i]["FN_USEDPRINTPAPER"].ToString().Trim() : "0");
                    m_PoundRoomArray[i].TOTALPAPAR = Convert.ToInt32(dt.Rows[i]["TOTALPAPAR"].ToString().Length > 0 ? dt.Rows[i]["TOTALPAPAR"].ToString() : "0");
                    m_PoundRoomArray[i].USEDINK = Convert.ToInt32(dt.Rows[i]["FN_USEDPRINTINK"].ToString().Length > 0 ? dt.Rows[i]["FN_USEDPRINTINK"].ToString().Trim() : "0");
                    m_PoundRoomArray[i].TOTALINK = Convert.ToInt32(dt.Rows[i]["TOTALINK"].ToString().Length > 0 ? dt.Rows[i]["TOTALINK"].ToString() : "0");
                    m_PoundRoomArray[i].STATUS = dt.Rows[i]["FS_STATUS"].ToString();
                    //m_PoundRoomArray[i].ACCEPTTERMINAL = dt.Rows[i]["ACCEPTTERMINAL"].ToString();

                    m_PoundRoomArray[i].LEDPORT = dt.Rows[i]["FS_LEDPORT"].ToString().Trim();
                    m_PoundRoomArray[i].LEDPARA = dt.Rows[i]["FS_LEDIP"].ToString().Trim();
                    m_PoundRoomArray[i].LEDTYPE = dt.Rows[i]["FS_LEDTYPE"].ToString().Trim();

                    m_PoundRoomArray[i].READERPORT = dt.Rows[i]["FS_READERPORT"].ToString().Trim();
                    m_PoundRoomArray[i].READERPARA = dt.Rows[i]["FS_READERPARA"].ToString().Trim();
                    m_PoundRoomArray[i].READERTYPE = dt.Rows[i]["FS_READERTYPE"].ToString().Trim();

                    m_PoundRoomArray[i].DISPLAYPORT = dt.Rows[i]["FS_DISPLAYPORT"].ToString().Trim();
                    m_PoundRoomArray[i].DISPLAYPARA = dt.Rows[i]["FS_DISPLAYPARA"].ToString().Trim();
                    m_PoundRoomArray[i].DISPLAYTYPE = dt.Rows[i]["FS_DISPLAYTYPE"].ToString().Trim();
                    m_PoundRoomArray[i].USEDPAPER = Convert.ToInt32(dt.Rows[i]["FN_USEDPRINTPAPER"].ToString().Trim().Length > 0 ? dt.Rows[i]["FN_USEDPRINTPAPER"].ToString().Trim() : "0");//ʣ��ֽ����

                    m_PoundRoomArray[i].ZEROVALUE = Convert.ToDecimal(dt.Rows[i]["FN_VALUE"].ToString().Length > 0 ? dt.Rows[i]["FN_VALUE"].ToString().Trim() : "0");
                   
                    //�ж��Ƿ�ʹ���Ǳ�
                    m_PoundRoomArray[i].UseMeter = m_PoundRoomArray[i].METERPARA.Length > 0 ? true : false;
                    //�ж��Ƿ�ʹ�ö�����
                    m_PoundRoomArray[i].UseReader = m_PoundRoomArray[i].READERPARA.Length > 0 ? true : false;
                    //�ж��Ƿ�ʹ��LED
                    m_PoundRoomArray[i].UseLED = m_PoundRoomArray[i].LEDPARA.Length > 0 ? true : false;
                    //�ж��Ƿ�ʹ��Һ����
                    m_PoundRoomArray[i].UseDisplay = m_PoundRoomArray[i].DISPLAYPARA.Length > 0 ? true : false;

                    //�ж��Ƿ�ʹ��Rtu
                    m_PoundRoomArray[i].UseRtu = m_PoundRoomArray[i].RTUIP.Length > 0 ? true : false;

                    m_PoundRoomArray[i].Signed = true;
                }

                //m_PoundRoomArray[i].Signed = true;
            }
            catch (Exception exp)
            {
                WriteLog(exp.Message);
            }
        }

        /// <summary>
        /// ֹͣ�������߳�
        /// </summary>
        public void StopPoundRoomThread()//��ִ���ʽ
        {
            m_bRunningForPoundRoom = false;//ֹͣ�������߳�

            //���ȴ�5�룬�ü������߳��Զ��˳�
            for (int nCount = 0; nCount < 50; nCount++)
            {
                if (m_bPoundRoomThreadClosed == true)
                    break;
                System.Threading.Thread.Sleep(100);
            }

            if (m_PoundRoomArray != null && m_PoundRoomArray.Length > 0)
            {
                for (int j = 0; j < m_PoundRoomArray.Length; j++)
                {
                    if (m_PoundRoomArray[j] != null && m_PoundRoomArray[j].Signed)
                    {
                        m_PoundRoomArray[j].StopUse();
                        RecordClose(j);
                        m_PoundRoomArray[j].Signed = false;
                    }
                }
            }
        }

        private void QueryJLDData()//��ִ���ʽ
        {
            try
            {
                string sql = "SELECT 'False' AS XZ,T.FS_STATUS,T.FS_POINTCODE,T.FS_POINTNAME,T.FS_POINTDEPART,T.FS_POINTTYPE,T.FS_VIEDOIP,T.FS_VIEDOPORT,T.FS_VIEDOUSER,T.FS_VIEDOPWD,";
                sql += " T.FS_METERTYPE,T.FS_METERPARA,T.FS_MOXAIP,T.FS_MOXAPORT,T.FS_RTUIP,T.FS_RTUPORT,T.FS_PRINTERIP,T.FS_PRINTERNAME,T.FS_PRINTTYPECODE,T.FN_USEDPRINTPAPER,";
                sql += " T.FN_USEDPRINTINK,T.FS_LEDIP,T.FS_LEDPORT,T.FN_VALUE,T.FS_ALLOWOTHERTARE,T.FS_SIGN,T.FS_DISPLAYPORT,T.FS_DISPLAYPARA,";
                sql += " T.FS_READERPORT,T.FS_READERPARA,T.FS_READERTYPE,T.FS_DISPLAYTYPE,T.FF_CLEARVALUE,A.FN_PAPERNUM TOTALPAPAR,A.FN_INKNUM TOTALINK FROM BT_POINT T ";
                sql += " LEFT OUTER JOIN BT_PRINTTYPE A ON T.FS_PRINTTYPECODE = A.FS_PRINTTYPECODE ";
                //strWhere += " WHERE T.FS_POINTTYPE = 'GC650' ORDER BY T.FS_POINTCODE";
                sql += " WHERE T.FS_POINTTYPE = 'TSJG' ";
              

                CoreClientParam ccp = new CoreClientParam();
                ccp.ServerName = "ygjzjl.base.QueryData";
                ccp.MethodName = "queryByClientSql";
                ccp.ServerParams = new object[] { sql };             
                ccp.SourceDataTable = dataTable1;

                this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
               
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// �򿪼������Ӳ��¼���
        /// </summary>
        /// <param name="iPoundRoom">����������</param>
        private void RecordOpen(int iPoundRoom)
        {
            int i = iPoundRoom;

            if (i < 0 || m_PoundRoomArray == null || m_PoundRoomArray[i] == null )
            {
                return;
            }

            if (m_PoundRoomArray[i].VIEDOIP == null || m_PoundRoomArray[i].VIEDOIP.Trim().Length == 0)//δ�ӹܵļ�����
            {
                return;
            }

           
          
            if (m_PoundRoomArray[i].VideoRecord == null)
            {
              
               app = new YGJZJL.CarSip.Client.App.CoreApp();
              
               app.Dvr = new YGJZJL.CarSip.Client.Meas.HkDvr();
               app.Dvr.SDK_Init();
                app.Dvr.Init(m_PoundRoomArray[i].VIEDOIP+","+
                                                    Convert.ToInt32(m_PoundRoomArray[i].VIEDOPORT)+","
                                                   + m_PoundRoomArray[i].VIEDOUSER+","+
                                                    m_PoundRoomArray[i].VIEDOPWD);
              app.Dvr.Login();

              
            }

            //int VideoHandle = 0;
        
            //if (VideoHandle < 0)
            //{
            //    MessageBox.Show("��¼Ӳ��¼���ʧ�ܣ����飡", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //return;
            //}
            try
            {
                
                app.Dvr.RealPlay(1,VideoChannel1.Handle);

                app.Dvr.RealPlay(2,  VideoChannel2.Handle);

                app.Dvr.RealPlay(3, VideoChannel3.Handle);

                //if (m_PoundRoomArray[i].Channel1 > 0)
                //{
                //    m_PoundRoomArray[i].VideoRecord.SDK_OpenSound(m_PoundRoomArray[i].Channel1);
                //    m_PoundRoomArray[i].VideoRecord.SDK_SetVolume(65500);
                //}
            }
            catch (Exception e2)
            { }
        }

        /// <summary>
        /// �رռ������Ӳ��¼���
        /// </summary>
        /// <param name="iPoundRoom">����������</param>
        private void RecordClose(int iPoundRoom)//��ִ���ʽ
        {
            int i = iPoundRoom;

            if (i < 0 || m_PoundRoomArray == null || m_PoundRoomArray[i] == null)
            {
                return;
            }

            if (m_PoundRoomArray[i].VIEDOIP == null || m_PoundRoomArray[i].VIEDOIP.Trim().Length == 0)//δ�ӹܵļ�����
            {
                return;
            }

            if (m_PoundRoomArray[i].Signed != true)//δ�ӹܵļ�����
            {
                return;
            }


            //�ر������Խ�
            if (m_PoundRoomArray[i].Talk == true && m_PoundRoomArray[i].TalkID > 0)
            {
             
                app.Dvr.StopTalk();
                m_PoundRoomArray[i].TalkID = 0;
                m_PoundRoomArray[i].Talk = false;

                ultraToolbarsManager1.Toolbars[0].Tools["YYDJ"].SharedProps.Caption = "�򿪶Խ�";
            }

          

            //�رյ�1ͨ������
          
              bool a=  app.Dvr.StopRealPlay(1);
                m_PoundRoomArray[i].Channel1 = 0;
                VideoChannel1.Refresh();
            

            //�رյ�2ͨ������

                a = app.Dvr.StopRealPlay(2);
                m_PoundRoomArray[i].Channel2 = 0;
                VideoChannel2.Refresh();
          

            //�رյ�3ͨ������

                a = app.Dvr.StopRealPlay(3);
                m_PoundRoomArray[i].Channel3 = 0;
                VideoChannel3.Refresh();
           

            //m_PoundRoomArray[i].VideoRecord.SDK_Logout(m_PoundRoomArray[i].VideoHandle);
            app.Dvr.Logout();
         
            m_PoundRoomArray[i].VideoRecord = null;

        }


        private void BeginPoundRoomThread()//��ִ���ʽ
        {
          
            try
            {
                m_bRunningForPoundRoom = true;
                m_bPoundRoomThreadClosed = false;
                m_hThreadForPoundRoom = new System.Threading.Thread(new System.Threading.ThreadStart(PoundRoomThread));
                m_hThreadForPoundRoom.Start();
            }
            catch (Exception exp)
            {
                WriteLog(exp.Message);
            }
        }

        /// <summary>
        /// �������ݴ����߳�
        /// </summary>
        private void PoundRoomThread()//��ַ�ʽ
        {
            
              m_PoundRoomArray[0].StartUse();
                
             
            
           
            

            while (m_bRunningForPoundRoom)
            {
                for (int i = 0; i < m_nPointCount; i++)
                {
                    

                    if (m_PoundRoomArray[i].Signed)
                    {
                        
                        //�����Ǳ�����
                        if (m_PoundRoomArray[i].UseMeter)
                        {
                            System.Threading.Thread.Sleep(100);
                            HandleMeterData(i);//�Ǳ����ݴ���
                           
                        }

                       
                       
                    }

                }

               
            }

            m_bPoundRoomThreadClosed = true;//�������̹߳رտ���
        }

     
        /// <summary>
        /// �����Ǳ�ɼ�����
        /// </summary>
        /// <param name="iPoundRoom">��������������0��ʼ</param>
        private void HandleMeterData(int iPoundRoom)//��ִ���ʽ
        {

            int i = iPoundRoom;
            System.Threading.Thread.Sleep(100);
            WriteLog("weight:" + m_PoundRoomArray[i].MeterValue.ToString());
            try
            {
                string strMeterData = m_PoundRoomArray[i].MeterData;
                Decimal decData = m_PoundRoomArray[i].MeterValue;
                
                if (strMeterData != null && strMeterData.Length > 0)
                {
                    if (decData > m_PoundRoomArray[i].ZEROVALUE )//���ڸ�λֵ
                    //if (true)//���ڸ�λֵ
                    {
                        HandleWeightPound(i, decData);
                    }
                    else//�հ�
                    {
                        HandleZeroPound(i, decData);
                    }
                    //this.txtMeterWeight.Text = "888";
                    if (m_PoundRoomArray[i].POINTID == PointID)//��ǰ���ڲ����ļ����㣬ˢ�½���
                    {

                       
                        if (m_PoundRoomArray[i].MeterStabTimes > 15)
                        {
                            this.lblMaterShow.Text = "�ȶ�";
                            this.lblMater.ForeColor = Color.Green;

                          
                            this.txtMeterWeight.Text = decData.ToString();
                            //string strLog ="��ʾ������ "+ decData.ToString();
                            //WriteLog(strLog);
                            if (m_PoundRoomArray[i].Saved == false)//�����ȶ��ˣ��Ƿ��Ѿ�����
                            {
                                if (tb_POTNO.Text == "")
                                {

                                }
                                else
                                {
                                    if (ifExistFirstWeight)
                                    {
                                        try
                                        {
                                            if (Convert.ToDouble(this.txtMeterWeight.Text) > Convert.ToDouble(dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString()))
                                            {
                                                this.txtWeight.Text = this.txtMeterWeight.Text;
                                                this.txtTareWeight.Text = dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString();
                                            }
                                            else
                                            {
                                                this.txtWeight.Text = dsQuery.Tables[0].Rows[0]["FN_WEIGHT"].ToString();
                                                this.txtTareWeight.Text = this.txtMeterWeight.Text;
                                            }

                                            this.txtNetWeight.Text = (Convert.ToDouble(this.txtWeight.Text) - Convert.ToDouble(txtTareWeight.Text)).ToString();
                                        }
                                        catch(Exception ex)
                                        {

                                        }
                                    }
                                    else
                                    {
                                        this.txtWeight.Text = decData.ToString();
                                    }

                                }
                                btnBC.Enabled = true;

                            }
                            else
                            {
                                this.txtWeight.Text = "";
                            }
                        }
                        else 
                        {
                            if (m_PoundRoomArray[i].STATUS == "IDLE")
                            {
                                this.lblMaterShow.Text = "�հ�";
                                this.lblMater.ForeColor = Color.Red;
                                //this.txtMeterWeight.Text = "0.000";
                                this.txtMeterWeight.Text = decData.ToString();
                                //this.txtWeight.Text = "0.000";
                                btnBC.Enabled = false;

                                
                            }
                            else
                            {
                                this.lblMaterShow.Text = "���ȶ�";
                                this.lblMater.ForeColor = Color.Red;
                                this.txtMeterWeight.Text = decData.ToString();
                                btnBC.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
            }
        }
      
    


        /// <summary>
        /// �Ǳ��������ڸ�λֵ����
        /// </summary>
        /// <param name="iPoundRoom">��������������0��ʼ</param>
        private void HandleWeightPound(int iPoundRoom, decimal decData)//��ִ���ʽ
        {
            try
            {
                int i = iPoundRoom;

                if (Math.Abs(m_PoundRoomArray[i].MeterPreData - decData) < (Decimal)0.1)//�ȶ������������ȶ������ο�ֵ�����ݿ⣬��Ҫд��0.1
                {
                    m_PoundRoomArray[i].MeterStabTimes += 1;
                }
                else
                {
                    m_PoundRoomArray[i].MeterStabTimes = 0;
                }
                m_PoundRoomArray[i].MeterPreData = decData;

                if (m_PoundRoomArray[i].STATUS != "USE")
                {
                    m_PoundRoomArray[i].STATUS = "USE";

                   

                }
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
            }
        }

        /// <summary>
        /// �Ǳ�����С�ڸ�λֵ����
        /// </summary>
        /// <param name="iPoundRoom"></param>
        /// <param name="decData"></param>
        private void HandleZeroPound(int iPoundRoom, decimal decData)//��ִ���ʽ
        {
            int i = iPoundRoom;

            //if (m_PoundRoomArray[i].STATUS == "USE")//�³��¼�
            //{

                m_PoundRoomArray[i].Saved = false;
                m_PoundRoomArray[i].STATUS = "IDLE";
            //}

         
            m_PoundRoomArray[i].MeterStabTimes = 0;
        }


        /// <summary>
        /// ��ȡ����������Ϣ���������������ͳһ�������Ҫ�Ѹ��ߺ���������������ֿ���ע���޸��ļ�������
        /// </summary>
        private void GetYYBBData()//��ִ���ʽ
        {
            string strName = "";
            string strType = "RK";

            CoreClientParam ccp = new CoreClientParam();
            ccp.ServerName = "hgjzjl.basedatamanage.BaseTableManger";
            ccp.MethodName = "QueryVoiceTableData";
            ccp.ServerParams = new object[] { strName, strType };
            ccp.SourceDataTable = dataTable2;

            this.ExecuteQueryToDataTable(ccp, CoreInvokeType.Internal);
            Constant.RefreshAndAutoSize(uDridSound);

            if (System.IO.Directory.Exists(Constant.RunPath + "\\rksound\\") == false)
            {
                System.IO.Directory.CreateDirectory(Constant.RunPath + "\\rksound\\");
            }

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                if (System.IO.File.Exists(Constant.RunPath + "\\rksound\\" + dataTable2.Rows[i]["FS_VOICENAME"].ToString().Trim()) == false)
                {
                    System.IO.File.WriteAllBytes(Constant.RunPath + "\\rksound\\" + dataTable2.Rows[i]["FS_VOICENAME"].ToString().Trim(), (byte[])dataTable2.Rows[i]["FS_VOICEFILE"]);
                }
            }
        }

        /// <summary>
        /// �ǵ�ǰ����������������ʾ�߳�
        /// </summary>
        /// <param name="sequence"></param>
        private void FlashGridRow(object sequence)
        {
            int i = (int)sequence;

            while (ultraGrid2.ActiveRow.Index != i && m_bRunningForPoundRoom)
            {
                ultraGrid2.Rows[i].Appearance.BackColor = Color.Red;
                System.Threading.Thread.Sleep(300);
                ultraGrid2.Rows[i].Appearance.BackColor = Color.White;
                System.Threading.Thread.Sleep(300);
            }
            ultraGrid2.Rows[i].Appearance.BackColor = Color.White;
        }

        /// <summary>
        /// ץͼ������
        /// </summary>
        private void GraspAndSaveImage()
        {
            m_MainThreadCapPicture = new CapPicture(MainThreadCapPicture);
            Invoke(m_MainThreadCapPicture); //��ί��ץͼ
        }

        private void OpenPound()//�򿪼�����
        {
            if (dataTable1 != null && dataTable1.Rows != null && dataTable1.Rows.Count > 0)
            {
               
                m_iSelectedPound = 0;
                InitPound(dataTable1);
               
                //MessageBox.Show("���豸���,��ѡ����Ҫ�����ļ����㣡", "��ʾ", MessageBoxButtons.OK);

            }
        }

        /// <summary>
        /// ���������Խ���ť�¼�
        /// </summary>
        private void HandleTalk(int iPoundRoom)
        {
            if (iPoundRoom < 0 || iPoundRoom >= m_nPointCount)
            {
                return;
            }

            int i = iPoundRoom;
            if (m_PoundRoomArray[i].Talk == true)
            //if (m_PoundRoomArray[i].Talk == true && m_PoundRoomArray[i].TalkID > 0)//���ڶԽ����ر�
            {
                app.Dvr.StopTalk();
             
                m_PoundRoomArray[i].TalkID = 0;
                m_PoundRoomArray[i].Talk = false;

                ultraToolbarsManager1.Toolbars[0].Tools["YYDJ"].SharedProps.Caption = "�򿪶Խ�";
            }
            else
            {
                app.Dvr.StartTalk();
                m_PoundRoomArray[i].TalkID = 1;
                app.Dvr.SetVolume(65500);
             
                    m_PoundRoomArray[i].Talk = true;

                    ultraToolbarsManager1.Toolbars[0].Tools["YYDJ"].SharedProps.Caption = "�رնԽ�";
               
            }
        }

        private void OpenBigPicture(int iChannel)//��ַ�ʽ
        {
            int i = m_iSelectedPound;

            if (i < 0 || m_PoundRoomArray == null || m_PoundRoomArray[i] == null)
            {
                return;
            }

            if (m_PoundRoomArray[i].VIEDOIP == null || m_PoundRoomArray[i].VIEDOIP.Trim().Length == 0)//δ�ӹܵļ�����
            {
                return;
            }

            if (m_PoundRoomArray[i].Signed != true)//δ�ӹܵļ�����
            {
                return;
            }

            if (app == null)
            {
                return;
            }

            if (iChannel == 0)
            {
                
                bool  a = app.Dvr.StopRealPlay(1);
               Thread.Sleep(100);
                VideoChannel1.Refresh();
                app.Dvr.CloseSound();

                 

                BigChannel = app.Dvr.RealPlay(1, picFDTP.Handle);

                app.Dvr.OpenSound();
                app.Dvr.SetVolume(65500);

              
            }
            else if (iChannel == 1)
            {

                app.Dvr.StopRealPlay(2);
                VideoChannel2.Refresh();
                app.Dvr.CloseSound();

                m_PoundRoomArray[i].Channel1 = 0;
                BigChannel = app.Dvr.RealPlay(2, picFDTP.Handle);

                app.Dvr.OpenSound(2);
                app.Dvr.SetVolume(65500);

                
            }
            else if (iChannel == 2)
            {
                app.Dvr.StopRealPlay(3);
                VideoChannel3.Refresh();
                app.Dvr.CloseSound();

                BigChannel = app.Dvr.RealPlay(3,  picFDTP.Handle);

                app.Dvr.OpenSound();
                app.Dvr.SetVolume(65500);
            }

            m_CurSelBigChannel = BigChannel  ? iChannel : -1;

            if (BigChannel )
            {
                picFDTP.Width = VideoChannel1.Width * 2;
                picFDTP.Height = VideoChannel1.Height * 2;
                picFDTP.Visible = true;
               

                picFDTP.BringToFront();
                picFDTP.Refresh();
              
            }
        }


        /// <summary>
        /// �߳���������
        /// </summary>
        public void AutoAlarmVoice()
        {
            try
            {
                if (System.IO.File.Exists(m_AlarmVoicePath))
                {
                    if (m_PoundRoomArray[m_iSelectedPound].Talk == true && m_PoundRoomArray[m_iSelectedPound].TalkID > 0)
                    {
                        m_PoundRoomArray[m_iSelectedPound].VideoRecord.SDK_StopRealPlay(m_PoundRoomArray[m_iSelectedPound].VideoHandle);
                        m_PoundRoomArray[m_iSelectedPound].VideoRecord.SDK_StopTalk();
                        m_PoundRoomArray[m_iSelectedPound].TalkID = 0;
                        m_PoundRoomArray[m_iSelectedPound].Talk = false;

                        ultraToolbarsManager1.Toolbars[0].Tools["YYDJ"].SharedProps.Caption = "�����Խ�";
                    }
                }

                FileInfo fi = new FileInfo(m_AlarmVoicePath);
                int waveTimeLen = Convert.ToInt32((fi.Length - 54) / 16 + 500);

                if (m_PoundRoomArray[m_iSelectedPound].AUDIONUM > 0)
                {
                    m_PoundRoomArray[m_iSelectedPound].AUDIONUM = 0;

                    m_PoundRoomArray[m_iSelectedPound].VideoRecord.SDK_SendData(m_AlarmVoicePath);
                    Thread.Sleep(waveTimeLen);

                    m_PoundRoomArray[m_iSelectedPound].AUDIONUM = 1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
     
        private void txtWeight_Leave(object sender, EventArgs e)
        {
           if(bSglr==true&&txtWeight.Text!=""&&txtTareWeight.Text!="")
            {
                txtNetWeight.Text = "";
               double a=0;
            try
            {
                a= (Convert.ToDouble(this.txtWeight.Text) - Convert.ToDouble(txtTareWeight.Text));
            }
            catch(Exception ee)
            {
                MessageBox.Show("��������ȷ����ֵ��");
                return;
                
            }
           if (a < 0)
           {
               MessageBox.Show("ë�ش���Ƥ�أ�����������!");
               return;
           }
           else
           {
               
             txtNetWeight.Text = a.ToString();
               
           }

        }
        }

        private void txtTareWeight_Leave(object sender, EventArgs e)
        {
            if (bSglr == true && txtWeight.Text != "" && txtTareWeight.Text != "")
            {
                txtNetWeight.Text = "";
                double a = 0;
                try
                {
                    a = (Convert.ToDouble(this.txtWeight.Text) - Convert.ToDouble(txtTareWeight.Text));
                }
                catch (Exception ee)
                {
                    MessageBox.Show("��������ȷ����ֵ��");
                    return;

                }
                if (a < 0)
                {
                    MessageBox.Show("ë�ش���Ƥ�أ�����������!");
                    return;
                }
                else
                {
                   
                    txtNetWeight.Text = a.ToString();
                
                }
            }
        }

        private void Refresh()
        {
            this.cbMaterial.SelectedValue="";
            this.cbSender.SelectedValue="";
            this.cbReceiver.SelectedValue="";
            
        }

        private void VideoChannel2_DoubleClick(object sender, EventArgs e)
        {
            CloseBigPicture();
            OpenBigPicture(1);
            VideoChannel2.Refresh();
        }

        private void VideoChannel3_DoubleClick(object sender, EventArgs e)
        {
            CloseBigPicture();
            OpenBigPicture(2);
            VideoChannel3.Refresh();
        }

        #region �϶���Ƶ����
        private bool _mousedown = false;
        private int _moveLeft = 0;
        private int _moveTop = 0;
        private void picFDTP_MouseDown(object sender, MouseEventArgs e)
        {
            _mousedown = true;
            _moveLeft = e.X;
            _moveTop = e.Y;
        }

        private void picFDTP_MouseLeave(object sender, EventArgs e)
        {
            _mousedown = false;
        }

        private void picFDTP_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mousedown)
            {
                picFDTP.Left += e.X - _moveLeft;
                picFDTP.Top += e.Y - _moveTop;
                _moveLeft = e.X;
                _moveTop = e.Y;
            }
        }

        private void picFDTP_MouseUp(object sender, MouseEventArgs e)
        {
            _mousedown = false;
        }
        #endregion

        private void txtTRAINNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString()=="\r")
            {
                if (tb_POTNO.Text.Trim().Length == 0) return;
                if (tb_POTNO.Text.Trim().Length > 20)
                {
                    MessageBox.Show("�޺Ų��ܴ���20λ�������½������룡");
                    tb_POTNO.Focus();
                    return;
                }
                ifExistFirstWeight = queryFirstDataByTrainNo();
                if (!ifExistFirstWeight)
                {
                    ifExistWeightPlan = QueryPlan(tb_POTNO.Text.Trim());
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbTrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbSender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tb_POTNO_Leave(object sender, EventArgs e)
        {
            if (tb_POTNO.Text.Trim().Length == 0) return;
            if (tb_POTNO.Text.Trim().Length > 20)
            {
                MessageBox.Show("�޺Ų��ܴ���20λ�������½������룡");
                tb_POTNO.Focus();
                return;
            }
            
            ifExistFirstWeight = queryFirstDataByTrainNo();
            if (!ifExistFirstWeight)
            {
                ifExistWeightPlan = QueryPlan(tb_POTNO.Text.Trim());
            }
        }

        private void btnDS_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BeginPoundRoomThread();//��ִ���ʽ
        }
    }
}
