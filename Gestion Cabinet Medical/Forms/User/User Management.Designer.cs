namespace Gestion_Cabinet_Medical.Forms.User
{
    partial class User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            this.colID_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TypeUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Colse = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.user_list = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_DBDataSet = new Gestion_Cabinet_Medical.Medical_DBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_User1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TypeUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreation1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersTableAdapter = new Gestion_Cabinet_Medical.Medical_DBDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colID_User
            // 
            this.colID_User.Name = "colID_User";
            // 
            // colFirstName
            // 
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            this.colLastName.Name = "colLastName";
            // 
            // colPassword
            // 
            this.colPassword.Name = "colPassword";
            // 
            // colID_TypeUser
            // 
            this.colID_TypeUser.Name = "colID_TypeUser";
            // 
            // colSalary
            // 
            this.colSalary.Name = "colSalary";
            // 
            // colDateCreation
            // 
            this.colDateCreation.Name = "colDateCreation";
            // 
            // colEmail
            // 
            this.colEmail.Name = "colEmail";
            // 
            // colAdresse
            // 
            this.colAdresse.Name = "colAdresse";
            // 
            // colPhone
            // 
            this.colPhone.Name = "colPhone";
            // 
            // colImage
            // 
            this.colImage.Name = "colImage";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(400, 400);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Add,
            this.btn_Edit,
            this.btn_Delete,
            this.btn_Refresh,
            this.btn_Colse});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(899, 570);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Edit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Delete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Colse, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Add";
            this.btn_Add.Id = 0;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.LargeImage")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Add_ItemClick);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Caption = "Edit";
            this.btn_Edit.Id = 1;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.LargeImage")));
            this.btn_Edit.Name = "btn_Edit";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Delete";
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.LargeImage")));
            this.btn_Delete.Name = "btn_Delete";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Caption = "Refresh";
            this.btn_Refresh.Id = 3;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.LargeImage")));
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Refresh_ItemClick);
            // 
            // btn_Colse
            // 
            this.btn_Colse.Caption = "Close";
            this.btn_Colse.Id = 4;
            this.btn_Colse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Colse.ImageOptions.Image")));
            this.btn_Colse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Colse.ImageOptions.LargeImage")));
            this.btn_Colse.Name = "btn_Colse";
            this.btn_Colse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Colse_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // user_list
            // 
            this.user_list.DataSource = this.usersBindingSource;
            this.user_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_list.Location = new System.Drawing.Point(0, 31);
            this.user_list.MainView = this.gridView1;
            this.user_list.Name = "user_list";
            this.user_list.Size = new System.Drawing.Size(800, 396);
            this.user_list.TabIndex = 4;
            this.user_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.medical_DBDataSet;
            // 
            // medical_DBDataSet
            // 
            this.medical_DBDataSet.DataSetName = "Medical_DBDataSet";
            this.medical_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_User1,
            this.colFirstName1,
            this.colLastName1,
            this.colPassword1,
            this.colID_TypeUser1,
            this.colSalary1,
            this.colDateCreation1,
            this.colEmail1,
            this.colAdresse1,
            this.colPhone1,
            this.colImage1});
            this.gridView1.GridControl = this.user_list;
            this.gridView1.Name = "gridView1";
            // 
            // colID_User1
            // 
            this.colID_User1.FieldName = "ID_User";
            this.colID_User1.Name = "colID_User1";
            this.colID_User1.Visible = true;
            this.colID_User1.VisibleIndex = 0;
            // 
            // colFirstName1
            // 
            this.colFirstName1.FieldName = "FirstName";
            this.colFirstName1.Name = "colFirstName1";
            this.colFirstName1.Visible = true;
            this.colFirstName1.VisibleIndex = 1;
            // 
            // colLastName1
            // 
            this.colLastName1.FieldName = "LastName";
            this.colLastName1.Name = "colLastName1";
            this.colLastName1.Visible = true;
            this.colLastName1.VisibleIndex = 2;
            // 
            // colPassword1
            // 
            this.colPassword1.FieldName = "Password";
            this.colPassword1.Name = "colPassword1";
            this.colPassword1.Visible = true;
            this.colPassword1.VisibleIndex = 3;
            // 
            // colID_TypeUser1
            // 
            this.colID_TypeUser1.FieldName = "ID_TypeUser";
            this.colID_TypeUser1.Name = "colID_TypeUser1";
            this.colID_TypeUser1.Visible = true;
            this.colID_TypeUser1.VisibleIndex = 4;
            // 
            // colSalary1
            // 
            this.colSalary1.FieldName = "Salary";
            this.colSalary1.Name = "colSalary1";
            this.colSalary1.Visible = true;
            this.colSalary1.VisibleIndex = 5;
            // 
            // colDateCreation1
            // 
            this.colDateCreation1.FieldName = "DateCreation";
            this.colDateCreation1.Name = "colDateCreation1";
            this.colDateCreation1.Visible = true;
            this.colDateCreation1.VisibleIndex = 6;
            // 
            // colEmail1
            // 
            this.colEmail1.FieldName = "Email";
            this.colEmail1.Name = "colEmail1";
            this.colEmail1.Visible = true;
            this.colEmail1.VisibleIndex = 7;
            // 
            // colAdresse1
            // 
            this.colAdresse1.FieldName = "Adresse";
            this.colAdresse1.Name = "colAdresse1";
            this.colAdresse1.Visible = true;
            this.colAdresse1.VisibleIndex = 8;
            // 
            // colPhone1
            // 
            this.colPhone1.FieldName = "Phone";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 9;
            // 
            // colImage1
            // 
            this.colImage1.FieldName = "Image";
            this.colImage1.Name = "colImage1";
            this.colImage1.Visible = true;
            this.colImage1.VisibleIndex = 10;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_list);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("User_Management.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.User_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colID_User;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TypeUser;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarButtonItem btn_Colse;
        private DevExpress.XtraGrid.GridControl user_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_User1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TypeUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreation1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage1;
        private Medical_DBDataSet medical_DBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Medical_DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}