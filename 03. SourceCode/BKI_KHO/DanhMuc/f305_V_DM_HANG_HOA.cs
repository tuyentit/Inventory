///************************************************
/// Generated by: TuyenNT
/// Date: 27/04/2014 11:50:13
/// Goal: Create Form for V_DM_HANG_HOA
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

using C1.Win.C1FlexGrid;
using BKI_KHO.DanhMuc;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using DevExpress.XtraEditors;

namespace BKI_KHO {



    public class f305_V_DM_HANG_HOA : System.Windows.Forms.Form {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Panel panel1;
        private Label m_lbl_tim_kiem;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private Label m_lbl_title;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private DevExpress.XtraEditors.SimpleButton m_cmd_update;
        private DevExpress.XtraEditors.SimpleButton m_cmd_insert;
        private DevExpress.XtraEditors.SimpleButton m_cmd_delete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn MA_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_HANG_VN;
        private DevExpress.XtraGrid.Columns.GridColumn GiA_NHAP;
        private DevExpress.XtraGrid.Columns.GridColumn GIA_BAN;
        private DevExpress.XtraGrid.Columns.GridColumn TRANG_THAI;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn ID_NHOM_CHA;
        private DevExpress.XtraGrid.Columns.GridColumn ID_TRANG_THAI;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.ComponentModel.IContainer components;

