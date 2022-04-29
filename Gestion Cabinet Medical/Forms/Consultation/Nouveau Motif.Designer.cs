
namespace Gestion_Cabinet_Medical.Forms.Consultation
{
    partial class Nouveau_Motif
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txt_LibelleMotif = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_AdreviationMotif = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Annuler = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Valid = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LibelleMotif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AdreviationMotif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_AdreviationMotif);
            this.layoutControl1.Controls.Add(this.txt_LibelleMotif);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(408, 134);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(408, 134);
            this.Root.TextVisible = false;
            // 
            // txt_LibelleMotif
            // 
            this.txt_LibelleMotif.Location = new System.Drawing.Point(171, 50);
            this.txt_LibelleMotif.Name = "txt_LibelleMotif";
            this.txt_LibelleMotif.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txt_LibelleMotif.Properties.Appearance.Options.UseFont = true;
            this.txt_LibelleMotif.Size = new System.Drawing.Size(213, 28);
            this.txt_LibelleMotif.StyleController = this.layoutControl1;
            this.txt_LibelleMotif.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txt_LibelleMotif;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(364, 32);
            this.layoutControlItem1.Text = "Libelle de motif";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(143, 21);
            // 
            // txt_AdreviationMotif
            // 
            this.txt_AdreviationMotif.Location = new System.Drawing.Point(171, 82);
            this.txt_AdreviationMotif.Name = "txt_AdreviationMotif";
            this.txt_AdreviationMotif.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txt_AdreviationMotif.Properties.Appearance.Options.UseFont = true;
            this.txt_AdreviationMotif.Size = new System.Drawing.Size(213, 28);
            this.txt_AdreviationMotif.StyleController = this.layoutControl1;
            this.txt_AdreviationMotif.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txt_AdreviationMotif;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(364, 32);
            this.layoutControlItem2.Text = "Adreviation de motif";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(143, 21);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(141)))));
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(388, 114);
            this.layoutControlGroup1.Text = "Motifs";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Annuler);
            this.panelControl1.Controls.Add(this.btn_Valid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 130);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(408, 64);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.AllowFocus = false;
            this.btn_Annuler.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(143)))));
            this.btn_Annuler.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Annuler.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.btn_Annuler.Appearance.Options.UseBackColor = true;
            this.btn_Annuler.Appearance.Options.UseFont = true;
            this.btn_Annuler.Appearance.Options.UseForeColor = true;
            this.btn_Annuler.ImageOptions.Image = global::Gestion_Cabinet_Medical.Properties.Resources.cancel_32px;
            this.btn_Annuler.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_Annuler.Location = new System.Drawing.Point(208, 11);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(190, 42);
            this.btn_Annuler.TabIndex = 1;
            this.btn_Annuler.Text = "Annuler   (Esc)       ";
            // 
            // btn_Valid
            // 
            this.btn_Valid.AllowFocus = false;
            this.btn_Valid.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(141)))));
            this.btn_Valid.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Valid.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.btn_Valid.Appearance.Options.UseBackColor = true;
            this.btn_Valid.Appearance.Options.UseFont = true;
            this.btn_Valid.Appearance.Options.UseForeColor = true;
            this.btn_Valid.ImageOptions.Image = global::Gestion_Cabinet_Medical.Properties.Resources.Confirm_32px;
            this.btn_Valid.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_Valid.Location = new System.Drawing.Point(12, 11);
            this.btn_Valid.Name = "btn_Valid";
            this.btn_Valid.Size = new System.Drawing.Size(190, 42);
            this.btn_Valid.TabIndex = 0;
            this.btn_Valid.Text = "Valider   (F1)           ";
            // 
            // Nouveau_Motif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 194);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Nouveau_Motif";
            this.Text = "Nouveau_Motif";
            this.Load += new System.EventHandler(this.Nouveau_Motif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LibelleMotif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AdreviationMotif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txt_AdreviationMotif;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Annuler;
        private DevExpress.XtraEditors.SimpleButton btn_Valid;
        public DevExpress.XtraEditors.TextEdit txt_LibelleMotif;
    }
}