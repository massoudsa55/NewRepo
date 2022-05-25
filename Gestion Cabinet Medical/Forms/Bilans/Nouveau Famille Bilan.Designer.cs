
namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    partial class Neauvou_Famille_Bilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Neauvou_Famille_Bilan));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btn_Annuler = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Valid = new DevExpress.XtraEditors.SimpleButton();
            this.analyseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_DBDataSet = new Gestion_Cabinet_Medical.Medical_DBDataSet();
            this.txt_FamAnalyse = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.analyseTableAdapter = new Gestion_Cabinet_Medical.Medical_DBDataSetTableAdapters.AnalyseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FamAnalyse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(418, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(414, 54);
            this.panelControl2.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nirmala UI", 17F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(8, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(258, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nouveau Famille Bilan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(135)))), ((int)(((byte)(12)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 5);
            this.panel1.TabIndex = 2;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btn_Annuler);
            this.dataLayoutControl1.Controls.Add(this.btn_Valid);
            this.dataLayoutControl1.Controls.Add(this.txt_FamAnalyse);
            this.dataLayoutControl1.DataSource = this.analyseBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 58);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(418, 91);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.AllowFocus = false;
            this.btn_Annuler.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Annuler.Appearance.Options.UseFont = true;
            this.btn_Annuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Annuler.ImageOptions.Image")));
            this.btn_Annuler.Location = new System.Drawing.Point(211, 45);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(200, 38);
            this.btn_Annuler.StyleController = this.dataLayoutControl1;
            this.btn_Annuler.TabIndex = 7;
            this.btn_Annuler.Text = "Annuler";
            // 
            // btn_Valid
            // 
            this.btn_Valid.AllowFocus = false;
            this.btn_Valid.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Valid.Appearance.Options.UseFont = true;
            this.btn_Valid.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Valid.ImageOptions.Image")));
            this.btn_Valid.Location = new System.Drawing.Point(7, 45);
            this.btn_Valid.Name = "btn_Valid";
            this.btn_Valid.Size = new System.Drawing.Size(200, 38);
            this.btn_Valid.StyleController = this.dataLayoutControl1;
            this.btn_Valid.TabIndex = 6;
            this.btn_Valid.Text = "Valider";
            // 
            // analyseBindingSource
            // 
            this.analyseBindingSource.DataMember = "Analyse";
            this.analyseBindingSource.DataSource = this.medical_DBDataSet;
            // 
            // medical_DBDataSet
            // 
            this.medical_DBDataSet.DataSetName = "Medical_DBDataSet";
            this.medical_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_FamAnalyse
            // 
            this.txt_FamAnalyse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analyseBindingSource, "ID_FA", true));
            this.txt_FamAnalyse.Location = new System.Drawing.Point(94, 12);
            this.txt_FamAnalyse.Name = "txt_FamAnalyse";
            this.txt_FamAnalyse.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_FamAnalyse.Properties.Appearance.Options.UseFont = true;
            this.txt_FamAnalyse.Size = new System.Drawing.Size(312, 24);
            this.txt_FamAnalyse.StyleController = this.dataLayoutControl1;
            this.txt_FamAnalyse.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(418, 91);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_FamAnalyse;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(408, 38);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "Nome famille";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(78, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_Valid;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(204, 43);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_Annuler;
            this.layoutControlItem4.Location = new System.Drawing.Point(204, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(204, 43);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // analyseTableAdapter
            // 
            this.analyseTableAdapter.ClearBeforeFill = true;
            // 
            // Neauvou_Famille_Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 149);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Neauvou_Famille_Bilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neauvou_Famille_Bilan";
            this.Load += new System.EventHandler(this.Neauvou_Famille_Bilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FamAnalyse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_Annuler;
        private DevExpress.XtraEditors.SimpleButton btn_Valid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private Medical_DBDataSet medical_DBDataSet;
        private System.Windows.Forms.BindingSource analyseBindingSource;
        private Medical_DBDataSetTableAdapters.AnalyseTableAdapter analyseTableAdapter;
        public DevExpress.XtraEditors.TextEdit txt_FamAnalyse;
    }
}