        public f305_V_DM_HANG_HOA() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f305_V_DM_HANG_HOA));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_delete = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_update = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_insert = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TEN_NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_HANG_VN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiA_NHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.GIA_BAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANG_THAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_NHOM_CHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID_TRANG_THAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 493);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(995, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_delete.Image")));
            this.m_cmd_delete.Location = new System.Drawing.Point(359, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(91, 28);
            this.m_cmd_delete.TabIndex = 45;
            this.m_cmd_delete.Text = "Xóa";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_update.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_update.Image")));
            this.m_cmd_update.Location = new System.Drawing.Point(274, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(85, 28);
            this.m_cmd_update.TabIndex = 44;
            this.m_cmd_update.Text = "Sửa";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_insert.Image")));
            this.m_cmd_insert.Location = new System.Drawing.Point(180, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(94, 28);
            this.m_cmd_insert.TabIndex = 43;
            this.m_cmd_insert.Text = "Thêm";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(92, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 24;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Visible = false;
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 88);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(995, 405);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 48);
            this.panel1.TabIndex = 56;
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(6, 17);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(88, 13);
            this.m_lbl_tim_kiem.TabIndex = 28;
            this.m_lbl_tim_kiem.Text = "Từ khoá tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.Color.Gray;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(122, 14);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(587, 20);
            this.m_txt_tim_kiem.TabIndex = 29;
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(734, 9);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(101, 28);
            this.m_cmd_search.TabIndex = 30;
            this.m_cmd_search.Text = "&Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(995, 40);
            this.m_lbl_title.TabIndex = 55;
            this.m_lbl_title.Text = "DANH MỤC MẶT HÀNG";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(995, 405);
            this.gridControl1.TabIndex = 57;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TEN_NHOM,
            this.MA_HANG,
            this.TEN_HANG_VN,
            this.GiA_NHAP,
            this.GIA_BAN,
            this.TRANG_THAI,
            this.ID,
            this.ID_NHOM,
            this.ID_NHOM_CHA,
            this.ID_TRANG_THAI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TEN_NHOM, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // TEN_NHOM
            // 
            this.TEN_NHOM.Caption = "Tên nhóm";
            this.TEN_NHOM.FieldName = "TEN_NHOM";
            this.TEN_NHOM.Name = "TEN_NHOM";
            this.TEN_NHOM.Visible = true;
            this.TEN_NHOM.VisibleIndex = 0;
            // 
            // MA_HANG
            // 
            this.MA_HANG.Caption = "Mã hàng";
            this.MA_HANG.FieldName = "MA_HANG";
            this.MA_HANG.Name = "MA_HANG";
            this.MA_HANG.Visible = true;
            this.MA_HANG.VisibleIndex = 0;
            this.MA_HANG.Width = 83;
            // 
            // TEN_HANG_VN
            // 
            this.TEN_HANG_VN.Caption = "Tên hàng";
            this.TEN_HANG_VN.FieldName = "TEN_HANG_VN";
            this.TEN_HANG_VN.Name = "TEN_HANG_VN";
            this.TEN_HANG_VN.Visible = true;
            this.TEN_HANG_VN.VisibleIndex = 1;
            // 
            // GiA_NHAP
            // 
            this.GiA_NHAP.Caption = "Giá nhập";
            this.GiA_NHAP.ColumnEdit = this.repositoryItemTextEdit1;
            this.GiA_NHAP.FieldName = "GiA_NHAP";
            this.GiA_NHAP.Name = "GiA_NHAP";
            this.GiA_NHAP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiA_NHAP", "{0:#,##0}")});
            this.GiA_NHAP.Visible = true;
            this.GiA_NHAP.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // GIA_BAN
            // 
            this.GIA_BAN.Caption = "Giá bán";
            this.GIA_BAN.ColumnEdit = this.repositoryItemTextEdit1;
            this.GIA_BAN.FieldName = "GIA_BAN";
            this.GIA_BAN.Name = "GIA_BAN";
            this.GIA_BAN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIA_BAN", "{0:#,###}")});
            this.GIA_BAN.Visible = true;
            this.GIA_BAN.VisibleIndex = 3;
            // 
            // TRANG_THAI
            // 
            this.TRANG_THAI.Caption = "Trạng thái";
            this.TRANG_THAI.FieldName = "TRANG_THAI";
            this.TRANG_THAI.Name = "TRANG_THAI";
            this.TRANG_THAI.Visible = true;
            this.TRANG_THAI.VisibleIndex = 4;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // ID_NHOM
            // 
            this.ID_NHOM.Caption = "ID_NHOM";
            this.ID_NHOM.FieldName = "ID_NHOM";
            this.ID_NHOM.Name = "ID_NHOM";
            // 
            // ID_NHOM_CHA
            // 
            this.ID_NHOM_CHA.Caption = "ID_NHOM_CHA";
            this.ID_NHOM_CHA.FieldName = "ID_NHOM_CHA";
            this.ID_NHOM_CHA.Name = "ID_NHOM_CHA";
            // 
            // ID_TRANG_THAI
            // 
            this.ID_TRANG_THAI.Caption = "ID_TRANG_THAI";
            this.ID_TRANG_THAI.FieldName = "ID_TRANG_THAI";
            this.ID_TRANG_THAI.Name = "ID_TRANG_THAI";
            // 
            // f305_V_DM_HANG_HOA
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(995, 529);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f305_V_DM_HANG_HOA";
            this.Text = "Quản lý danh sách mặt hàng";
            this.Load += new System.EventHandler(this.f305_V_DM_HANG_HOA_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            TEN_HANG_VN = 3
,
            GIA_BAN = 6
                ,
            MA_HANG = 2
                ,
            TEN_DON_VI = 4
                ,
            TEN_NHOM = 1
                ,
            GiA_NHAP = 5
                ,
            TRANG_THAI = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_HANG_HOA m_ds = new DS_V_DM_HANG_HOA();
        US_V_DM_HANG_HOA m_us = new US_V_DM_HANG_HOA();
        string m_str_message_tim_kiem = "Nhập vào thông tin muốn tìm kiếm...";
        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.MA_HANG;
            m_fg.Cols[(int)e_col_Number.TEN_NHOM].Visible = false;
            m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            CGridUtils.AddSearch_Handlers(m_fg);
            m_cmd_view.Visible = false;
            m_cmd_insert.Visible = false;
            //m_cmd_update.Visible = false;
            //m_cmd_delete.Visible = false;
            CGridUtils.MakeSoTTofRowNotIsNode(0, m_fg, true);
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg) {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_HANG_HOA.TEN_HANG_VN, e_col_Number.TEN_HANG_VN);
            v_htb.Add(V_DM_HANG_HOA.GIA_BAN, e_col_Number.GIA_BAN);
            v_htb.Add(V_DM_HANG_HOA.MA_HANG, e_col_Number.MA_HANG);
            v_htb.Add(V_DM_HANG_HOA.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_DM_HANG_HOA.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(V_DM_HANG_HOA.GiA_NHAP, e_col_Number.GiA_NHAP);
            v_htb.Add(V_DM_HANG_HOA.TRANG_THAI, e_col_Number.TRANG_THAI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_HANG_HOA.NewRow());
            return v_obj_trans;
        }

        private void grid_2_us_obj(DataRowView ip_dr) {
            m_us.dcGIA_BAN =CIPConvert.ToDecimal(ip_dr.Row.ItemArray[15].ToString());
            m_us.dcGiA_NHAP = CIPConvert.ToDecimal(ip_dr.Row.ItemArray[14].ToString());
            m_us.dcID = CIPConvert.ToDecimal(ip_dr.Row.ItemArray[0]);
            m_us.strTEN_HANG_VN = ip_dr.Row.ItemArray[10].ToString();
            m_us.strMA_HANG = ip_dr.Row.ItemArray[1].ToString();
            m_us.dcID_NHOM = CIPConvert.ToDecimal(ip_dr.Row.ItemArray[2].ToString());
            m_us.dcID_NHOM_CHA = CIPConvert.ToDecimal(ip_dr.Row.ItemArray[3].ToString());
            m_us.dcID_TRANG_THAI = CIPConvert.ToDecimal(ip_dr.Row.ItemArray[19]);
        }
        private void load_data_2_grid() {
            m_ds = new DS_V_DM_HANG_HOA();
            m_us.FillDataset(m_ds, "ORDER BY " + V_DM_HANG_HOA.TEN_NHOM);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);


            m_fg.Subtotal(
              AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
               , 0
               , (int)e_col_Number.TEN_NHOM // chỗ này là tên trường mà mình nhóm
               , (int)e_col_Number.MA_HANG // chỗ này là tên trường mà mình Count
               , "{0}");

            m_fg.Subtotal(
              AggregateEnum.Count
               , 0
               , (int)e_col_Number.TEN_NHOM
               , (int)e_col_Number.TEN_HANG_VN
               , "");

            m_fg.Redraw = true;

            gridControl1.DataSource = m_ds.V_DM_HANG_HOA;
            gridView1.ExpandAllGroups();
        }
        private void grid2us_object(US_V_DM_HANG_HOA i_us
            , int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_HANG_HOA i_us
            , int i_grid_row) {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_hang_hoa() {
            f305_V_DM_HANG_HOA_DE v_fDE = new f305_V_DM_HANG_HOA_DE();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_hang_hoa() {
            //if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
            //    return;
            //if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
            //    return;
            //if(m_fg.Rows[m_fg.Row].IsNode == true) {
            //    BaseMessages.MsgBox_Error("Không được sửa nhóm cha!");
            //    return;
            //}
            //grid2us_object(m_us, m_fg.Row);
            //f305_V_DM_HANG_HOA_DE v_fDE = new f305_V_DM_HANG_HOA_DE();
            //v_fDE.display_for_update(m_us);
            //load_data_2_grid();
        }

        private void delete_v_dm_hang_hoa() {
            if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;
            if(m_fg.Rows[m_fg.Row].IsNode == true) {
                BaseMessages.MsgBox_Error("Không được xóa nhóm cha!");
                return;
            }
            if(BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)
                return;
            US_V_DM_HANG_HOA v_us = new US_V_DM_HANG_HOA();
            grid2us_object(v_us, m_fg.Row);
            try {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                load_data_2_grid();
            }
            catch(Exception v_e) {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_hang_hoa() {
            if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;
            grid2us_object(m_us, m_fg.Row);
            //	f305_V_DM_HANG_HOA_DE v_fDE = new f305_V_DM_HANG_HOA_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f305_V_DM_HANG_HOA_Load(object sender, System.EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                insert_v_dm_hang_hoa();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e) {
            try {
                update_v_dm_hang_hoa();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e) {
            try {
                delete_v_dm_hang_hoa();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e) {
            try {
                view_v_dm_hang_hoa();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e) {
            try {
                if(m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                    load_data_2_grid();
                else
                    load_data_2_grid_search();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void load_data_2_grid_search() {
            m_obj_trans = get_trans_object(m_fg);
            m_ds.Clear();
            m_us.FillDatasetSearch(m_ds, m_txt_tim_kiem.Text.Trim());
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(
              AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
               , 0
               , (int)e_col_Number.TEN_NHOM // chỗ này là tên trường mà mình nhóm
               , (int)e_col_Number.MA_HANG // chỗ này là tên trường mà mình Count
               , "{0}");
            m_fg.Redraw = true;

        }
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e) {
            try {
                if(e.KeyData == Keys.Enter) {
                    load_data_2_grid_search();

                }
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e) {
            try {
                m_txt_tim_kiem.Text = "";
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {
            try {
                var row = e.Row;
                var isNew = gridView1.IsNewItemRow(e.RowHandle);

                if(row!= null) {
                    
                }
            }
            catch(Exception v_e) {
                
                throw v_e;
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            try {
                grid_2_us_obj((DataRowView)e.Row);
                m_us.Update();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}

