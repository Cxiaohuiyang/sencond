﻿namespace YGJZJL.Bar
{
    partial class Weight_BC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            StopPoundRoomThread();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("语音表", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VOICENAME");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_INSTRTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_MEMO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VOICEFILE");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane1 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, new System.Guid("e801a732-ee6c-4e51-a24d-f0583ba849af"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane1 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("b86aa706-8cb5-428a-808d-cbd7078e1944"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("e801a732-ee6c-4e51-a24d-f0583ba849af"), -1);
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("UltraToolbar1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("YYDJ");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool2 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("Container1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CloseLED");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("QueryPlan");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool3 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("剩余纸张数");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool13 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ChangePage");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool5 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("剩余碳带数");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool15 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ChangeTink");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btCorrention");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("YYDJ");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool1 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("Container1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("CloseLED");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("QueryPlan");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool8 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ChangePage");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool10 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ChangeTink");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool4 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("剩余纸张数");
            Infragistics.Win.UltraWinToolbars.ControlContainerTool controlContainerTool6 = new Infragistics.Win.UltraWinToolbars.ControlContainerTool("剩余碳带数");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool9 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btCorrention");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Table1", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_BATCHNO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PRODUCTNO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_ItemNo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_TechCardNo");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_BILLETWEIGHT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_STOVENO");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_GP_TOTALCOUNT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_MATERIALNAME");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SENDER");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_STEELTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_SPEC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RECEIVER");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_LENGTH");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_FLOW");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PLANPERSON");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FD_TIME");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_JJ_WEIGHT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_SINGLENUM");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_SINGLEWEIGHT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_BANDCOUNT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PRINTTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fs_standardcheck");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_STEELTYPECHECK");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_ADDRESSCHECK");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fs_printweighttype");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_TWINSTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_FCLFLAG");
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Infragistics.Win.Appearance appearance35 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance36 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance37 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance38 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance39 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance40 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("计量点基础表", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_POINTCODE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_POINTNAME");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("XZ");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_SIGN");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_METERTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_METERPARA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_MOXAIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_MOXAPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VIEDOIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VIEDOPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VIEDOUSER");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_VIEDOPWD");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_POINTDEPART");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_POINTTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_RTUIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_RTUPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PRINTERIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PRINTERNAME");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_PRINTTYPECODE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_USEDPRINTPAPER");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_USEDPRINTINK");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_LEDIP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_LEDPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FN_VALUE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_ALLOWOTHERTARE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_DISPLAYPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_DISPLAYPARA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_READERPORT");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_READERPARA");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_READERTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_DISPLAYTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FS_LEDTYPE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FF_CLEARVALUE");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTALPAPAR");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TOTALINK");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            this.VoiceC = new System.Windows.Forms.Panel();
            this.ultraGrid5 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn26 = new System.Data.DataColumn();
            this.dataColumn27 = new System.Data.DataColumn();
            this.dataColumn28 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.dataColumn63 = new System.Data.DataColumn();
            this.dataColumn64 = new System.Data.DataColumn();
            this.dataColumn65 = new System.Data.DataColumn();
            this.dataColumn66 = new System.Data.DataColumn();
            this.dataColumn67 = new System.Data.DataColumn();
            this.dataColumn68 = new System.Data.DataColumn();
            this.dataColumn69 = new System.Data.DataColumn();
            this.dataColumn70 = new System.Data.DataColumn();
            this.dataColumn72 = new System.Data.DataColumn();
            this.dataColumn73 = new System.Data.DataColumn();
            this.dataColumn74 = new System.Data.DataColumn();
            this.dataColumn75 = new System.Data.DataColumn();
            this.dataColumn76 = new System.Data.DataColumn();
            this.dataColumn77 = new System.Data.DataColumn();
            this.dataColumn78 = new System.Data.DataColumn();
            this.dataColumn79 = new System.Data.DataColumn();
            this.dataColumn80 = new System.Data.DataColumn();
            this.dataColumn81 = new System.Data.DataColumn();
            this.dataColumn82 = new System.Data.DataColumn();
            this.dataColumn83 = new System.Data.DataColumn();
            this.dataColumn84 = new System.Data.DataColumn();
            this.dataColumn85 = new System.Data.DataColumn();
            this.dataColumn86 = new System.Data.DataColumn();
            this.dataColumn87 = new System.Data.DataColumn();
            this.dataColumn88 = new System.Data.DataColumn();
            this.dataColumn89 = new System.Data.DataColumn();
            this.dataColumn90 = new System.Data.DataColumn();
            this.dataColumn91 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn29 = new System.Data.DataColumn();
            this.dataColumn30 = new System.Data.DataColumn();
            this.dataColumn31 = new System.Data.DataColumn();
            this.dataColumn32 = new System.Data.DataColumn();
            this.ultraDockManager1 = new Infragistics.Win.UltraWinDock.UltraDockManager(this.components);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._Finishing_HotRolledCoilInfoAutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
            this.dockableWindow2 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsedPrintTink = new System.Windows.Forms.TextBox();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.panel1_Fill_Panel = new System.Windows.Forms.Panel();
            this.txtUsedPrintPaper = new System.Windows.Forms.TextBox();
            this._panel1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._panel1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._panel1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.VideoChannel4 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.VideoChannel1 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.VideoChannel2 = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.VideoChannel3 = new System.Windows.Forms.PictureBox();
            this.picFDTP = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtXSZL = new LxControl.LxLedControl();
            this.lxLedControl1 = new LxControl.LxLedControl();
            this.btnWeightException = new System.Windows.Forms.Button();
            this.btnWeightComplete = new System.Windows.Forms.Button();
            this.StatusLight = new YGJZJL.Bar.CoolIndicator();
            this.button16 = new System.Windows.Forms.Button();
            this.cbx_print = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQL = new System.Windows.Forms.Button();
            this.lbWD = new System.Windows.Forms.Label();
            this.lbYS = new System.Windows.Forms.Label();
            this.txtYKL = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDH = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ds_plan = new System.Data.DataSet();
            this.dataTable4 = new System.Data.DataTable();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataColumn22 = new System.Data.DataColumn();
            this.dataColumn23 = new System.Data.DataColumn();
            this.dataColumn24 = new System.Data.DataColumn();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn33 = new System.Data.DataColumn();
            this.dataColumn34 = new System.Data.DataColumn();
            this.dataColumn35 = new System.Data.DataColumn();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn37 = new System.Data.DataColumn();
            this.dataColumn38 = new System.Data.DataColumn();
            this.dataColumn39 = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGrid3 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.dataSet2 = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.ultraGrid2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.textMinWeight = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textMaxWeight = new System.Windows.Forms.TextBox();
            this.txtBZ = new System.Windows.Forms.TextBox();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.tbx_theoryweight = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbx_lasttotalweight = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbx_lastbandcount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbx_lastbatch = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbx_BandCount = new System.Windows.Forms.TextBox();
            this.tb_yubaokunshu = new System.Windows.Forms.Label();
            this.cbx_Standard = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbPrintType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.tbx_hWeight = new System.Windows.Forms.TextBox();
            this.cbx_Hand = new System.Windows.Forms.CheckBox();
            this.tb_bandno_fb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_zzbh_fb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbx_fb = new System.Windows.Forms.CheckBox();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnWL = new System.Windows.Forms.Button();
            this.cbDCCD = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtZS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLXIN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDDH = new System.Windows.Forms.TextBox();
            this.txtDDXMH = new System.Windows.Forms.TextBox();
            this.cbGG = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbGZ = new System.Windows.Forms.ComboBox();
            this.cbFHDW = new System.Windows.Forms.ComboBox();
            this.cbLX = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWLMC = new System.Windows.Forms.ComboBox();
            this.cbSHDW = new System.Windows.Forms.ComboBox();
            this.txtJLY = new System.Windows.Forms.TextBox();
            this.txtZL = new System.Windows.Forms.TextBox();
            this.txtJLD = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZZBH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.windowDockingArea1 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.coolIndicator1 = new YGJZJL.Bar.CoolIndicator();
            this.VoiceC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).BeginInit();
            this._Finishing_HotRolledCoilInfoAutoHideControl.SuspendLayout();
            this.dockableWindow2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel4)).BeginInit();
            this.panel14.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel1)).BeginInit();
            this.panel15.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel2)).BeginInit();
            this.panel16.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFDTP)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXSZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_plan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).BeginInit();
            this.panel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoiceC
            // 
            this.VoiceC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.VoiceC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VoiceC.Controls.Add(this.ultraGrid5);
            this.coreBind.SetDatabasecommand(this.VoiceC, null);
            this.VoiceC.Dock = System.Windows.Forms.DockStyle.Right;
            this.VoiceC.Location = new System.Drawing.Point(0, 28);
            this.VoiceC.Name = "VoiceC";
            this.VoiceC.Size = new System.Drawing.Size(160, 626);
            this.VoiceC.TabIndex = 6;
            this.coreBind.SetVerification(this.VoiceC, null);
            // 
            // ultraGrid5
            // 
            this.coreBind.SetDatabasecommand(this.ultraGrid5, null);
            this.ultraGrid5.DataMember = "语音表";
            this.ultraGrid5.DataSource = this.dataSet1;
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid5.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4});
            this.ultraGrid5.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid5.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid5.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid5.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid5.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.ultraGrid5.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance3.BackColor = System.Drawing.Color.Silver;
            appearance3.BackColor2 = System.Drawing.Color.White;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance3.ForeColor = System.Drawing.Color.Black;
            appearance3.TextHAlignAsString = "Center";
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid5.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.ultraGrid5.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid5.DisplayLayout.Override.RowAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid5.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            this.ultraGrid5.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ultraGrid5.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid5.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.ultraGrid5.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.ultraGrid5.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid5.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid5.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ultraGrid5.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid5.Name = "ultraGrid5";
            this.ultraGrid5.Size = new System.Drawing.Size(156, 622);
            this.ultraGrid5.TabIndex = 0;
            this.coreBind.SetVerification(this.ultraGrid5, null);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn26,
            this.dataColumn27,
            this.dataColumn28,
            this.dataColumn52,
            this.dataColumn63,
            this.dataColumn64,
            this.dataColumn65,
            this.dataColumn66,
            this.dataColumn67,
            this.dataColumn68,
            this.dataColumn69,
            this.dataColumn70,
            this.dataColumn72,
            this.dataColumn73,
            this.dataColumn74,
            this.dataColumn75,
            this.dataColumn76,
            this.dataColumn77,
            this.dataColumn78,
            this.dataColumn79,
            this.dataColumn80,
            this.dataColumn81,
            this.dataColumn82,
            this.dataColumn83,
            this.dataColumn84,
            this.dataColumn85,
            this.dataColumn86,
            this.dataColumn87,
            this.dataColumn88,
            this.dataColumn89,
            this.dataColumn90,
            this.dataColumn91,
            this.dataColumn1,
            this.dataColumn8,
            this.dataColumn9});
            this.dataTable1.TableName = "计量点基础表";
            // 
            // dataColumn26
            // 
            this.dataColumn26.Caption = "计量点编码";
            this.dataColumn26.ColumnName = "FS_POINTCODE";
            // 
            // dataColumn27
            // 
            this.dataColumn27.Caption = "计量点";
            this.dataColumn27.ColumnName = "FS_POINTNAME";
            // 
            // dataColumn28
            // 
            this.dataColumn28.Caption = "接管";
            this.dataColumn28.ColumnName = "XZ";
            // 
            // dataColumn52
            // 
            this.dataColumn52.Caption = "标志";
            this.dataColumn52.ColumnName = "FS_SIGN";
            // 
            // dataColumn63
            // 
            this.dataColumn63.Caption = "仪表类型";
            this.dataColumn63.ColumnName = "FS_METERTYPE";
            // 
            // dataColumn64
            // 
            this.dataColumn64.Caption = "仪表参数";
            this.dataColumn64.ColumnName = "FS_METERPARA";
            // 
            // dataColumn65
            // 
            this.dataColumn65.Caption = "IP";
            this.dataColumn65.ColumnName = "FS_MOXAIP";
            // 
            // dataColumn66
            // 
            this.dataColumn66.Caption = "端口";
            this.dataColumn66.ColumnName = "FS_MOXAPORT";
            // 
            // dataColumn67
            // 
            this.dataColumn67.Caption = "VIEDOIP";
            this.dataColumn67.ColumnName = "FS_VIEDOIP";
            // 
            // dataColumn68
            // 
            this.dataColumn68.Caption = "录像机端口";
            this.dataColumn68.ColumnName = "FS_VIEDOPORT";
            // 
            // dataColumn69
            // 
            this.dataColumn69.Caption = "用户名";
            this.dataColumn69.ColumnName = "FS_VIEDOUSER";
            // 
            // dataColumn70
            // 
            this.dataColumn70.Caption = "密码";
            this.dataColumn70.ColumnName = "FS_VIEDOPWD";
            // 
            // dataColumn72
            // 
            this.dataColumn72.Caption = "FS_POINTDEPART";
            this.dataColumn72.ColumnName = "FS_POINTDEPART";
            // 
            // dataColumn73
            // 
            this.dataColumn73.Caption = "FS_POINTTYPE";
            this.dataColumn73.ColumnName = "FS_POINTTYPE";
            // 
            // dataColumn74
            // 
            this.dataColumn74.Caption = "FS_RTUIP";
            this.dataColumn74.ColumnName = "FS_RTUIP";
            // 
            // dataColumn75
            // 
            this.dataColumn75.Caption = "FS_RTUPORT";
            this.dataColumn75.ColumnName = "FS_RTUPORT";
            // 
            // dataColumn76
            // 
            this.dataColumn76.Caption = "FS_PRINTERIP";
            this.dataColumn76.ColumnName = "FS_PRINTERIP";
            // 
            // dataColumn77
            // 
            this.dataColumn77.Caption = "FS_PRINTERNAME";
            this.dataColumn77.ColumnName = "FS_PRINTERNAME";
            // 
            // dataColumn78
            // 
            this.dataColumn78.Caption = "FS_PRINTTYPECODE";
            this.dataColumn78.ColumnName = "FS_PRINTTYPECODE";
            // 
            // dataColumn79
            // 
            this.dataColumn79.Caption = "FN_USEDPRINTPAPER";
            this.dataColumn79.ColumnName = "FN_USEDPRINTPAPER";
            // 
            // dataColumn80
            // 
            this.dataColumn80.Caption = "FN_USEDPRINTINK";
            this.dataColumn80.ColumnName = "FN_USEDPRINTINK";
            // 
            // dataColumn81
            // 
            this.dataColumn81.Caption = "FS_LEDIP";
            this.dataColumn81.ColumnName = "FS_LEDIP";
            // 
            // dataColumn82
            // 
            this.dataColumn82.Caption = "FS_LEDPORT";
            this.dataColumn82.ColumnName = "FS_LEDPORT";
            // 
            // dataColumn83
            // 
            this.dataColumn83.Caption = "FN_VALUE";
            this.dataColumn83.ColumnName = "FN_VALUE";
            // 
            // dataColumn84
            // 
            this.dataColumn84.Caption = "FS_ALLOWOTHERTARE";
            this.dataColumn84.ColumnName = "FS_ALLOWOTHERTARE";
            // 
            // dataColumn85
            // 
            this.dataColumn85.Caption = "FS_DISPLAYPORT";
            this.dataColumn85.ColumnName = "FS_DISPLAYPORT";
            // 
            // dataColumn86
            // 
            this.dataColumn86.Caption = "FS_DISPLAYPARA";
            this.dataColumn86.ColumnName = "FS_DISPLAYPARA";
            // 
            // dataColumn87
            // 
            this.dataColumn87.Caption = "FS_READERPORT";
            this.dataColumn87.ColumnName = "FS_READERPORT";
            // 
            // dataColumn88
            // 
            this.dataColumn88.Caption = "FS_READERPARA";
            this.dataColumn88.ColumnName = "FS_READERPARA";
            // 
            // dataColumn89
            // 
            this.dataColumn89.Caption = "FS_READERTYPE";
            this.dataColumn89.ColumnName = "FS_READERTYPE";
            // 
            // dataColumn90
            // 
            this.dataColumn90.Caption = "FS_DISPLAYTYPE";
            this.dataColumn90.ColumnName = "FS_DISPLAYTYPE";
            // 
            // dataColumn91
            // 
            this.dataColumn91.Caption = "FS_LEDTYPE";
            this.dataColumn91.ColumnName = "FS_LEDTYPE";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "FF_CLEARVALUE";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "TOTALPAPAR";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "TOTALINK";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn29,
            this.dataColumn30,
            this.dataColumn31,
            this.dataColumn32});
            this.dataTable2.TableName = "语音表";
            // 
            // dataColumn29
            // 
            this.dataColumn29.Caption = "声音名称";
            this.dataColumn29.ColumnName = "FS_VOICENAME";
            // 
            // dataColumn30
            // 
            this.dataColumn30.ColumnName = "FS_INSTRTYPE";
            // 
            // dataColumn31
            // 
            this.dataColumn31.ColumnName = "FS_MEMO";
            // 
            // dataColumn32
            // 
            this.dataColumn32.ColumnName = "FS_VOICEFILE";
            this.dataColumn32.DataType = typeof(byte[]);
            // 
            // ultraDockManager1
            // 
            this.ultraDockManager1.AnimationSpeed = Infragistics.Win.UltraWinDock.AnimationSpeed.StandardSpeedPlus2;
            this.ultraDockManager1.AutoHideDelay = 300;
            this.ultraDockManager1.CaptionStyle = Infragistics.Win.UltraWinDock.CaptionStyle.Office2003;
            dockableControlPane1.Control = this.VoiceC;
            dockableControlPane1.FlyoutSize = new System.Drawing.Size(150, -1);
            dockableControlPane1.OriginalControlBounds = new System.Drawing.Rectangle(698, 0, 156, 666);
            dockableControlPane1.Pinned = false;
            dockableControlPane1.Size = new System.Drawing.Size(100, 100);
            dockableControlPane1.Text = "语音播报";
            dockAreaPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane1});
            dockAreaPane1.Size = new System.Drawing.Size(95, 666);
            this.ultraDockManager1.DockAreas.AddRange(new Infragistics.Win.UltraWinDock.DockAreaPane[] {
            dockAreaPane1});
            this.ultraDockManager1.HostControl = this;
            this.ultraDockManager1.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.Office2003;
            // 
            // _Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft
            // 
            this.coreBind.SetDatabasecommand(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft, null);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Location = new System.Drawing.Point(0, 0);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Name = "_Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft";
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Owner = this.ultraDockManager1;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.Size = new System.Drawing.Size(0, 655);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft.TabIndex = 8;
            this.coreBind.SetVerification(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft, null);
            // 
            // _Finishing_HotRolledCoilInfoUnpinnedTabAreaRight
            // 
            this.coreBind.SetDatabasecommand(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight, null);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Location = new System.Drawing.Point(1007, 0);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Name = "_Finishing_HotRolledCoilInfoUnpinnedTabAreaRight";
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Owner = this.ultraDockManager1;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.Size = new System.Drawing.Size(21, 655);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight.TabIndex = 9;
            this.coreBind.SetVerification(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight, null);
            // 
            // _Finishing_HotRolledCoilInfoUnpinnedTabAreaTop
            // 
            this.coreBind.SetDatabasecommand(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop, null);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Location = new System.Drawing.Point(0, 0);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Name = "_Finishing_HotRolledCoilInfoUnpinnedTabAreaTop";
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Owner = this.ultraDockManager1;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.Size = new System.Drawing.Size(1007, 0);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop.TabIndex = 10;
            this.coreBind.SetVerification(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop, null);
            // 
            // _Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom
            // 
            this.coreBind.SetDatabasecommand(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom, null);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Location = new System.Drawing.Point(0, 655);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Name = "_Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom";
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Owner = this.ultraDockManager1;
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.Size = new System.Drawing.Size(1007, 0);
            this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom.TabIndex = 11;
            this.coreBind.SetVerification(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom, null);
            // 
            // _Finishing_HotRolledCoilInfoAutoHideControl
            // 
            this._Finishing_HotRolledCoilInfoAutoHideControl.Controls.Add(this.dockableWindow2);
            this.coreBind.SetDatabasecommand(this._Finishing_HotRolledCoilInfoAutoHideControl, null);
            this._Finishing_HotRolledCoilInfoAutoHideControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._Finishing_HotRolledCoilInfoAutoHideControl.Location = new System.Drawing.Point(806, 0);
            this._Finishing_HotRolledCoilInfoAutoHideControl.Name = "_Finishing_HotRolledCoilInfoAutoHideControl";
            this._Finishing_HotRolledCoilInfoAutoHideControl.Owner = this.ultraDockManager1;
            this._Finishing_HotRolledCoilInfoAutoHideControl.Size = new System.Drawing.Size(165, 654);
            this._Finishing_HotRolledCoilInfoAutoHideControl.TabIndex = 12;
            this.coreBind.SetVerification(this._Finishing_HotRolledCoilInfoAutoHideControl, null);
            // 
            // dockableWindow2
            // 
            this.dockableWindow2.Controls.Add(this.VoiceC);
            this.coreBind.SetDatabasecommand(this.dockableWindow2, null);
            this.dockableWindow2.Location = new System.Drawing.Point(5, 0);
            this.dockableWindow2.Name = "dockableWindow2";
            this.dockableWindow2.Owner = this.ultraDockManager1;
            this.dockableWindow2.Size = new System.Drawing.Size(150, 654);
            this.dockableWindow2.TabIndex = 608;
            this.coreBind.SetVerification(this.dockableWindow2, null);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUsedPrintTink);
            this.panel1.Controls.Add(this.chkAutoSave);
            this.panel1.Controls.Add(this.panel1_Fill_Panel);
            this.panel1.Controls.Add(this.txtUsedPrintPaper);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Left);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Right);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Top);
            this.panel1.Controls.Add(this._panel1_Toolbars_Dock_Area_Bottom);
            this.coreBind.SetDatabasecommand(this.panel1, null);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 26);
            this.panel1.TabIndex = 15;
            this.coreBind.SetVerification(this.panel1, null);
            // 
            // txtUsedPrintTink
            // 
            this.coreBind.SetDatabasecommand(this.txtUsedPrintTink, null);
            this.txtUsedPrintTink.Location = new System.Drawing.Point(581, 2);
            this.txtUsedPrintTink.Name = "txtUsedPrintTink";
            this.txtUsedPrintTink.ReadOnly = true;
            this.txtUsedPrintTink.Size = new System.Drawing.Size(39, 21);
            this.txtUsedPrintTink.TabIndex = 577;
            this.coreBind.SetVerification(this.txtUsedPrintTink, null);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.chkAutoSave, null);
            this.chkAutoSave.Location = new System.Drawing.Point(78, 5);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(72, 16);
            this.chkAutoSave.TabIndex = 574;
            this.chkAutoSave.Text = "自动保存";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.chkAutoSave, null);
            this.chkAutoSave.CheckStateChanged += new System.EventHandler(this.chkAutoSave_CheckStateChanged);
            // 
            // panel1_Fill_Panel
            // 
            this.panel1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.coreBind.SetDatabasecommand(this.panel1_Fill_Panel, null);
            this.panel1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Fill_Panel.Location = new System.Drawing.Point(0, 28);
            this.panel1_Fill_Panel.Name = "panel1_Fill_Panel";
            this.panel1_Fill_Panel.Size = new System.Drawing.Size(1007, 0);
            this.panel1_Fill_Panel.TabIndex = 0;
            this.coreBind.SetVerification(this.panel1_Fill_Panel, null);
            // 
            // txtUsedPrintPaper
            // 
            this.coreBind.SetDatabasecommand(this.txtUsedPrintPaper, null);
            this.txtUsedPrintPaper.Location = new System.Drawing.Point(422, 3);
            this.txtUsedPrintPaper.Name = "txtUsedPrintPaper";
            this.txtUsedPrintPaper.ReadOnly = true;
            this.txtUsedPrintPaper.Size = new System.Drawing.Size(38, 21);
            this.txtUsedPrintPaper.TabIndex = 576;
            this.coreBind.SetVerification(this.txtUsedPrintPaper, null);
            // 
            // _panel1_Toolbars_Dock_Area_Left
            // 
            this._panel1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.coreBind.SetDatabasecommand(this._panel1_Toolbars_Dock_Area_Left, null);
            this._panel1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._panel1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 28);
            this._panel1_Toolbars_Dock_Area_Left.Name = "_panel1_Toolbars_Dock_Area_Left";
            this._panel1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 0);
            this._panel1_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            this.coreBind.SetVerification(this._panel1_Toolbars_Dock_Area_Left, null);
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this.panel1;
            this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
            this.ultraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2003;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            controlContainerTool2.ControlName = "chkAutoSave";
            controlContainerTool2.InstanceProps.IsFirstInGroup = true;
            buttonTool4.InstanceProps.IsFirstInGroup = true;
            buttonTool6.InstanceProps.IsFirstInGroup = true;
            controlContainerTool3.ControlName = "txtUsedPrintPaper";
            controlContainerTool3.InstanceProps.IsFirstInGroup = true;
            controlContainerTool3.InstanceProps.Width = 109;
            buttonTool13.InstanceProps.IsFirstInGroup = true;
            controlContainerTool5.ControlName = "txtUsedPrintTink";
            controlContainerTool5.InstanceProps.IsFirstInGroup = true;
            controlContainerTool5.InstanceProps.Width = 110;
            buttonTool15.InstanceProps.IsFirstInGroup = true;
            ultraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            controlContainerTool2,
            buttonTool4,
            buttonTool6,
            controlContainerTool3,
            buttonTool13,
            controlContainerTool5,
            buttonTool15,
            buttonTool7});
            ultraToolbar1.Text = "UltraToolbar1";
            this.ultraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1});
            buttonTool2.SharedPropsInternal.Caption = "打开对讲";
            buttonTool2.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            controlContainerTool1.ControlName = "chkAutoSave";
            controlContainerTool1.SharedPropsInternal.Caption = "1";
            buttonTool3.SharedPropsInternal.Caption = "关闭LED显示";
            buttonTool3.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            buttonTool5.SharedPropsInternal.Caption = "查询预报";
            buttonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            buttonTool8.SharedPropsInternal.Caption = "换纸";
            buttonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            buttonTool10.SharedPropsInternal.Caption = "换碳带";
            buttonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            controlContainerTool4.ControlName = "txtUsedPrintPaper";
            controlContainerTool4.SharedPropsInternal.AllowMultipleInstances = true;
            controlContainerTool4.SharedPropsInternal.Caption = "剩余纸张数";
            controlContainerTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            controlContainerTool4.SharedPropsInternal.Width = 109;
            controlContainerTool6.ControlName = "txtUsedPrintTink";
            controlContainerTool6.SharedPropsInternal.AllowMultipleInstances = true;
            controlContainerTool6.SharedPropsInternal.Caption = "剩余碳带数";
            controlContainerTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            controlContainerTool6.SharedPropsInternal.Width = 110;
            buttonTool9.SharedPropsInternal.Caption = "校秤";
            buttonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.TextOnlyAlways;
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2,
            controlContainerTool1,
            buttonTool3,
            buttonTool5,
            buttonTool8,
            buttonTool10,
            controlContainerTool4,
            controlContainerTool6,
            buttonTool9});
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // _panel1_Toolbars_Dock_Area_Right
            // 
            this._panel1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.coreBind.SetDatabasecommand(this._panel1_Toolbars_Dock_Area_Right, null);
            this._panel1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._panel1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1007, 28);
            this._panel1_Toolbars_Dock_Area_Right.Name = "_panel1_Toolbars_Dock_Area_Right";
            this._panel1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 0);
            this._panel1_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            this.coreBind.SetVerification(this._panel1_Toolbars_Dock_Area_Right, null);
            // 
            // _panel1_Toolbars_Dock_Area_Top
            // 
            this._panel1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.coreBind.SetDatabasecommand(this._panel1_Toolbars_Dock_Area_Top, null);
            this._panel1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._panel1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._panel1_Toolbars_Dock_Area_Top.Name = "_panel1_Toolbars_Dock_Area_Top";
            this._panel1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1007, 28);
            this._panel1_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            this.coreBind.SetVerification(this._panel1_Toolbars_Dock_Area_Top, null);
            // 
            // _panel1_Toolbars_Dock_Area_Bottom
            // 
            this._panel1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._panel1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.coreBind.SetDatabasecommand(this._panel1_Toolbars_Dock_Area_Bottom, null);
            this._panel1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._panel1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._panel1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 26);
            this._panel1_Toolbars_Dock_Area_Bottom.Name = "_panel1_Toolbars_Dock_Area_Bottom";
            this._panel1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1007, 0);
            this._panel1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            this.coreBind.SetVerification(this._panel1_Toolbars_Dock_Area_Bottom, null);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.coreBind.SetDatabasecommand(this.panel2, null);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 629);
            this.panel2.TabIndex = 19;
            this.coreBind.SetVerification(this.panel2, null);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 0, 2);
            this.coreBind.SetDatabasecommand(this.tableLayoutPanel1, null);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.16534F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.91415F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 629);
            this.tableLayoutPanel1.TabIndex = 3;
            this.coreBind.SetVerification(this.tableLayoutPanel1, null);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel17);
            this.coreBind.SetDatabasecommand(this.groupBox5, null);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox5.Location = new System.Drawing.Point(3, 468);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 158);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.coreBind.SetVerification(this.groupBox5, null);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.VideoChannel4);
            this.coreBind.SetDatabasecommand(this.panel17, null);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 17);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(276, 138);
            this.panel17.TabIndex = 1;
            this.coreBind.SetVerification(this.panel17, null);
            // 
            // VideoChannel4
            // 
            this.coreBind.SetDatabasecommand(this.VideoChannel4, null);
            this.VideoChannel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoChannel4.Location = new System.Drawing.Point(0, 0);
            this.VideoChannel4.Name = "VideoChannel4";
            this.VideoChannel4.Size = new System.Drawing.Size(276, 138);
            this.VideoChannel4.TabIndex = 0;
            this.VideoChannel4.TabStop = false;
            this.coreBind.SetVerification(this.VideoChannel4, null);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.groupBox3);
            this.coreBind.SetDatabasecommand(this.panel14, null);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(282, 151);
            this.panel14.TabIndex = 0;
            this.coreBind.SetVerification(this.panel14, null);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel11);
            this.coreBind.SetDatabasecommand(this.groupBox3, null);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.coreBind.SetVerification(this.groupBox3, null);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.VideoChannel1);
            this.coreBind.SetDatabasecommand(this.panel11, null);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 17);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(276, 131);
            this.panel11.TabIndex = 1;
            this.coreBind.SetVerification(this.panel11, null);
            // 
            // VideoChannel1
            // 
            this.coreBind.SetDatabasecommand(this.VideoChannel1, null);
            this.VideoChannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoChannel1.ErrorImage = null;
            this.VideoChannel1.InitialImage = null;
            this.VideoChannel1.Location = new System.Drawing.Point(0, 0);
            this.VideoChannel1.Name = "VideoChannel1";
            this.VideoChannel1.Size = new System.Drawing.Size(276, 131);
            this.VideoChannel1.TabIndex = 0;
            this.VideoChannel1.TabStop = false;
            this.coreBind.SetVerification(this.VideoChannel1, null);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.groupBox2);
            this.coreBind.SetDatabasecommand(this.panel15, null);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(3, 160);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(282, 151);
            this.panel15.TabIndex = 1;
            this.coreBind.SetVerification(this.panel15, null);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel10);
            this.coreBind.SetDatabasecommand(this.groupBox2, null);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.coreBind.SetVerification(this.groupBox2, null);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.VideoChannel2);
            this.coreBind.SetDatabasecommand(this.panel10, null);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 17);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(276, 131);
            this.panel10.TabIndex = 0;
            this.coreBind.SetVerification(this.panel10, null);
            // 
            // VideoChannel2
            // 
            this.coreBind.SetDatabasecommand(this.VideoChannel2, null);
            this.VideoChannel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoChannel2.Location = new System.Drawing.Point(0, 0);
            this.VideoChannel2.Name = "VideoChannel2";
            this.VideoChannel2.Size = new System.Drawing.Size(276, 131);
            this.VideoChannel2.TabIndex = 0;
            this.VideoChannel2.TabStop = false;
            this.coreBind.SetVerification(this.VideoChannel2, null);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.groupBox1);
            this.coreBind.SetDatabasecommand(this.panel16, null);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 317);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(282, 145);
            this.panel16.TabIndex = 2;
            this.coreBind.SetVerification(this.panel16, null);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.coreBind.SetDatabasecommand(this.groupBox1, null);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.coreBind.SetVerification(this.groupBox1, null);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.VideoChannel3);
            this.coreBind.SetDatabasecommand(this.panel8, null);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 17);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(276, 125);
            this.panel8.TabIndex = 1;
            this.coreBind.SetVerification(this.panel8, null);
            // 
            // VideoChannel3
            // 
            this.coreBind.SetDatabasecommand(this.VideoChannel3, null);
            this.VideoChannel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoChannel3.Location = new System.Drawing.Point(0, 0);
            this.VideoChannel3.Name = "VideoChannel3";
            this.VideoChannel3.Size = new System.Drawing.Size(276, 125);
            this.VideoChannel3.TabIndex = 0;
            this.VideoChannel3.TabStop = false;
            this.coreBind.SetVerification(this.VideoChannel3, null);
            // 
            // picFDTP
            // 
            this.coreBind.SetDatabasecommand(this.picFDTP, null);
            this.picFDTP.Location = new System.Drawing.Point(180, 122);
            this.picFDTP.Name = "picFDTP";
            this.picFDTP.Size = new System.Drawing.Size(10, 10);
            this.picFDTP.TabIndex = 607;
            this.picFDTP.TabStop = false;
            this.coreBind.SetVerification(this.picFDTP, null);
            this.picFDTP.MouseLeave += new System.EventHandler(this.picFDTP_MouseLeave);
            this.picFDTP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFDTP_MouseMove);
            this.picFDTP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFDTP_MouseDown);
            this.picFDTP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFDTP_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.txtXSZL);
            this.panel3.Controls.Add(this.lxLedControl1);
            this.panel3.Controls.Add(this.btnWeightException);
            this.panel3.Controls.Add(this.btnWeightComplete);
            this.panel3.Controls.Add(this.StatusLight);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.cbx_print);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btnQL);
            this.panel3.Controls.Add(this.lbWD);
            this.panel3.Controls.Add(this.lbYS);
            this.panel3.Controls.Add(this.txtYKL);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtGH);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDH);
            this.coreBind.SetDatabasecommand(this.panel3, null);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(288, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 110);
            this.panel3.TabIndex = 20;
            this.coreBind.SetVerification(this.panel3, null);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.checkBox2, null);
            this.checkBox2.Location = new System.Drawing.Point(530, 89);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 679;
            this.checkBox2.Text = "实重";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.checkBox2, null);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.coreBind.SetDatabasecommand(this.checkBox1, null);
            this.checkBox1.Location = new System.Drawing.Point(480, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 678;
            this.checkBox1.Text = "理重";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.checkBox1, null);
            // 
            // txtXSZL
            // 
            this.txtXSZL.BackColor = System.Drawing.Color.Transparent;
            this.txtXSZL.BackColor_1 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtXSZL.BackColor_2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtXSZL.BevelRate = 0.5F;
            this.txtXSZL.CornerRadius = 6;
            this.coreBind.SetDatabasecommand(this.txtXSZL, null);
            this.txtXSZL.FadedColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtXSZL.ForeColor = System.Drawing.Color.Green;
            this.txtXSZL.HighlightOpaque = ((byte)(50));
            this.txtXSZL.Location = new System.Drawing.Point(46, 27);
            this.txtXSZL.Name = "txtXSZL";
            this.txtXSZL.Size = new System.Drawing.Size(258, 71);
            this.txtXSZL.TabIndex = 677;
            this.txtXSZL.Text = "0.000";
            this.txtXSZL.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.txtXSZL.TotalCharCount = 7;
            this.coreBind.SetVerification(this.txtXSZL, null);
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Black;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DimGray;
            this.lxLedControl1.BevelRate = 0.5F;
            this.coreBind.SetDatabasecommand(this.lxLedControl1, null);
            this.lxLedControl1.FadedColor = System.Drawing.Color.DimGray;
            this.lxLedControl1.ForeColor = System.Drawing.Color.LightGreen;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(152, 45);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.Size = new System.Drawing.Size(8, 8);
            this.lxLedControl1.TabIndex = 676;
            this.lxLedControl1.Text = "LXLEDCONTROL1";
            this.coreBind.SetVerification(this.lxLedControl1, null);
            // 
            // btnWeightException
            // 
            this.btnWeightException.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coreBind.SetDatabasecommand(this.btnWeightException, null);
            this.btnWeightException.Location = new System.Drawing.Point(618, 63);
            this.btnWeightException.Name = "btnWeightException";
            this.btnWeightException.Size = new System.Drawing.Size(64, 28);
            this.btnWeightException.TabIndex = 674;
            this.btnWeightException.Text = "计量异常";
            this.btnWeightException.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnWeightException, null);
            // 
            // btnWeightComplete
            // 
            this.btnWeightComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coreBind.SetDatabasecommand(this.btnWeightComplete, null);
            this.btnWeightComplete.Location = new System.Drawing.Point(618, 29);
            this.btnWeightComplete.Name = "btnWeightComplete";
            this.btnWeightComplete.Size = new System.Drawing.Size(64, 28);
            this.btnWeightComplete.TabIndex = 673;
            this.btnWeightComplete.Text = "计量完成";
            this.btnWeightComplete.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnWeightComplete, null);
            // 
            // StatusLight
            // 
            this.coreBind.SetDatabasecommand(this.StatusLight, null);
            this.StatusLight.Gradient = true;
            this.StatusLight.Location = new System.Drawing.Point(584, 42);
            this.StatusLight.Name = "StatusLight";
            this.StatusLight.Size = new System.Drawing.Size(32, 32);
            this.StatusLight.TabIndex = 672;
            this.StatusLight.Text = "coolIndicator2";
            this.coreBind.SetVerification(this.StatusLight, null);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Blue;
            this.coreBind.SetDatabasecommand(this.button16, null);
            this.button16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button16.Location = new System.Drawing.Point(319, 71);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 36);
            this.button16.TabIndex = 670;
            this.button16.Text = "保存";
            this.button16.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.button16, null);
            this.button16.Visible = false;
            // 
            // cbx_print
            // 
            this.cbx_print.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.cbx_print, null);
            this.cbx_print.Location = new System.Drawing.Point(404, 90);
            this.cbx_print.Name = "cbx_print";
            this.cbx_print.Size = new System.Drawing.Size(72, 16);
            this.cbx_print.TabIndex = 670;
            this.cbx_print.Text = "打印标牌";
            this.cbx_print.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.cbx_print, null);
            // 
            // textBox1
            // 
            this.coreBind.SetDatabasecommand(this.textBox1, null);
            this.textBox1.Location = new System.Drawing.Point(418, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 572;
            this.coreBind.SetVerification(this.textBox1, null);
            this.textBox1.Visible = false;
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coreBind.SetDatabasecommand(this.btnQL, null);
            this.btnQL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQL.Location = new System.Drawing.Point(396, 57);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(93, 28);
            this.btnQL.TabIndex = 5;
            this.btnQL.Text = "清零";
            this.btnQL.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnQL, null);
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // lbWD
            // 
            this.lbWD.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.lbWD, null);
            this.lbWD.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWD.Location = new System.Drawing.Point(432, 29);
            this.lbWD.Name = "lbWD";
            this.lbWD.Size = new System.Drawing.Size(60, 24);
            this.lbWD.TabIndex = 4;
            this.lbWD.Text = "稳定";
            this.coreBind.SetVerification(this.lbWD, null);
            // 
            // lbYS
            // 
            this.coreBind.SetDatabasecommand(this.lbYS, null);
            this.lbYS.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbYS.ForeColor = System.Drawing.Color.Red;
            this.lbYS.Location = new System.Drawing.Point(393, 25);
            this.lbYS.Name = "lbYS";
            this.lbYS.Size = new System.Drawing.Size(37, 33);
            this.lbYS.TabIndex = 3;
            this.lbYS.Text = "●";
            this.lbYS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.lbYS, null);
            // 
            // txtYKL
            // 
            this.txtYKL.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtYKL, null);
            this.txtYKL.Font = new System.Drawing.Font("宋体", 11F);
            this.txtYKL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYKL.Location = new System.Drawing.Point(205, 19);
            this.txtYKL.MaxLength = 8;
            this.txtYKL.Name = "txtYKL";
            this.txtYKL.Size = new System.Drawing.Size(10, 24);
            this.txtYKL.TabIndex = 19;
            this.coreBind.SetVerification(this.txtYKL, null);
            this.txtYKL.Visible = false;
            // 
            // label14
            // 
            this.coreBind.SetDatabasecommand(this.label14, null);
            this.label14.Location = new System.Drawing.Point(379, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 16);
            this.label14.TabIndex = 661;
            this.label14.Text = "应扣量(Kg)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label14, null);
            this.label14.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.label2, null);
            this.label2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "吨";
            this.coreBind.SetVerification(this.label2, null);
            // 
            // label7
            // 
            this.coreBind.SetDatabasecommand(this.label7, null);
            this.label7.Location = new System.Drawing.Point(154, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 632;
            this.label7.Text = "钩号";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label7, null);
            this.label7.Visible = false;
            // 
            // txtGH
            // 
            this.txtGH.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtGH, null);
            this.txtGH.Font = new System.Drawing.Font("宋体", 11F);
            this.txtGH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGH.Location = new System.Drawing.Point(235, 0);
            this.txtGH.MaxLength = 8;
            this.txtGH.Name = "txtGH";
            this.txtGH.ReadOnly = true;
            this.txtGH.Size = new System.Drawing.Size(53, 24);
            this.txtGH.TabIndex = 4;
            this.coreBind.SetVerification(this.txtGH, null);
            this.txtGH.Visible = false;
            // 
            // label3
            // 
            this.coreBind.SetDatabasecommand(this.label3, null);
            this.label3.Location = new System.Drawing.Point(290, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 653;
            this.label3.Text = "吊号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label3, null);
            this.label3.Visible = false;
            // 
            // txtDH
            // 
            this.txtDH.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtDH, null);
            this.txtDH.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDH.Location = new System.Drawing.Point(357, 0);
            this.txtDH.MaxLength = 8;
            this.txtDH.Name = "txtDH";
            this.txtDH.ReadOnly = true;
            this.txtDH.Size = new System.Drawing.Size(53, 24);
            this.txtDH.TabIndex = 5;
            this.coreBind.SetVerification(this.txtDH, null);
            this.txtDH.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ultraGroupBox2);
            this.panel4.Controls.Add(this.ultraGroupBox1);
            this.coreBind.SetDatabasecommand(this.panel4, null);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(288, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 185);
            this.panel4.TabIndex = 21;
            this.coreBind.SetVerification(this.panel4, null);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.ultraGrid1);
            this.ultraGroupBox2.Controls.Add(this.dataGridView1);
            this.coreBind.SetDatabasecommand(this.ultraGroupBox2, null);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox2.Location = new System.Drawing.Point(658, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(61, 185);
            this.ultraGroupBox2.TabIndex = 3;
            this.ultraGroupBox2.Text = "预报信息";
            this.coreBind.SetVerification(this.ultraGroupBox2, null);
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGrid1
            // 
            this.coreBind.SetDatabasecommand(this.ultraGrid1, null);
            this.ultraGrid1.DataMember = "Table1";
            this.ultraGrid1.DataSource = this.ds_plan;
            appearance23.BackColor = System.Drawing.Color.White;
            appearance23.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid1.DisplayLayout.Appearance = appearance23;
            ultraGridColumn40.Header.VisiblePosition = 0;
            ultraGridColumn41.Header.VisiblePosition = 1;
            ultraGridColumn41.Hidden = true;
            ultraGridColumn42.Header.VisiblePosition = 2;
            ultraGridColumn42.Hidden = true;
            ultraGridColumn43.Header.VisiblePosition = 3;
            ultraGridColumn43.Hidden = true;
            ultraGridColumn44.Header.VisiblePosition = 4;
            ultraGridColumn45.Header.VisiblePosition = 5;
            ultraGridColumn46.Header.VisiblePosition = 6;
            ultraGridColumn46.Hidden = true;
            ultraGridColumn47.Header.VisiblePosition = 7;
            ultraGridColumn47.Hidden = true;
            ultraGridColumn48.Header.VisiblePosition = 8;
            ultraGridColumn48.Hidden = true;
            ultraGridColumn49.Header.VisiblePosition = 9;
            ultraGridColumn50.Header.VisiblePosition = 10;
            ultraGridColumn51.Header.VisiblePosition = 11;
            ultraGridColumn51.Hidden = true;
            ultraGridColumn52.Header.VisiblePosition = 12;
            ultraGridColumn53.Header.VisiblePosition = 13;
            ultraGridColumn53.Hidden = true;
            ultraGridColumn54.Header.VisiblePosition = 14;
            ultraGridColumn54.Hidden = true;
            ultraGridColumn55.Header.VisiblePosition = 15;
            ultraGridColumn55.Hidden = true;
            ultraGridColumn56.Header.VisiblePosition = 16;
            ultraGridColumn56.Hidden = true;
            ultraGridColumn57.Header.VisiblePosition = 17;
            ultraGridColumn57.Hidden = true;
            ultraGridColumn58.Header.VisiblePosition = 18;
            ultraGridColumn58.Hidden = true;
            ultraGridColumn59.Header.VisiblePosition = 19;
            ultraGridColumn60.Header.VisiblePosition = 20;
            ultraGridColumn60.Hidden = true;
            ultraGridColumn61.Header.VisiblePosition = 21;
            ultraGridColumn61.Hidden = true;
            ultraGridColumn62.Header.VisiblePosition = 22;
            ultraGridColumn62.Hidden = true;
            ultraGridColumn63.Header.VisiblePosition = 23;
            ultraGridColumn63.Hidden = true;
            ultraGridColumn64.Header.VisiblePosition = 24;
            ultraGridColumn64.Hidden = true;
            ultraGridColumn65.Header.VisiblePosition = 25;
            ultraGridColumn65.Hidden = true;
            ultraGridColumn66.Header.VisiblePosition = 26;
            ultraGridColumn66.Hidden = true;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn40,
            ultraGridColumn41,
            ultraGridColumn42,
            ultraGridColumn43,
            ultraGridColumn44,
            ultraGridColumn45,
            ultraGridColumn46,
            ultraGridColumn47,
            ultraGridColumn48,
            ultraGridColumn49,
            ultraGridColumn50,
            ultraGridColumn51,
            ultraGridColumn52,
            ultraGridColumn53,
            ultraGridColumn54,
            ultraGridColumn55,
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66});
            ultraGridBand3.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout;
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ultraGrid1.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance24.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance24;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGrid1.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance25.BackColor2 = System.Drawing.Color.White;
            appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance25.FontData.SizeInPoints = 11F;
            appearance25.FontData.UnderlineAsString = "False";
            appearance25.ForeColor = System.Drawing.Color.Black;
            appearance25.TextHAlignAsString = "Center";
            appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance25;
            appearance26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance26;
            appearance27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance27.BackColor2 = System.Drawing.Color.White;
            appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorAppearance = appearance27;
            this.ultraGrid1.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ultraGrid1.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance28.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance28.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid1.DisplayLayout.Override.SelectedRowAppearance = appearance28;
            this.ultraGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.ultraGrid1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ultraGrid1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ultraGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid1.Font = new System.Drawing.Font("宋体", 15F);
            this.ultraGrid1.Location = new System.Drawing.Point(3, 31);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(55, 151);
            this.ultraGrid1.TabIndex = 8;
            this.coreBind.SetVerification(this.ultraGrid1, null);
            this.ultraGrid1.Click += new System.EventHandler(this.ultraGrid1_Click);
            // 
            // ds_plan
            // 
            this.ds_plan.DataSetName = "NewDataSet";
            this.ds_plan.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable4});
            // 
            // dataTable4
            // 
            this.dataTable4.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21,
            this.dataColumn22,
            this.dataColumn23,
            this.dataColumn24,
            this.dataColumn25,
            this.dataColumn33,
            this.dataColumn34,
            this.dataColumn35,
            this.dataColumn36,
            this.dataColumn37,
            this.dataColumn38,
            this.dataColumn39,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn42,
            this.dataColumn43});
            this.dataTable4.TableName = "Table1";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "轧制编号";
            this.dataColumn10.ColumnName = "FS_BATCHNO";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "FS_PRODUCTNO";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "FS_ItemNo";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "FS_TechCardNo";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "坯重";
            this.dataColumn14.ColumnName = "FN_BILLETWEIGHT";
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "炉号";
            this.dataColumn15.ColumnName = "FS_STOVENO";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "FN_GP_TOTALCOUNT";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "FS_MATERIALNAME";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "SENDER";
            // 
            // dataColumn19
            // 
            this.dataColumn19.Caption = "钢号";
            this.dataColumn19.ColumnName = "FS_STEELTYPE";
            // 
            // dataColumn20
            // 
            this.dataColumn20.Caption = "规格";
            this.dataColumn20.ColumnName = "FS_SPEC";
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "RECEIVER";
            // 
            // dataColumn22
            // 
            this.dataColumn22.Caption = "长度";
            this.dataColumn22.ColumnName = "FN_LENGTH";
            // 
            // dataColumn23
            // 
            this.dataColumn23.ColumnName = "FS_FLOW";
            // 
            // dataColumn24
            // 
            this.dataColumn24.ColumnName = "FS_PLANPERSON";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "FD_TIME";
            // 
            // dataColumn33
            // 
            this.dataColumn33.ColumnName = "FN_JJ_WEIGHT";
            // 
            // dataColumn34
            // 
            this.dataColumn34.ColumnName = "FN_SINGLENUM";
            // 
            // dataColumn35
            // 
            this.dataColumn35.ColumnName = "FN_SINGLEWEIGHT";
            // 
            // dataColumn36
            // 
            this.dataColumn36.Caption = "预报吊数";
            this.dataColumn36.ColumnName = "FN_BANDCOUNT";
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "FS_PRINTTYPE";
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "fs_standardcheck";
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "FS_STEELTYPECHECK";
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "FS_ADDRESSCHECK";
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "fs_printweighttype";
            // 
            // dataColumn42
            // 
            this.dataColumn42.ColumnName = "FS_TWINSTYPE";
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "FS_FCLFLAG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coreBind.SetDatabasecommand(this.dataGridView1, null);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(55, 151);
            this.dataGridView1.TabIndex = 0;
            this.coreBind.SetVerification(this.dataGridView1, null);
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.ultraGrid3);
            this.coreBind.SetDatabasecommand(this.ultraGroupBox1, null);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(658, 185);
            this.ultraGroupBox1.TabIndex = 2;
            this.ultraGroupBox1.Text = "本批数据";
            this.coreBind.SetVerification(this.ultraGroupBox1, null);
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGrid3
            // 
            this.coreBind.SetDatabasecommand(this.ultraGrid3, null);
            appearance35.BackColor = System.Drawing.Color.White;
            appearance35.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid3.DisplayLayout.Appearance = appearance35;
            this.ultraGrid3.DisplayLayout.InterBandSpacing = 10;
            appearance36.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid3.DisplayLayout.Override.CardAreaAppearance = appearance36;
            appearance37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance37.BackColor2 = System.Drawing.Color.White;
            appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance37.FontData.SizeInPoints = 11F;
            appearance37.FontData.UnderlineAsString = "False";
            appearance37.ForeColor = System.Drawing.Color.Black;
            appearance37.TextHAlignAsString = "Center";
            appearance37.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid3.DisplayLayout.Override.HeaderAppearance = appearance37;
            appearance38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid3.DisplayLayout.Override.RowAppearance = appearance38;
            appearance39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance39.BackColor2 = System.Drawing.Color.White;
            appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid3.DisplayLayout.Override.RowSelectorAppearance = appearance39;
            this.ultraGrid3.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ultraGrid3.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance40.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance40.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid3.DisplayLayout.Override.SelectedRowAppearance = appearance40;
            this.ultraGrid3.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid3.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid3.Font = new System.Drawing.Font("宋体", 15F);
            this.ultraGrid3.Location = new System.Drawing.Point(3, 18);
            this.ultraGrid3.Name = "ultraGrid3";
            this.ultraGrid3.Size = new System.Drawing.Size(652, 164);
            this.ultraGrid3.TabIndex = 7;
            this.coreBind.SetVerification(this.ultraGrid3, null);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            this.dataSet2.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable3});
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable3.TableName = "钩号匹配信息";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "钩号";
            this.dataColumn2.ColumnName = "FN_HOOKNO";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "轧制批号";
            this.dataColumn3.ColumnName = "FS_BATCHNO";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "吊号";
            this.dataColumn4.ColumnName = "FN_BANDNO";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "钩状态";
            this.dataColumn5.ColumnName = "FS_LOSTFLAG";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "是否复磅";
            this.dataColumn6.ColumnName = "FS_REDOFLAG";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "序号";
            this.dataColumn7.ColumnName = "FN_NUMBER";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.panel6.Controls.Add(this.panel5);
            this.coreBind.SetDatabasecommand(this.panel6, null);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(288, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(719, 334);
            this.panel6.TabIndex = 23;
            this.coreBind.SetVerification(this.panel6, null);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox7);
            this.panel5.Controls.Add(this.groupBox4);
            this.coreBind.SetDatabasecommand(this.panel5, null);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(719, 334);
            this.panel5.TabIndex = 23;
            this.coreBind.SetVerification(this.panel5, null);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.groupBox7.Controls.Add(this.panel13);
            this.coreBind.SetDatabasecommand(this.groupBox7, null);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox7.Location = new System.Drawing.Point(658, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(61, 334);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "计量点接管信息";
            this.coreBind.SetVerification(this.groupBox7, null);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.ultraGrid2);
            this.panel13.Controls.Add(this.panel9);
            this.coreBind.SetDatabasecommand(this.panel13, null);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 17);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(55, 314);
            this.panel13.TabIndex = 0;
            this.coreBind.SetVerification(this.panel13, null);
            // 
            // ultraGrid2
            // 
            this.coreBind.SetDatabasecommand(this.ultraGrid2, null);
            this.ultraGrid2.DataMember = "计量点基础表";
            this.ultraGrid2.DataSource = this.dataSet1;
            appearance13.BackColor = System.Drawing.Color.White;
            appearance13.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal;
            this.ultraGrid2.DisplayLayout.Appearance = appearance13;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 124;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridColumn6.Width = 153;
            ultraGridColumn7.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True;
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
            ultraGridColumn7.Width = 45;
            ultraGridColumn8.Header.VisiblePosition = 3;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 4;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.Header.VisiblePosition = 5;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 6;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.Header.VisiblePosition = 7;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn13.Header.VisiblePosition = 8;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.Header.VisiblePosition = 9;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn15.Header.VisiblePosition = 10;
            ultraGridColumn15.Hidden = true;
            ultraGridColumn16.Header.VisiblePosition = 11;
            ultraGridColumn16.Hidden = true;
            ultraGridColumn17.Header.VisiblePosition = 12;
            ultraGridColumn17.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 13;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn19.Header.VisiblePosition = 14;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 15;
            ultraGridColumn20.Hidden = true;
            ultraGridColumn21.Header.VisiblePosition = 16;
            ultraGridColumn21.Hidden = true;
            ultraGridColumn22.Header.VisiblePosition = 17;
            ultraGridColumn22.Hidden = true;
            ultraGridColumn23.Header.VisiblePosition = 18;
            ultraGridColumn23.Hidden = true;
            ultraGridColumn24.Header.VisiblePosition = 19;
            ultraGridColumn24.Hidden = true;
            ultraGridColumn25.Header.VisiblePosition = 20;
            ultraGridColumn25.Hidden = true;
            ultraGridColumn26.Header.VisiblePosition = 21;
            ultraGridColumn26.Hidden = true;
            ultraGridColumn27.Header.VisiblePosition = 22;
            ultraGridColumn27.Hidden = true;
            ultraGridColumn28.Header.VisiblePosition = 23;
            ultraGridColumn28.Hidden = true;
            ultraGridColumn29.Header.VisiblePosition = 24;
            ultraGridColumn29.Hidden = true;
            ultraGridColumn30.Header.VisiblePosition = 25;
            ultraGridColumn30.Hidden = true;
            ultraGridColumn31.Header.VisiblePosition = 26;
            ultraGridColumn31.Hidden = true;
            ultraGridColumn32.Header.VisiblePosition = 27;
            ultraGridColumn32.Hidden = true;
            ultraGridColumn33.Header.VisiblePosition = 28;
            ultraGridColumn33.Hidden = true;
            ultraGridColumn34.Header.VisiblePosition = 29;
            ultraGridColumn34.Hidden = true;
            ultraGridColumn35.Header.VisiblePosition = 30;
            ultraGridColumn35.Hidden = true;
            ultraGridColumn36.Header.VisiblePosition = 31;
            ultraGridColumn36.Hidden = true;
            ultraGridColumn37.Header.VisiblePosition = 32;
            ultraGridColumn37.Hidden = true;
            ultraGridColumn38.Header.VisiblePosition = 33;
            ultraGridColumn38.Hidden = true;
            ultraGridColumn39.Header.VisiblePosition = 34;
            ultraGridColumn39.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29,
            ultraGridColumn30,
            ultraGridColumn31,
            ultraGridColumn32,
            ultraGridColumn33,
            ultraGridColumn34,
            ultraGridColumn35,
            ultraGridColumn36,
            ultraGridColumn37,
            ultraGridColumn38,
            ultraGridColumn39});
            this.ultraGrid2.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ultraGrid2.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGrid2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid2.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance15.BackColor2 = System.Drawing.Color.White;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance15.FontData.SizeInPoints = 11F;
            appearance15.FontData.UnderlineAsString = "False";
            appearance15.ForeColor = System.Drawing.Color.Black;
            appearance15.TextHAlignAsString = "Center";
            appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid2.DisplayLayout.Override.HeaderAppearance = appearance15;
            appearance16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid2.DisplayLayout.Override.RowAppearance = appearance16;
            appearance17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            appearance17.BackColor2 = System.Drawing.Color.White;
            appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            this.ultraGrid2.DisplayLayout.Override.RowSelectorAppearance = appearance17;
            this.ultraGrid2.DisplayLayout.Override.RowSelectorWidth = 12;
            this.ultraGrid2.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance18.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance18.ForeColor = System.Drawing.Color.Black;
            this.ultraGrid2.DisplayLayout.Override.SelectedRowAppearance = appearance18;
            this.ultraGrid2.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid2.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid2.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.ultraGrid2.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(208)))));
            this.ultraGrid2.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.ultraGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGrid2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ultraGrid2.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid2.Name = "ultraGrid2";
            this.ultraGrid2.Size = new System.Drawing.Size(51, 270);
            this.ultraGrid2.TabIndex = 2;
            this.coreBind.SetVerification(this.ultraGrid2, null);
            this.ultraGrid2.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.ultraGrid2_DoubleClickRow);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(208)))), ((int)(((byte)(250)))));
            this.panel9.Controls.Add(this.btnOpen);
            this.coreBind.SetDatabasecommand(this.panel9, null);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 270);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(51, 40);
            this.panel9.TabIndex = 2;
            this.coreBind.SetVerification(this.panel9, null);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Blue;
            this.coreBind.SetDatabasecommand(this.btnOpen, null);
            this.btnOpen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOpen.Location = new System.Drawing.Point(6, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(72, 32);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开设备";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnOpen, null);
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel7);
            this.coreBind.SetDatabasecommand(this.groupBox4, null);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(658, 334);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "称重信息";
            this.coreBind.SetVerification(this.groupBox4, null);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label31);
            this.panel7.Controls.Add(this.textMinWeight);
            this.panel7.Controls.Add(this.label30);
            this.panel7.Controls.Add(this.textMaxWeight);
            this.panel7.Controls.Add(this.txtBZ);
            this.panel7.Controls.Add(this.txtBC);
            this.panel7.Controls.Add(this.button18);
            this.panel7.Controls.Add(this.tbx_theoryweight);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.tbx_lasttotalweight);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.tbx_lastbandcount);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.tbx_lastbatch);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Controls.Add(this.tbx_BandCount);
            this.panel7.Controls.Add(this.tb_yubaokunshu);
            this.panel7.Controls.Add(this.cbx_Standard);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.cbPrintType);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.cbDCCD);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtZS);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.cbLXIN);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtDDH);
            this.panel7.Controls.Add(this.txtDDXMH);
            this.panel7.Controls.Add(this.cbGG);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.cbGZ);
            this.panel7.Controls.Add(this.cbFHDW);
            this.panel7.Controls.Add(this.cbLX);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.cbWLMC);
            this.panel7.Controls.Add(this.cbSHDW);
            this.panel7.Controls.Add(this.txtJLY);
            this.panel7.Controls.Add(this.txtZL);
            this.panel7.Controls.Add(this.txtJLD);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.txtZZBH);
            this.panel7.Controls.Add(this.label11);
            this.coreBind.SetDatabasecommand(this.panel7, null);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(652, 314);
            this.panel7.TabIndex = 0;
            this.coreBind.SetVerification(this.panel7, null);
            // 
            // label31
            // 
            this.coreBind.SetDatabasecommand(this.label31, null);
            this.label31.Location = new System.Drawing.Point(155, 275);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 24);
            this.label31.TabIndex = 685;
            this.label31.Text = "重量下限：";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label31, null);
            // 
            // textMinWeight
            // 
            this.textMinWeight.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.textMinWeight, null);
            this.textMinWeight.Enabled = false;
            this.textMinWeight.Font = new System.Drawing.Font("宋体", 11F);
            this.textMinWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textMinWeight.Location = new System.Drawing.Point(228, 275);
            this.textMinWeight.MaxLength = 8;
            this.textMinWeight.Name = "textMinWeight";
            this.textMinWeight.ReadOnly = true;
            this.textMinWeight.Size = new System.Drawing.Size(59, 24);
            this.textMinWeight.TabIndex = 684;
            this.coreBind.SetVerification(this.textMinWeight, null);
            // 
            // label30
            // 
            this.coreBind.SetDatabasecommand(this.label30, null);
            this.label30.Location = new System.Drawing.Point(15, 277);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 24);
            this.label30.TabIndex = 681;
            this.label30.Text = "重量上限：";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label30, null);
            // 
            // textMaxWeight
            // 
            this.textMaxWeight.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.textMaxWeight, null);
            this.textMaxWeight.Enabled = false;
            this.textMaxWeight.Font = new System.Drawing.Font("宋体", 11F);
            this.textMaxWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textMaxWeight.Location = new System.Drawing.Point(88, 275);
            this.textMaxWeight.MaxLength = 8;
            this.textMaxWeight.Name = "textMaxWeight";
            this.textMaxWeight.ReadOnly = true;
            this.textMaxWeight.Size = new System.Drawing.Size(56, 24);
            this.textMaxWeight.TabIndex = 680;
            this.coreBind.SetVerification(this.textMaxWeight, null);
            // 
            // txtBZ
            // 
            this.txtBZ.BackColor = System.Drawing.Color.Bisque;
            this.coreBind.SetDatabasecommand(this.txtBZ, null);
            this.txtBZ.Enabled = false;
            this.txtBZ.Font = new System.Drawing.Font("宋体", 11F);
            this.txtBZ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBZ.Location = new System.Drawing.Point(109, 172);
            this.txtBZ.MaxLength = 8;
            this.txtBZ.Name = "txtBZ";
            this.txtBZ.ReadOnly = true;
            this.txtBZ.Size = new System.Drawing.Size(35, 24);
            this.txtBZ.TabIndex = 683;
            this.coreBind.SetVerification(this.txtBZ, null);
            // 
            // txtBC
            // 
            this.txtBC.BackColor = System.Drawing.Color.Bisque;
            this.coreBind.SetDatabasecommand(this.txtBC, null);
            this.txtBC.Enabled = false;
            this.txtBC.Font = new System.Drawing.Font("宋体", 11F);
            this.txtBC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBC.Location = new System.Drawing.Point(72, 172);
            this.txtBC.MaxLength = 8;
            this.txtBC.Name = "txtBC";
            this.txtBC.ReadOnly = true;
            this.txtBC.Size = new System.Drawing.Size(35, 24);
            this.txtBC.TabIndex = 17;
            this.coreBind.SetVerification(this.txtBC, null);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Blue;
            this.coreBind.SetDatabasecommand(this.button18, null);
            this.button18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button18.Location = new System.Drawing.Point(151, 172);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(47, 24);
            this.button18.TabIndex = 682;
            this.button18.Text = "换班";
            this.button18.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.button18, null);
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // tbx_theoryweight
            // 
            this.tbx_theoryweight.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_theoryweight, null);
            this.tbx_theoryweight.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_theoryweight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_theoryweight.Location = new System.Drawing.Point(479, 245);
            this.tbx_theoryweight.MaxLength = 12;
            this.tbx_theoryweight.Name = "tbx_theoryweight";
            this.tbx_theoryweight.Size = new System.Drawing.Size(74, 24);
            this.tbx_theoryweight.TabIndex = 678;
            this.coreBind.SetVerification(this.tbx_theoryweight, null);
            // 
            // label28
            // 
            this.coreBind.SetDatabasecommand(this.label28, null);
            this.label28.Location = new System.Drawing.Point(435, 245);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 24);
            this.label28.TabIndex = 679;
            this.label28.Text = "理重：";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label28, null);
            // 
            // tbx_lasttotalweight
            // 
            this.tbx_lasttotalweight.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_lasttotalweight, null);
            this.tbx_lasttotalweight.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_lasttotalweight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_lasttotalweight.Location = new System.Drawing.Point(348, 245);
            this.tbx_lasttotalweight.MaxLength = 12;
            this.tbx_lasttotalweight.Name = "tbx_lasttotalweight";
            this.tbx_lasttotalweight.Size = new System.Drawing.Size(74, 24);
            this.tbx_lasttotalweight.TabIndex = 676;
            this.coreBind.SetVerification(this.tbx_lasttotalweight, null);
            // 
            // label27
            // 
            this.coreBind.SetDatabasecommand(this.label27, null);
            this.label27.Location = new System.Drawing.Point(303, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 24);
            this.label27.TabIndex = 677;
            this.label27.Text = "实重：";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label27, null);
            // 
            // tbx_lastbandcount
            // 
            this.tbx_lastbandcount.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_lastbandcount, null);
            this.tbx_lastbandcount.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_lastbandcount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_lastbandcount.Location = new System.Drawing.Point(227, 245);
            this.tbx_lastbandcount.MaxLength = 12;
            this.tbx_lastbandcount.Name = "tbx_lastbandcount";
            this.tbx_lastbandcount.Size = new System.Drawing.Size(60, 24);
            this.tbx_lastbandcount.TabIndex = 674;
            this.coreBind.SetVerification(this.tbx_lastbandcount, null);
            // 
            // label26
            // 
            this.coreBind.SetDatabasecommand(this.label26, null);
            this.label26.Location = new System.Drawing.Point(183, 245);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 24);
            this.label26.TabIndex = 675;
            this.label26.Text = "吊数：";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label26, null);
            // 
            // tbx_lastbatch
            // 
            this.tbx_lastbatch.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_lastbatch, null);
            this.tbx_lastbatch.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_lastbatch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_lastbatch.Location = new System.Drawing.Point(88, 245);
            this.tbx_lastbatch.MaxLength = 12;
            this.tbx_lastbatch.Name = "tbx_lastbatch";
            this.tbx_lastbatch.Size = new System.Drawing.Size(95, 24);
            this.tbx_lastbatch.TabIndex = 672;
            this.coreBind.SetVerification(this.tbx_lastbatch, null);
            // 
            // label25
            // 
            this.coreBind.SetDatabasecommand(this.label25, null);
            this.label25.Location = new System.Drawing.Point(0, 245);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 24);
            this.label25.TabIndex = 673;
            this.label25.Text = "上一批次号：";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label25, null);
            // 
            // tbx_BandCount
            // 
            this.tbx_BandCount.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_BandCount, null);
            this.tbx_BandCount.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_BandCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_BandCount.Location = new System.Drawing.Point(435, 173);
            this.tbx_BandCount.MaxLength = 8;
            this.tbx_BandCount.Name = "tbx_BandCount";
            this.tbx_BandCount.ReadOnly = true;
            this.tbx_BandCount.Size = new System.Drawing.Size(93, 24);
            this.tbx_BandCount.TabIndex = 670;
            this.coreBind.SetVerification(this.tbx_BandCount, null);
            // 
            // tb_yubaokunshu
            // 
            this.coreBind.SetDatabasecommand(this.tb_yubaokunshu, null);
            this.tb_yubaokunshu.Location = new System.Drawing.Point(370, 173);
            this.tb_yubaokunshu.Name = "tb_yubaokunshu";
            this.tb_yubaokunshu.Size = new System.Drawing.Size(63, 24);
            this.tb_yubaokunshu.TabIndex = 671;
            this.tb_yubaokunshu.Text = "预报捆数";
            this.tb_yubaokunshu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.tb_yubaokunshu, null);
            // 
            // cbx_Standard
            // 
            this.coreBind.SetDatabasecommand(this.cbx_Standard, null);
            this.cbx_Standard.FormattingEnabled = true;
            this.cbx_Standard.Location = new System.Drawing.Point(262, 149);
            this.cbx_Standard.Name = "cbx_Standard";
            this.cbx_Standard.Size = new System.Drawing.Size(112, 20);
            this.cbx_Standard.TabIndex = 669;
            this.coreBind.SetVerification(this.cbx_Standard, null);
            // 
            // label24
            // 
            this.coreBind.SetDatabasecommand(this.label24, null);
            this.label24.Location = new System.Drawing.Point(199, 146);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 24);
            this.label24.TabIndex = 668;
            this.label24.Text = "标准";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label24, null);
            // 
            // label23
            // 
            this.coreBind.SetDatabasecommand(this.label23, null);
            this.label23.Location = new System.Drawing.Point(6, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 24);
            this.label23.TabIndex = 666;
            this.label23.Text = "班次";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label23, null);
            // 
            // cbPrintType
            // 
            this.coreBind.SetDatabasecommand(this.cbPrintType, null);
            this.cbPrintType.FormattingEnabled = true;
            this.cbPrintType.Items.AddRange(new object[] {
            "",
            "重点工程专用",
            "省内专用",
            "省内专用"});
            this.cbPrintType.Location = new System.Drawing.Point(353, 35);
            this.cbPrintType.Name = "cbPrintType";
            this.cbPrintType.Size = new System.Drawing.Size(175, 20);
            this.cbPrintType.TabIndex = 664;
            this.coreBind.SetVerification(this.cbPrintType, null);
            // 
            // label15
            // 
            this.coreBind.SetDatabasecommand(this.label15, null);
            this.label15.Location = new System.Drawing.Point(270, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 24);
            this.label15.TabIndex = 665;
            this.label15.Text = "打印类型";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label15, null);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label29);
            this.panel12.Controls.Add(this.tbx_hWeight);
            this.panel12.Controls.Add(this.cbx_Hand);
            this.panel12.Controls.Add(this.tb_bandno_fb);
            this.panel12.Controls.Add(this.label22);
            this.panel12.Controls.Add(this.tb_zzbh_fb);
            this.panel12.Controls.Add(this.label20);
            this.panel12.Controls.Add(this.cbx_fb);
            this.panel12.Controls.Add(this.btnBC);
            this.panel12.Controls.Add(this.btnWL);
            this.coreBind.SetDatabasecommand(this.panel12, null);
            this.panel12.Location = new System.Drawing.Point(0, 198);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(556, 40);
            this.panel12.TabIndex = 662;
            this.coreBind.SetVerification(this.panel12, null);
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.label29, null);
            this.label29.Location = new System.Drawing.Point(424, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 12);
            this.label29.TabIndex = 681;
            this.label29.Text = "吨";
            this.coreBind.SetVerification(this.label29, null);
            // 
            // tbx_hWeight
            // 
            this.tbx_hWeight.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.tbx_hWeight, null);
            this.tbx_hWeight.Enabled = false;
            this.tbx_hWeight.Font = new System.Drawing.Font("宋体", 11F);
            this.tbx_hWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_hWeight.Location = new System.Drawing.Point(350, 9);
            this.tbx_hWeight.MaxLength = 8;
            this.tbx_hWeight.Name = "tbx_hWeight";
            this.tbx_hWeight.Size = new System.Drawing.Size(72, 24);
            this.tbx_hWeight.TabIndex = 680;
            this.coreBind.SetVerification(this.tbx_hWeight, null);
            // 
            // cbx_Hand
            // 
            this.cbx_Hand.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.cbx_Hand, null);
            this.cbx_Hand.Location = new System.Drawing.Point(299, 13);
            this.cbx_Hand.Name = "cbx_Hand";
            this.cbx_Hand.Size = new System.Drawing.Size(48, 16);
            this.cbx_Hand.TabIndex = 670;
            this.cbx_Hand.Text = "手工";
            this.cbx_Hand.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.cbx_Hand, null);
            this.cbx_Hand.CheckStateChanged += new System.EventHandler(this.cbx_Hand_CheckStateChanged);
            this.cbx_Hand.CheckedChanged += new System.EventHandler(this.cbx_Hand_CheckedChanged);
            // 
            // tb_bandno_fb
            // 
            this.coreBind.SetDatabasecommand(this.tb_bandno_fb, null);
            this.tb_bandno_fb.Location = new System.Drawing.Point(236, 9);
            this.tb_bandno_fb.Name = "tb_bandno_fb";
            this.tb_bandno_fb.Size = new System.Drawing.Size(48, 21);
            this.tb_bandno_fb.TabIndex = 669;
            this.coreBind.SetVerification(this.tb_bandno_fb, null);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.label22, null);
            this.label22.Location = new System.Drawing.Point(203, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 668;
            this.label22.Text = "吊号";
            this.coreBind.SetVerification(this.label22, null);
            // 
            // tb_zzbh_fb
            // 
            this.coreBind.SetDatabasecommand(this.tb_zzbh_fb, null);
            this.tb_zzbh_fb.Location = new System.Drawing.Point(115, 9);
            this.tb_zzbh_fb.Name = "tb_zzbh_fb";
            this.tb_zzbh_fb.Size = new System.Drawing.Size(83, 21);
            this.tb_zzbh_fb.TabIndex = 667;
            this.coreBind.SetVerification(this.tb_zzbh_fb, null);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.label20, null);
            this.label20.Location = new System.Drawing.Point(62, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 666;
            this.label20.Text = "轧制编号";
            this.coreBind.SetVerification(this.label20, null);
            // 
            // cbx_fb
            // 
            this.cbx_fb.AutoSize = true;
            this.coreBind.SetDatabasecommand(this.cbx_fb, null);
            this.cbx_fb.Location = new System.Drawing.Point(8, 11);
            this.cbx_fb.Name = "cbx_fb";
            this.cbx_fb.Size = new System.Drawing.Size(48, 16);
            this.cbx_fb.TabIndex = 665;
            this.cbx_fb.Text = "复磅";
            this.cbx_fb.UseVisualStyleBackColor = true;
            this.coreBind.SetVerification(this.cbx_fb, null);
            this.cbx_fb.CheckStateChanged += new System.EventHandler(this.cbx_fb_CheckStateChanged);
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.Color.Blue;
            this.coreBind.SetDatabasecommand(this.btnBC, null);
            this.btnBC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBC.Location = new System.Drawing.Point(479, 5);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(75, 32);
            this.btnBC.TabIndex = 1;
            this.btnBC.Text = "保存";
            this.btnBC.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnBC, null);
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnWL
            // 
            this.btnWL.BackColor = System.Drawing.Color.Blue;
            this.coreBind.SetDatabasecommand(this.btnWL, null);
            this.btnWL.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnWL.Location = new System.Drawing.Point(478, 5);
            this.btnWL.Name = "btnWL";
            this.btnWL.Size = new System.Drawing.Size(75, 32);
            this.btnWL.TabIndex = 2;
            this.btnWL.Text = "完炉";
            this.btnWL.UseVisualStyleBackColor = false;
            this.coreBind.SetVerification(this.btnWL, null);
            this.btnWL.Visible = false;
            this.btnWL.Click += new System.EventHandler(this.btnWL_Click);
            // 
            // cbDCCD
            // 
            this.coreBind.SetDatabasecommand(this.cbDCCD, null);
            this.cbDCCD.FormattingEnabled = true;
            this.cbDCCD.Items.AddRange(new object[] {
            "9",
            "12"});
            this.cbDCCD.Location = new System.Drawing.Point(435, 124);
            this.cbDCCD.Name = "cbDCCD";
            this.cbDCCD.Size = new System.Drawing.Size(93, 20);
            this.cbDCCD.TabIndex = 14;
            this.coreBind.SetVerification(this.cbDCCD, null);
            // 
            // label12
            // 
            this.coreBind.SetDatabasecommand(this.label12, null);
            this.label12.Location = new System.Drawing.Point(373, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 658;
            this.label12.Text = "定尺长度";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label12, null);
            // 
            // txtZS
            // 
            this.txtZS.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtZS, null);
            this.txtZS.Font = new System.Drawing.Font("宋体", 11F);
            this.txtZS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtZS.Location = new System.Drawing.Point(262, 121);
            this.txtZS.MaxLength = 8;
            this.txtZS.Name = "txtZS";
            this.txtZS.Size = new System.Drawing.Size(80, 24);
            this.txtZS.TabIndex = 13;
            this.coreBind.SetVerification(this.txtZS, null);
            // 
            // label4
            // 
            this.coreBind.SetDatabasecommand(this.label4, null);
            this.label4.Location = new System.Drawing.Point(215, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 657;
            this.label4.Text = "支数";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label4, null);
            // 
            // cbLXIN
            // 
            this.coreBind.SetDatabasecommand(this.cbLXIN, null);
            this.cbLXIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLXIN.FormattingEnabled = true;
            this.cbLXIN.Items.AddRange(new object[] {
            "定尺",
            "非定尺"});
            this.cbLXIN.Location = new System.Drawing.Point(72, 124);
            this.cbLXIN.Name = "cbLXIN";
            this.cbLXIN.Size = new System.Drawing.Size(112, 20);
            this.cbLXIN.TabIndex = 12;
            this.coreBind.SetVerification(this.cbLXIN, null);
            // 
            // label1
            // 
            this.coreBind.SetDatabasecommand(this.label1, null);
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 654;
            this.label1.Text = "类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label1, null);
            // 
            // txtDDH
            // 
            this.txtDDH.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtDDH, null);
            this.txtDDH.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDDH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDDH.Location = new System.Drawing.Point(72, 8);
            this.txtDDH.MaxLength = 12;
            this.txtDDH.Name = "txtDDH";
            this.txtDDH.Size = new System.Drawing.Size(175, 24);
            this.txtDDH.TabIndex = 1;
            this.coreBind.SetVerification(this.txtDDH, null);
            this.txtDDH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDDH_KeyPress);
            // 
            // txtDDXMH
            // 
            this.txtDDXMH.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtDDXMH, null);
            this.txtDDXMH.Font = new System.Drawing.Font("宋体", 11F);
            this.txtDDXMH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDDXMH.Location = new System.Drawing.Point(353, 8);
            this.txtDDXMH.MaxLength = 8;
            this.txtDDXMH.Name = "txtDDXMH";
            this.txtDDXMH.Size = new System.Drawing.Size(175, 24);
            this.txtDDXMH.TabIndex = 2;
            this.coreBind.SetVerification(this.txtDDXMH, null);
            // 
            // cbGG
            // 
            this.coreBind.SetDatabasecommand(this.cbGG, null);
            this.cbGG.FormattingEnabled = true;
            this.cbGG.Location = new System.Drawing.Point(353, 102);
            this.cbGG.Name = "cbGG";
            this.cbGG.Size = new System.Drawing.Size(175, 20);
            this.cbGG.TabIndex = 11;
            this.coreBind.SetVerification(this.cbGG, null);
            // 
            // label18
            // 
            this.coreBind.SetDatabasecommand(this.label18, null);
            this.label18.Location = new System.Drawing.Point(272, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 24);
            this.label18.TabIndex = 646;
            this.label18.Text = "规格";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label18, null);
            // 
            // cbGZ
            // 
            this.coreBind.SetDatabasecommand(this.cbGZ, null);
            this.cbGZ.FormattingEnabled = true;
            this.cbGZ.Location = new System.Drawing.Point(72, 102);
            this.cbGZ.Name = "cbGZ";
            this.cbGZ.Size = new System.Drawing.Size(175, 20);
            this.cbGZ.TabIndex = 10;
            this.coreBind.SetVerification(this.cbGZ, null);
            // 
            // cbFHDW
            // 
            this.coreBind.SetDatabasecommand(this.cbFHDW, null);
            this.cbFHDW.FormattingEnabled = true;
            this.cbFHDW.Location = new System.Drawing.Point(72, 80);
            this.cbFHDW.Name = "cbFHDW";
            this.cbFHDW.Size = new System.Drawing.Size(175, 20);
            this.cbFHDW.TabIndex = 8;
            this.coreBind.SetVerification(this.cbFHDW, null);
            this.cbFHDW.Leave += new System.EventHandler(this.cbWLMC_Leave);
            this.cbFHDW.TextChanged += new System.EventHandler(this.cbFHDW_TextChanged);
            // 
            // cbLX
            // 
            this.coreBind.SetDatabasecommand(this.cbLX, null);
            this.cbLX.FormattingEnabled = true;
            this.cbLX.Location = new System.Drawing.Point(353, 58);
            this.cbLX.Name = "cbLX";
            this.cbLX.Size = new System.Drawing.Size(175, 20);
            this.cbLX.TabIndex = 7;
            this.coreBind.SetVerification(this.cbLX, null);
            // 
            // label9
            // 
            this.coreBind.SetDatabasecommand(this.label9, null);
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 634;
            this.label9.Text = "钢种";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label9, null);
            // 
            // label6
            // 
            this.coreBind.SetDatabasecommand(this.label6, null);
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 630;
            this.label6.Text = "发货单位";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label6, null);
            // 
            // label5
            // 
            this.coreBind.SetDatabasecommand(this.label5, null);
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 628;
            this.label5.Text = "订单号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label5, null);
            // 
            // cbWLMC
            // 
            this.coreBind.SetDatabasecommand(this.cbWLMC, null);
            this.cbWLMC.FormattingEnabled = true;
            this.cbWLMC.ItemHeight = 12;
            this.cbWLMC.Items.AddRange(new object[] {
            "棒材成品"});
            this.cbWLMC.Location = new System.Drawing.Point(72, 58);
            this.cbWLMC.Name = "cbWLMC";
            this.cbWLMC.Size = new System.Drawing.Size(175, 20);
            this.cbWLMC.TabIndex = 6;
            this.coreBind.SetVerification(this.cbWLMC, null);
            this.cbWLMC.Leave += new System.EventHandler(this.cbWLMC_Leave);
            this.cbWLMC.TextChanged += new System.EventHandler(this.cbWLMC_TextChanged);
            // 
            // cbSHDW
            // 
            this.coreBind.SetDatabasecommand(this.cbSHDW, null);
            this.cbSHDW.FormattingEnabled = true;
            this.cbSHDW.Location = new System.Drawing.Point(353, 80);
            this.cbSHDW.Name = "cbSHDW";
            this.cbSHDW.Size = new System.Drawing.Size(175, 20);
            this.cbSHDW.TabIndex = 9;
            this.coreBind.SetVerification(this.cbSHDW, null);
            this.cbSHDW.SelectedIndexChanged += new System.EventHandler(this.cbSHDW_SelectedIndexChanged);
            this.cbSHDW.Leave += new System.EventHandler(this.cbWLMC_Leave);
            this.cbSHDW.TextChanged += new System.EventHandler(this.cbSHDW_TextChanged);
            // 
            // txtJLY
            // 
            this.txtJLY.BackColor = System.Drawing.Color.Bisque;
            this.coreBind.SetDatabasecommand(this.txtJLY, null);
            this.txtJLY.Font = new System.Drawing.Font("宋体", 11F);
            this.txtJLY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJLY.Location = new System.Drawing.Point(435, 146);
            this.txtJLY.MaxLength = 8;
            this.txtJLY.Name = "txtJLY";
            this.txtJLY.ReadOnly = true;
            this.txtJLY.Size = new System.Drawing.Size(93, 24);
            this.txtJLY.TabIndex = 16;
            this.coreBind.SetVerification(this.txtJLY, null);
            // 
            // txtZL
            // 
            this.txtZL.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtZL, null);
            this.txtZL.Font = new System.Drawing.Font("宋体", 11F);
            this.txtZL.ForeColor = System.Drawing.Color.Red;
            this.txtZL.Location = new System.Drawing.Point(262, 172);
            this.txtZL.MaxLength = 8;
            this.txtZL.Name = "txtZL";
            this.txtZL.ReadOnly = true;
            this.txtZL.Size = new System.Drawing.Size(80, 24);
            this.txtZL.TabIndex = 18;
            this.coreBind.SetVerification(this.txtZL, null);
            // 
            // txtJLD
            // 
            this.txtJLD.BackColor = System.Drawing.Color.Bisque;
            this.coreBind.SetDatabasecommand(this.txtJLD, null);
            this.txtJLD.Font = new System.Drawing.Font("宋体", 11F);
            this.txtJLD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJLD.Location = new System.Drawing.Point(72, 146);
            this.txtJLD.MaxLength = 8;
            this.txtJLD.Name = "txtJLD";
            this.txtJLD.ReadOnly = true;
            this.txtJLD.Size = new System.Drawing.Size(112, 24);
            this.txtJLD.TabIndex = 15;
            this.coreBind.SetVerification(this.txtJLD, null);
            // 
            // label21
            // 
            this.coreBind.SetDatabasecommand(this.label21, null);
            this.label21.Location = new System.Drawing.Point(199, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 24);
            this.label21.TabIndex = 619;
            this.label21.Text = "重量(t)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label21, null);
            // 
            // label17
            // 
            this.coreBind.SetDatabasecommand(this.label17, null);
            this.label17.Location = new System.Drawing.Point(372, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 24);
            this.label17.TabIndex = 617;
            this.label17.Text = "计量员";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label17, null);
            // 
            // label19
            // 
            this.coreBind.SetDatabasecommand(this.label19, null);
            this.label19.Location = new System.Drawing.Point(6, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 24);
            this.label19.TabIndex = 615;
            this.label19.Text = "计量点";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label19, null);
            // 
            // label16
            // 
            this.coreBind.SetDatabasecommand(this.label16, null);
            this.label16.Location = new System.Drawing.Point(272, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 24);
            this.label16.TabIndex = 613;
            this.label16.Text = "收货单位";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label16, null);
            // 
            // label13
            // 
            this.coreBind.SetDatabasecommand(this.label13, null);
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 609;
            this.label13.Text = "物料名称";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label13, null);
            // 
            // label10
            // 
            this.coreBind.SetDatabasecommand(this.label10, null);
            this.label10.Location = new System.Drawing.Point(272, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 606;
            this.label10.Text = "流向";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label10, null);
            // 
            // label8
            // 
            this.coreBind.SetDatabasecommand(this.label8, null);
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 602;
            this.label8.Text = "轧制编号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label8, null);
            // 
            // txtZZBH
            // 
            this.txtZZBH.BackColor = System.Drawing.SystemColors.Window;
            this.coreBind.SetDatabasecommand(this.txtZZBH, null);
            this.txtZZBH.Font = new System.Drawing.Font("宋体", 11F);
            this.txtZZBH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtZZBH.Location = new System.Drawing.Point(72, 33);
            this.txtZZBH.MaxLength = 8;
            this.txtZZBH.Name = "txtZZBH";
            this.txtZZBH.Size = new System.Drawing.Size(175, 24);
            this.txtZZBH.TabIndex = 3;
            this.coreBind.SetVerification(this.txtZZBH, null);
            // 
            // label11
            // 
            this.coreBind.SetDatabasecommand(this.label11, null);
            this.label11.Location = new System.Drawing.Point(272, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 649;
            this.label11.Text = "订单项目号";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coreBind.SetVerification(this.label11, null);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // windowDockingArea1
            // 
            this.coreBind.SetDatabasecommand(this.windowDockingArea1, null);
            this.windowDockingArea1.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowDockingArea1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.windowDockingArea1.Location = new System.Drawing.Point(871, 0);
            this.windowDockingArea1.Name = "windowDockingArea1";
            this.windowDockingArea1.Owner = this.ultraDockManager1;
            this.windowDockingArea1.Size = new System.Drawing.Size(100, 666);
            this.windowDockingArea1.TabIndex = 13;
            this.coreBind.SetVerification(this.windowDockingArea1, null);
            // 
            // coolIndicator1
            // 
            this.coreBind.SetDatabasecommand(this.coolIndicator1, null);
            this.coolIndicator1.Gradient = true;
            this.coolIndicator1.Location = new System.Drawing.Point(0, 0);
            this.coolIndicator1.Name = "coolIndicator1";
            this.coolIndicator1.Size = new System.Drawing.Size(0, 0);
            this.coolIndicator1.TabIndex = 0;
            this.coolIndicator1.Text = "coolIndicator1";
            this.coreBind.SetVerification(this.coolIndicator1, null);
            // 
            // Weight_BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 655);
            this.Controls.Add(this._Finishing_HotRolledCoilInfoAutoHideControl);
            this.Controls.Add(this.picFDTP);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowDockingArea1);
            this.Controls.Add(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaTop);
            this.Controls.Add(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom);
            this.Controls.Add(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft);
            this.Controls.Add(this._Finishing_HotRolledCoilInfoUnpinnedTabAreaRight);
            this.coreBind.SetDatabasecommand(this, null);
            this.KeyPreview = true;
            this.Name = "Weight_BC";
            this.Text = "80万吨棒材入库计量";
            this.coreBind.SetVerification(this, null);
            this.Load += new System.EventHandler(this.Weight_BC_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Weight_BC_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_BC_KeyPress);
            this.VoiceC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).EndInit();
            this._Finishing_HotRolledCoilInfoAutoHideControl.ResumeLayout(false);
            this.dockableWindow2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel4)).EndInit();
            this.panel14.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel2)).EndInit();
            this.panel16.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoChannel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFDTP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtXSZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_plan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VoiceC;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid5;
        private Infragistics.Win.UltraWinDock.UltraDockManager ultraDockManager1;
        private Infragistics.Win.UltraWinDock.AutoHideControl _Finishing_HotRolledCoilInfoAutoHideControl;
        private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Finishing_HotRolledCoilInfoUnpinnedTabAreaTop;
        private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Finishing_HotRolledCoilInfoUnpinnedTabAreaBottom;
        private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Finishing_HotRolledCoilInfoUnpinnedTabAreaLeft;
        private Infragistics.Win.UltraWinDock.UnpinnedTabArea _Finishing_HotRolledCoilInfoUnpinnedTabAreaRight;
        private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow2;
        private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox VideoChannel3;
        private System.Windows.Forms.PictureBox VideoChannel2;
        private System.Windows.Forms.PictureBox VideoChannel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbYS;
        private System.Windows.Forms.Label lbWD;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Panel panel1_Fill_Panel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _panel1_Toolbars_Dock_Area_Bottom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGH;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel13;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid2;
        private System.Windows.Forms.Panel panel9;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn26;
        private System.Data.DataColumn dataColumn27;
        private System.Data.DataColumn dataColumn28;
        private System.Data.DataColumn dataColumn52;
        private System.Data.DataColumn dataColumn63;
        private System.Data.DataColumn dataColumn64;
        private System.Data.DataColumn dataColumn65;
        private System.Data.DataColumn dataColumn66;
        private System.Data.DataColumn dataColumn67;
        private System.Data.DataColumn dataColumn68;
        private System.Data.DataColumn dataColumn69;
        private System.Data.DataColumn dataColumn70;
        private System.Data.DataColumn dataColumn72;
        private System.Data.DataColumn dataColumn73;
        private System.Data.DataColumn dataColumn74;
        private System.Data.DataColumn dataColumn75;
        private System.Data.DataColumn dataColumn76;
        private System.Data.DataColumn dataColumn77;
        private System.Data.DataColumn dataColumn78;
        private System.Data.DataColumn dataColumn79;
        private System.Data.DataColumn dataColumn80;
        private System.Data.DataColumn dataColumn81;
        private System.Data.DataColumn dataColumn82;
        private System.Data.DataColumn dataColumn83;
        private System.Data.DataColumn dataColumn84;
        private System.Data.DataColumn dataColumn85;
        private System.Data.DataColumn dataColumn86;
        private System.Data.DataColumn dataColumn87;
        private System.Data.DataColumn dataColumn88;
        private System.Data.DataColumn dataColumn89;
        private System.Data.DataColumn dataColumn90;
        private System.Data.DataColumn dataColumn91;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn29;
        private System.Data.DataColumn dataColumn30;
        private System.Data.DataColumn dataColumn31;
        private System.Data.DataColumn dataColumn32;
        private System.Windows.Forms.PictureBox picFDTP;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Data.DataSet dataSet2;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.TextBox txtDH;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtYKL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUsedPrintTink;
        private System.Windows.Forms.TextBox txtUsedPrintPaper;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.Button btnOpen;
        private YGJZJL.Bar.CoolIndicator coolIndicator1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbx_print;
        private System.Data.DataSet ds_plan;
        private System.Data.DataTable dataTable4;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Data.DataColumn dataColumn22;
        private System.Data.DataColumn dataColumn23;
        private System.Data.DataColumn dataColumn24;
        private System.Data.DataColumn dataColumn25;
        private System.Data.DataColumn dataColumn33;
        private System.Data.DataColumn dataColumn34;
        private System.Data.DataColumn dataColumn35;
        private System.Data.DataColumn dataColumn36;
        private System.Data.DataColumn dataColumn37;
        private System.Data.DataColumn dataColumn38;
        private System.Data.DataColumn dataColumn39;
        private System.Data.DataColumn dataColumn40;
        private System.Data.DataColumn dataColumn41;
        private System.Windows.Forms.Button button16;
        private System.Data.DataColumn dataColumn42;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private YGJZJL.Bar.CoolIndicator StatusLight;
        private System.Windows.Forms.Button btnWeightException;
        private System.Windows.Forms.Button btnWeightComplete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox tbx_theoryweight;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbx_lasttotalweight;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbx_lastbandcount;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbx_lastbatch;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbx_BandCount;
        private System.Windows.Forms.Label tb_yubaokunshu;
        private System.Windows.Forms.ComboBox cbx_Standard;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbPrintType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbx_hWeight;
        private System.Windows.Forms.CheckBox cbx_Hand;
        private System.Windows.Forms.TextBox tb_bandno_fb;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_zzbh_fb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbx_fb;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnWL;
        private System.Windows.Forms.ComboBox cbDCCD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtZS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLXIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDDH;
        private System.Windows.Forms.TextBox txtDDXMH;
        private System.Windows.Forms.ComboBox cbGG;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbGZ;
        public System.Windows.Forms.ComboBox cbFHDW;
        private System.Windows.Forms.ComboBox cbLX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbWLMC;
        public System.Windows.Forms.ComboBox cbSHDW;
        private System.Windows.Forms.TextBox txtJLY;
        private System.Windows.Forms.TextBox txtZL;
        private System.Windows.Forms.TextBox txtJLD;
        private System.Windows.Forms.TextBox txtBC;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtZZBH;
        private System.Windows.Forms.Label label11;
        private LxControl.LxLedControl txtXSZL;
        private LxControl.LxLedControl lxLedControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Data.DataColumn dataColumn43;
        private System.Windows.Forms.TextBox txtBZ;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textMinWeight;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textMaxWeight;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.PictureBox VideoChannel4;
    }
}