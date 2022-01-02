namespace Gestion_Cabinet_Medical.Forms.Patient
{
    partial class Patient_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Management));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Export = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_DBDataSet = new Gestion_Cabinet_Medical.Medical_DBDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Patient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrenom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Sexe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Civilite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_GroupeSanguin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_SF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Daira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.patientTableAdapter = new Gestion_Cabinet_Medical.Medical_DBDataSetTableAdapters.PatientTableAdapter();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_Export,
            this.btn_Exit,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Export),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Ajouter";
            this.btn_Add.Id = 0;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.LargeImage")));
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Caption = "Modifier";
            this.btn_Edit.Id = 1;
            this.btn_Edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.Image")));
            this.btn_Edit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ImageOptions.LargeImage")));
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Caption = "Supprimier";
            this.btn_Delete.Id = 2;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.LargeImage")));
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Caption = "Actualiser";
            this.btn_Refresh.Id = 3;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.LargeImage")));
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Export
            // 
            this.btn_Export.Caption = "Exporter";
            this.btn_Export.Id = 4;
            this.btn_Export.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.Image")));
            this.btn_Export.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.LargeImage")));
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "Close";
            this.btn_Exit.Id = 5;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.LargeImage")));
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.FloatLocation = new System.Drawing.Point(997, 728);
            this.bar2.Offset = 345;
            this.bar2.Text = "Tools";
            this.bar2.Visible = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(919, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 422);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(919, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Excel";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "PDF";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.patientBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(919, 398);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.medical_DBDataSet;
            // 
            // medical_DBDataSet
            // 
            this.medical_DBDataSet.DataSetName = "Medical_DBDataSet";
            this.medical_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Patient,
            this.colCode,
            this.colNom,
            this.colPrenom,
            this.colFileDe,
            this.colDOB,
            this.colAge,
            this.colID_Sexe,
            this.colID_Civilite,
            this.colID_GroupeSanguin,
            this.colID_SF,
            this.colPhone1,
            this.colPhone2,
            this.colEmail,
            this.colImage,
            this.colAddress,
            this.colID_Daira,
            this.colProfession,
            this.colNote,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID_Patient
            // 
            this.colID_Patient.FieldName = "ID_Patient";
            this.colID_Patient.Name = "colID_Patient";
            this.colID_Patient.Width = 41;
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Options.UseTextOptions = true;
            this.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 41;
            // 
            // colNom
            // 
            this.colNom.AppearanceCell.Options.UseTextOptions = true;
            this.colNom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 41;
            // 
            // colPrenom
            // 
            this.colPrenom.AppearanceCell.Options.UseTextOptions = true;
            this.colPrenom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrenom.FieldName = "Prenom";
            this.colPrenom.Name = "colPrenom";
            this.colPrenom.Visible = true;
            this.colPrenom.VisibleIndex = 2;
            this.colPrenom.Width = 41;
            // 
            // colFileDe
            // 
            this.colFileDe.FieldName = "FileDe";
            this.colFileDe.Name = "colFileDe";
            this.colFileDe.Width = 41;
            // 
            // colDOB
            // 
            this.colDOB.FieldName = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.Visible = true;
            this.colDOB.VisibleIndex = 3;
            this.colDOB.Width = 41;
            // 
            // colAge
            // 
            this.colAge.AppearanceCell.Options.UseTextOptions = true;
            this.colAge.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 4;
            this.colAge.Width = 41;
            // 
            // colID_Sexe
            // 
            this.colID_Sexe.AppearanceCell.Options.UseTextOptions = true;
            this.colID_Sexe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID_Sexe.Caption = "Sexe";
            this.colID_Sexe.FieldName = "ID_Sexe";
            this.colID_Sexe.Name = "colID_Sexe";
            this.colID_Sexe.Visible = true;
            this.colID_Sexe.VisibleIndex = 5;
            this.colID_Sexe.Width = 41;
            // 
            // colID_Civilite
            // 
            this.colID_Civilite.AppearanceCell.Options.UseTextOptions = true;
            this.colID_Civilite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID_Civilite.Caption = "Civilité";
            this.colID_Civilite.FieldName = "ID_Civilite";
            this.colID_Civilite.Name = "colID_Civilite";
            this.colID_Civilite.Visible = true;
            this.colID_Civilite.VisibleIndex = 6;
            this.colID_Civilite.Width = 41;
            // 
            // colID_GroupeSanguin
            // 
            this.colID_GroupeSanguin.AppearanceCell.Options.UseTextOptions = true;
            this.colID_GroupeSanguin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID_GroupeSanguin.Caption = "Groupe Sanguin";
            this.colID_GroupeSanguin.FieldName = "ID_GroupeSanguin";
            this.colID_GroupeSanguin.Name = "colID_GroupeSanguin";
            this.colID_GroupeSanguin.Visible = true;
            this.colID_GroupeSanguin.VisibleIndex = 7;
            this.colID_GroupeSanguin.Width = 41;
            // 
            // colID_SF
            // 
            this.colID_SF.AppearanceCell.Options.UseTextOptions = true;
            this.colID_SF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colID_SF.Caption = "Situation Fam";
            this.colID_SF.FieldName = "ID_SF";
            this.colID_SF.Name = "colID_SF";
            this.colID_SF.Visible = true;
            this.colID_SF.VisibleIndex = 8;
            this.colID_SF.Width = 41;
            // 
            // colPhone1
            // 
            this.colPhone1.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 9;
            this.colPhone1.Width = 41;
            // 
            // colPhone2
            // 
            this.colPhone2.AppearanceCell.Options.UseTextOptions = true;
            this.colPhone2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 10;
            this.colPhone2.Width = 41;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 11;
            this.colEmail.Width = 41;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Width = 41;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 12;
            this.colAddress.Width = 40;
            // 
            // colID_Daira
            // 
            this.colID_Daira.FieldName = "ID_Daira";
            this.colID_Daira.Name = "colID_Daira";
            this.colID_Daira.Width = 41;
            // 
            // colProfession
            // 
            this.colProfession.AppearanceCell.Options.UseTextOptions = true;
            this.colProfession.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProfession.FieldName = "Profession";
            this.colProfession.Name = "colProfession";
            this.colProfession.Visible = true;
            this.colProfession.VisibleIndex = 13;
            this.colProfession.Width = 41;
            // 
            // colNote
            // 
            this.colNote.AppearanceCell.Options.UseTextOptions = true;
            this.colNote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 14;
            this.colNote.Width = 45;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.Caption = "Daira";
            this.gridColumn1.FieldName = "ID_Daira";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.FieldName = "ID_GroupeSanguin";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 41;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.FieldName = "ID_GroupeSanguin";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 41;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.FieldName = "ID_GroupeSanguin";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 41;
            // 
            // Patient_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 445);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Patient_Management";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Management";
            this.Load += new System.EventHandler(this.Patient_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraBars.BarButtonItem btn_Edit;
        private DevExpress.XtraBars.BarButtonItem btn_Delete;
        private DevExpress.XtraBars.BarButtonItem btn_Refresh;
        private DevExpress.XtraBars.BarButtonItem btn_Export;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Medical_DBDataSet medical_DBDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Medical_DBDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Patient;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colPrenom;
        private DevExpress.XtraGrid.Columns.GridColumn colFileDe;
        private DevExpress.XtraGrid.Columns.GridColumn colDOB;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Sexe;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Civilite;
        private DevExpress.XtraGrid.Columns.GridColumn colID_GroupeSanguin;
        private DevExpress.XtraGrid.Columns.GridColumn colID_SF;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Daira;
        private DevExpress.XtraGrid.Columns.GridColumn colProfession;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}