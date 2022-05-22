
namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    partial class Nouveau_Bilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nouveau_Bilan));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lkp_FamAnalyse = new DevExpress.XtraEditors.LookUpEdit();
            this.analyseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_DBDataSet = new Gestion_Cabinet_Medical.Medical_DBDataSet();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Annuler = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Valid = new DevExpress.XtraEditors.SimpleButton();
            this.txt_NameAnalyse = new DevExpress.XtraEditors.TextEdit();
            this.txt_PrixAnalyse = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrix = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.analyseTableAdapter = new Gestion_Cabinet_Medical.Medical_DBDataSetTableAdapters.AnalyseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_FamAnalyse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameAnalyse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PrixAnalyse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.lkp_FamAnalyse);
            this.dataLayoutControl1.Controls.Add(this.panelControl1);
            this.dataLayoutControl1.Controls.Add(this.btn_Annuler);
            this.dataLayoutControl1.Controls.Add(this.btn_Valid);
            this.dataLayoutControl1.Controls.Add(this.txt_NameAnalyse);
            this.dataLayoutControl1.Controls.Add(this.txt_PrixAnalyse);
            this.dataLayoutControl1.DataSource = this.analyseBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(649, 0, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(379, 160);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // lkp_FamAnalyse
            // 
            this.lkp_FamAnalyse.Location = new System.Drawing.Point(46, 106);
            this.lkp_FamAnalyse.Name = "lkp_FamAnalyse";
            this.lkp_FamAnalyse.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lkp_FamAnalyse.Properties.Appearance.Options.UseFont = true;
            this.lkp_FamAnalyse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkp_FamAnalyse.Properties.NullText = "";
            this.lkp_FamAnalyse.Size = new System.Drawing.Size(331, 24);
            this.lkp_FamAnalyse.StyleController = this.dataLayoutControl1;
            this.lkp_FamAnalyse.TabIndex = 10;
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
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(172)))), ((int)(((byte)(217)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(379, 46);
            this.panelControl1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(274, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.labelControl1.Size = new System.Drawing.Size(242, 27);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nouveau Bilan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(135)))), ((int)(((byte)(12)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 5);
            this.panel1.TabIndex = 2;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.AllowFocus = false;
            this.btn_Annuler.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Annuler.Appearance.Options.UseFont = true;
            this.btn_Annuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Annuler.ImageOptions.Image")));
            this.btn_Annuler.Location = new System.Drawing.Point(190, 134);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(187, 24);
            this.btn_Annuler.StyleController = this.dataLayoutControl1;
            this.btn_Annuler.TabIndex = 8;
            this.btn_Annuler.Text = "Annuler";
            // 
            // btn_Valid
            // 
            this.btn_Valid.AllowFocus = false;
            this.btn_Valid.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Valid.Appearance.Options.UseFont = true;
            this.btn_Valid.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Valid.ImageOptions.Image")));
            this.btn_Valid.Location = new System.Drawing.Point(2, 134);
            this.btn_Valid.Name = "btn_Valid";
            this.btn_Valid.Size = new System.Drawing.Size(184, 24);
            this.btn_Valid.StyleController = this.dataLayoutControl1;
            this.btn_Valid.TabIndex = 7;
            this.btn_Valid.Text = "Valider";
            // 
            // txt_NameAnalyse
            // 
            this.txt_NameAnalyse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analyseBindingSource, "Nome", true));
            this.txt_NameAnalyse.Location = new System.Drawing.Point(46, 50);
            this.txt_NameAnalyse.Name = "txt_NameAnalyse";
            this.txt_NameAnalyse.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_NameAnalyse.Properties.Appearance.Options.UseFont = true;
            this.txt_NameAnalyse.Size = new System.Drawing.Size(331, 24);
            this.txt_NameAnalyse.StyleController = this.dataLayoutControl1;
            this.txt_NameAnalyse.TabIndex = 4;
            // 
            // txt_PrixAnalyse
            // 
            this.txt_PrixAnalyse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analyseBindingSource, "Prix", true));
            this.txt_PrixAnalyse.Location = new System.Drawing.Point(46, 78);
            this.txt_PrixAnalyse.Name = "txt_PrixAnalyse";
            this.txt_PrixAnalyse.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_PrixAnalyse.Properties.Appearance.Options.UseFont = true;
            this.txt_PrixAnalyse.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_PrixAnalyse.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_PrixAnalyse.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_PrixAnalyse.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_PrixAnalyse.Properties.MaskSettings.Set("mask", "F");
            this.txt_PrixAnalyse.Size = new System.Drawing.Size(331, 24);
            this.txt_PrixAnalyse.StyleController = this.dataLayoutControl1;
            this.txt_PrixAnalyse.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(379, 160);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNome,
            this.ItemForPrix,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(379, 160);
            // 
            // ItemForNome
            // 
            this.ItemForNome.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ItemForNome.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForNome.Control = this.txt_NameAnalyse;
            this.ItemForNome.Location = new System.Drawing.Point(0, 48);
            this.ItemForNome.Name = "ItemForNome";
            this.ItemForNome.Size = new System.Drawing.Size(379, 28);
            this.ItemForNome.Text = "Nome";
            this.ItemForNome.TextSize = new System.Drawing.Size(40, 17);
            // 
            // ItemForPrix
            // 
            this.ItemForPrix.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ItemForPrix.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForPrix.Control = this.txt_PrixAnalyse;
            this.ItemForPrix.Location = new System.Drawing.Point(0, 76);
            this.ItemForPrix.Name = "ItemForPrix";
            this.ItemForPrix.Size = new System.Drawing.Size(379, 28);
            this.ItemForPrix.Text = "Prix";
            this.ItemForPrix.TextSize = new System.Drawing.Size(40, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btn_Valid;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 132);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_Annuler;
            this.layoutControlItem2.Location = new System.Drawing.Point(188, 132);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(191, 28);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.panelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(379, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.lkp_FamAnalyse;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(379, 28);
            this.layoutControlItem4.Text = "Famille";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 17);
            // 
            // analyseTableAdapter
            // 
            this.analyseTableAdapter.ClearBeforeFill = true;
            // 
            // Nouveau_Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 160);
            this.Controls.Add(this.dataLayoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nouveau_Bilan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau_Bilan";
            this.Load += new System.EventHandler(this.Nouveau_Bilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkp_FamAnalyse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameAnalyse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PrixAnalyse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Medical_DBDataSet medical_DBDataSet;
        private System.Windows.Forms.BindingSource analyseBindingSource;
        private Medical_DBDataSetTableAdapters.AnalyseTableAdapter analyseTableAdapter;
        private DevExpress.XtraEditors.TextEdit txt_NameAnalyse;
        private DevExpress.XtraEditors.TextEdit txt_PrixAnalyse;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrix;
        private DevExpress.XtraEditors.SimpleButton btn_Annuler;
        private DevExpress.XtraEditors.SimpleButton btn_Valid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit lkp_FamAnalyse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}