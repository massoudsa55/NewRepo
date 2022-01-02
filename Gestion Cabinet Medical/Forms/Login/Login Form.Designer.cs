using Bunifu.Framework.UI;

namespace Gestion_Cabinet_Medical.Forms.Login
{
    partial class Login_Form
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCopyright = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForgotPass = new DevExpress.XtraEditors.SimpleButton();
            this.checkForginPass = new DevExpress.XtraEditors.CheckEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lkp_Username = new DevExpress.XtraEditors.LookUpEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picExit = new DevExpress.XtraEditors.PictureEdit();
            this.btnHidePassword = new DevExpress.XtraEditors.PictureEdit();
            this.btnShowPassword = new DevExpress.XtraEditors.PictureEdit();
            this.lignUserName = new System.Windows.Forms.TextBox();
            this.pic_UserName = new DevExpress.XtraEditors.PictureEdit();
            this.pic_Password = new DevExpress.XtraEditors.PictureEdit();
            this.lignUserType = new System.Windows.Forms.TextBox();
            this.pic_UserType = new DevExpress.XtraEditors.PictureEdit();
            this.lignPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_UserType = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkForginPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserType.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Gestion_Cabinet_Medical.Properties.Resources.pexels_anna_shvets_3786157;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtCopyright);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 381);
            this.panel3.TabIndex = 0;
            // 
            // txtCopyright
            // 
            this.txtCopyright.AutoSize = true;
            this.txtCopyright.BackColor = System.Drawing.Color.Transparent;
            this.txtCopyright.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyright.Location = new System.Drawing.Point(122, 358);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(119, 21);
            this.txtCopyright.TabIndex = 2;
            this.txtCopyright.Text = "All Copyright ©";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cabinet Medical";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnForgotPass);
            this.panel1.Controls.Add(this.checkForginPass);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lkp_Username);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.picExit);
            this.panel1.Controls.Add(this.btnHidePassword);
            this.panel1.Controls.Add(this.btnShowPassword);
            this.panel1.Controls.Add(this.lignUserName);
            this.panel1.Controls.Add(this.pic_UserName);
            this.panel1.Controls.Add(this.pic_Password);
            this.panel1.Controls.Add(this.lignUserType);
            this.panel1.Controls.Add(this.pic_UserType);
            this.panel1.Controls.Add(this.lignPassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_UserType);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 381);
            this.panel1.TabIndex = 0;
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btnForgotPass.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.btnForgotPass.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnForgotPass.Appearance.Options.UseBackColor = true;
            this.btnForgotPass.Appearance.Options.UseBorderColor = true;
            this.btnForgotPass.Appearance.Options.UseFont = true;
            this.btnForgotPass.ImageOptions.Image = global::Gestion_Cabinet_Medical.Properties.Resources.authentication_32px;
            this.btnForgotPass.Location = new System.Drawing.Point(51, 311);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(286, 48);
            this.btnForgotPass.TabIndex = 4;
            this.btnForgotPass.Text = "Envoyer SMS";
            this.btnForgotPass.ToolTip = "Enoyez votre mot de passe par SMS";
            this.btnForgotPass.Visible = false;
            // 
            // checkForginPass
            // 
            this.checkForginPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkForginPass.Location = new System.Drawing.Point(201, 274);
            this.checkForginPass.Name = "checkForginPass";
            this.checkForginPass.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForginPass.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.checkForginPass.Properties.Appearance.Options.UseFont = true;
            this.checkForginPass.Properties.Appearance.Options.UseForeColor = true;
            this.checkForginPass.Properties.Caption = "Mot de passe oublié";
            this.checkForginPass.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgCheckBox1;
            this.checkForginPass.Properties.CheckBoxOptions.SvgColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.checkForginPass.Properties.CheckBoxOptions.SvgColorGrayed = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkForginPass.Properties.CheckBoxOptions.SvgColorUnchecked = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.checkForginPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkForginPass.Size = new System.Drawing.Size(136, 22);
            this.checkForginPass.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseBorderColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.btnLogin.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.AppearanceHovered.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.AppearanceHovered.Options.UseBackColor = true;
            this.btnLogin.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLogin.AppearanceHovered.Options.UseFont = true;
            this.btnLogin.AppearanceHovered.Options.UseForeColor = true;
            this.btnLogin.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.btnLogin.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.btnLogin.AppearancePressed.Options.UseBackColor = true;
            this.btnLogin.AppearancePressed.Options.UseBorderColor = true;
            this.btnLogin.AppearancePressed.Options.UseFont = true;
            this.btnLogin.AppearancePressed.Options.UseForeColor = true;
            this.btnLogin.ImageOptions.Image = global::Gestion_Cabinet_Medical.Properties.Resources.icons8_key_32px;
            this.btnLogin.Location = new System.Drawing.Point(51, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(286, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Connectez-vous";
            this.btnLogin.ToolTip = "Connectez-vous";
            // 
            // lkp_Username
            // 
            this.lkp_Username.Location = new System.Drawing.Point(82, 133);
            this.lkp_Username.Name = "lkp_Username";
            this.lkp_Username.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.lkp_Username.Properties.Appearance.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkp_Username.Properties.Appearance.Options.UseBackColor = true;
            this.lkp_Username.Properties.Appearance.Options.UseFont = true;
            this.lkp_Username.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.lkp_Username.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkp_Username.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.lkp_Username.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.lkp_Username.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lkp_Username.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.lkp_Username.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            serializableAppearanceObject1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject1.FontStyleDelta = System.Drawing.FontStyle.Bold;
            serializableAppearanceObject1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject1.Options.UseForeColor = true;
            this.lkp_Username.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.lkp_Username.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lkp_Username.Properties.NullText = "Nom Utilisateur";
            this.lkp_Username.Size = new System.Drawing.Size(255, 28);
            this.lkp_Username.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.panel5.Location = new System.Drawing.Point(187, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 4);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.panel4.Location = new System.Drawing.Point(182, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 4);
            this.panel4.TabIndex = 9;
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.EditValue = global::Gestion_Cabinet_Medical.Properties.Resources.close_32px;
            this.picExit.Location = new System.Drawing.Point(343, -1);
            this.picExit.Name = "picExit";
            this.picExit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.picExit.Properties.Appearance.Options.UseBackColor = true;
            this.picExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picExit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picExit.Size = new System.Drawing.Size(34, 26);
            this.picExit.TabIndex = 18;
            this.picExit.ToolTip = "Exit";
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.EditValue = ((object)(resources.GetObject("btnHidePassword.EditValue")));
            this.btnHidePassword.Location = new System.Drawing.Point(312, 188);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.btnHidePassword.Properties.Appearance.Options.UseBackColor = true;
            this.btnHidePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnHidePassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnHidePassword.Size = new System.Drawing.Size(25, 22);
            this.btnHidePassword.TabIndex = 17;
            this.btnHidePassword.ToolTip = "Hide Password";
            this.btnHidePassword.Visible = false;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.EditValue = ((object)(resources.GetObject("btnShowPassword.EditValue")));
            this.btnShowPassword.Location = new System.Drawing.Point(312, 188);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.btnShowPassword.Properties.Appearance.Options.UseBackColor = true;
            this.btnShowPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnShowPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btnShowPassword.Size = new System.Drawing.Size(25, 22);
            this.btnShowPassword.TabIndex = 16;
            this.btnShowPassword.ToolTip = "Show Password";
            // 
            // lignUserName
            // 
            this.lignUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lignUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lignUserName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lignUserName.Location = new System.Drawing.Point(51, 164);
            this.lignUserName.Multiline = true;
            this.lignUserName.Name = "lignUserName";
            this.lignUserName.Size = new System.Drawing.Size(286, 2);
            this.lignUserName.TabIndex = 15;
            // 
            // pic_UserName
            // 
            this.pic_UserName.EditValue = ((object)(resources.GetObject("pic_UserName.EditValue")));
            this.pic_UserName.Location = new System.Drawing.Point(51, 136);
            this.pic_UserName.Name = "pic_UserName";
            this.pic_UserName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.pic_UserName.Properties.Appearance.Options.UseBackColor = true;
            this.pic_UserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_UserName.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_UserName.Size = new System.Drawing.Size(25, 22);
            this.pic_UserName.TabIndex = 14;
            // 
            // pic_Password
            // 
            this.pic_Password.EditValue = ((object)(resources.GetObject("pic_Password.EditValue")));
            this.pic_Password.Location = new System.Drawing.Point(51, 188);
            this.pic_Password.Name = "pic_Password";
            this.pic_Password.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.pic_Password.Properties.Appearance.Options.UseBackColor = true;
            this.pic_Password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_Password.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Password.Size = new System.Drawing.Size(25, 22);
            this.pic_Password.TabIndex = 13;
            // 
            // lignUserType
            // 
            this.lignUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lignUserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lignUserType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lignUserType.Location = new System.Drawing.Point(51, 266);
            this.lignUserType.Multiline = true;
            this.lignUserType.Name = "lignUserType";
            this.lignUserType.Size = new System.Drawing.Size(286, 2);
            this.lignUserType.TabIndex = 12;
            // 
            // pic_UserType
            // 
            this.pic_UserType.EditValue = ((object)(resources.GetObject("pic_UserType.EditValue")));
            this.pic_UserType.Location = new System.Drawing.Point(51, 240);
            this.pic_UserType.Name = "pic_UserType";
            this.pic_UserType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.pic_UserType.Properties.Appearance.Options.UseBackColor = true;
            this.pic_UserType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_UserType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_UserType.Size = new System.Drawing.Size(25, 22);
            this.pic_UserType.TabIndex = 11;
            // 
            // lignPassword
            // 
            this.lignPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.lignPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lignPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lignPassword.Location = new System.Drawing.Point(51, 216);
            this.lignPassword.Multiline = true;
            this.lignPassword.Name = "lignPassword";
            this.lignPassword.Size = new System.Drawing.Size(286, 2);
            this.lignPassword.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(107)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(172, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 4);
            this.panel2.TabIndex = 8;
            // 
            // txt_UserType
            // 
            this.txt_UserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.txt_UserType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_UserType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_UserType.Location = new System.Drawing.Point(82, 240);
            this.txt_UserType.Name = "txt_UserType";
            this.txt_UserType.ReadOnly = true;
            this.txt_UserType.Size = new System.Drawing.Size(255, 22);
            this.txt_UserType.TabIndex = 2;
            this.txt_UserType.Text = "Utilisateur";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(82, 188);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(255, 22);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Text = "Password";
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(304, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 387);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.59538F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 387);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(687, 387);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 387);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 387);
            this.Name = "Login_Form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkForginPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkp_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserType.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtCopyright;
        private System.Windows.Forms.Label label2;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit picExit;
        private DevExpress.XtraEditors.PictureEdit btnHidePassword;
        private DevExpress.XtraEditors.PictureEdit btnShowPassword;
        private System.Windows.Forms.TextBox lignUserName;
        private DevExpress.XtraEditors.PictureEdit pic_UserName;
        private DevExpress.XtraEditors.PictureEdit pic_Password;
        private System.Windows.Forms.TextBox lignUserType;
        private DevExpress.XtraEditors.PictureEdit pic_UserType;
        private System.Windows.Forms.TextBox lignPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_UserType;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LookUpEdit lkp_Username;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.CheckEdit checkForginPass;
        private DevExpress.XtraEditors.SimpleButton btnForgotPass;
    }
}