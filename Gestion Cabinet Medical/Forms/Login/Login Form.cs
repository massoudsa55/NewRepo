using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Login
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            txtCopyright.Text = "All Copyright © " + DateTime.Now.Year;
            GetData();
            picExit.Click += PicExit_Click;
            lkp_Username.MouseHover += Send_MouseHover;
            lkp_Username.MouseLeave += Send_MouseLeave;
            txt_Password.MouseHover += Send_MouseHover;
            txt_Password.MouseLeave += Send_MouseLeave;
            txt_UserType.MouseHover += Send_MouseHover;
            txt_UserType.MouseLeave += Send_MouseLeave;
            pic_UserName.MouseHover += Send_MouseHover;
            pic_UserName.MouseLeave += Send_MouseLeave;
            pic_Password.MouseHover += Send_MouseHover;
            pic_Password.MouseLeave += Send_MouseLeave;
            pic_UserType.MouseHover += Send_MouseHover;
            pic_UserType.MouseLeave += Send_MouseLeave;
            lkp_Username.Enter += Send_MouseHover;
            lkp_Username.Leave += Send_MouseLeave;
            txt_Password.Enter += Send_MouseHover;
            txt_Password.Leave += Send_MouseLeave;
            txt_UserType.Enter += Send_MouseHover;
            txt_UserType.Leave += Send_MouseLeave;
            lkp_Username.EditValueChanged += Lkp_Username_EditValueChanged;
            lkp_Username.KeyDown += Function_KeyDown;
            txt_Password.KeyDown += Function_KeyDown;
            btnHidePassword.Click += BtnShowOrHidePassword_Click;
            btnShowPassword.Click += BtnShowOrHidePassword_Click;
            btnLogin.KeyDown += Function_KeyDown;
            btnLogin.Click += BtnLogin_Click;
            checkForginPass.CheckedChanged += CheckForginPass_CheckedChanged;
            btnForgotPass.Click += BtnForgotPass_Click;
        }

        private void BtnShowOrHidePassword_Click(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.PictureEdit sendPIC)
            {
                switch (sendPIC.Name)
                {
                    case "btnHidePassword":
                        {
                            txt_Password.UseSystemPasswordChar = true;
                            btnHidePassword.Visible = false;
                            btnShowPassword.Visible = true;
                        }
                        break;
                    case "btnShowPassword":
                        {
                            txt_Password.UseSystemPasswordChar = false;
                            btnShowPassword.Visible = false;
                            btnHidePassword.Visible = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void BtnForgotPass_Click(object sender, EventArgs e)
        {
            string phone;
            if (lkp_Username.EditValue != null || lkp_Username.Text != lkp_Username.Properties.NullText)
            {
                phone = Functions.Master.db.Users.First(a => a.FirstName == lkp_Username.Text).Phone;
                if (phone == string.Empty)
                    return;
                else
                {
                    MessageBox.Show("Your phone number is " + phone, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Select your name please !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CheckForginPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkForginPass.Checked)
                btnForgotPass.Visible = true;
            else
                btnForgotPass.Visible = false;
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (lkp_Username.Text == string.Empty || txt_Password.Text == string.Empty)
            {
                if (lkp_Username.Text == string.Empty)
                    MessageBox.Show("Please Enter your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if (txt_Password.Text == string.Empty)
                    MessageBox.Show("Please Enter your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Functions.Master.db.Users.Any(a => a.FirstName == lkp_Username.Text && a.Password == txt_Password.Text))
                {
                    Properties.Settings.Default.LoginUsername = lkp_Username.Text;
                    Hide();
                    Principale_Form.Principal_Form frmPRS = new Principale_Form.Principal_Form();
                    frmPRS.Show();
                }
                else
                    MessageBox.Show("Login Failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Function_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                if (sender is TextBox sendTXT)
                {
                    switch (sendTXT.Name)
                    {
                        case "txt_Password":
                            {
                                switch (e.KeyCode)
                                {
                                    case Keys.Enter:
                                        if (checkForginPass.Checked)
                                            BtnForgotPass_Click(null, null);
                                        else
                                            BtnLogin_Click(null, null);
                                        break;
                                    case Keys.Up:
                                        lkp_Username.Focus();
                                        break;
                                    case Keys.Down:
                                        if (checkForginPass.Checked)
                                            btnForgotPass.Focus();
                                        else
                                            btnLogin.Focus();
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case "txt_UserType":
                            {
                                switch (e.KeyCode)
                                {
                                    case Keys.Enter:
                                        if (checkForginPass.Checked)
                                            BtnForgotPass_Click(null, null);
                                        else
                                            BtnLogin_Click(null, null);
                                        break;
                                    case Keys.Up:
                                        txt_Password.Focus();
                                        break;
                                    case Keys.Down:
                                        if (checkForginPass.Checked)
                                            btnForgotPass.Focus();
                                        else
                                            btnLogin.Focus();
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    if (sender is DevExpress.XtraEditors.LookUpEdit)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.Enter:
                                txt_Password.Focus();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        /*if (sender is Bunifu.Framework.UI.BunifuThinButton2)
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.Enter:
                                    if (checkForginPass.Checked)
                                        BtnForgotPass_Click(null, null);
                                    else
                                        BtnLogin_Click(null, null);
                                    break;
                                case Keys.Up:
                                    txt_Password.Focus();
                                    break;
                                default:
                                    break;
                            }
                        }*/
                    }
                }
            }
        }

        private void Lkp_Username_EditValueChanged(object sender, EventArgs e)
        {
            string typeUser;
            if (lkp_Username.EditValue != null && lkp_Username.Text != string.Empty)
            {
                var userType = (int?)Functions.Master.db.Users.First(a => a.FirstName == lkp_Username.Text).ID_TypeUser ?? 0;
                if (userType > 0)
                {
                    typeUser = Functions.Master.db.TypeUser.First(a => a.ID_TypeUser == userType).Type;
                    if (typeUser != string.Empty)
                        txt_UserType.Text = typeUser;
                }
            }
        }

        private void GetData()
        {
            var user = Functions.Master.db.Users.Select(e => e.FirstName).ToList();
            lkp_Username.Properties.DataSource = user;
        }

        private void Send_MouseHover(object sender, EventArgs e)
        {
            if (sender is TextBox sendTXT)
            {
                switch (sendTXT.Name)
                {
                    case "txt_Password":
                        lignPassword.BackColor = Color.FromArgb(61, 107, 179);
                        txt_Password.Focus();
                        txt_Password.SelectAll();
                        break;
                    case "txt_UserType":
                        lignUserType.BackColor = Color.FromArgb(61, 107, 179);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (sender is DevExpress.XtraEditors.LookUpEdit)
                    lignUserName.BackColor = Color.FromArgb(61, 107, 179);
                else
                {
                    if (sender is DevExpress.XtraEditors.PictureEdit sendPIC)
                    {
                        switch (sendPIC.Name)
                        {
                            case "pic_UserName":
                                lignUserName.BackColor = Color.FromArgb(61, 107, 179);
                                break;
                            case "pic_Password":
                                lignPassword.BackColor = Color.FromArgb(61, 107, 179);
                                txt_Password.Focus();
                                txt_Password.SelectAll();
                                break;
                            case "pic_UserType":
                                lignUserType.BackColor = Color.FromArgb(61, 107, 179);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        private void Send_MouseLeave(object sender, EventArgs e)
        {
            if (sender is TextBox sendTXT)
            {
                switch (sendTXT.Name)
                {
                    case "txt_Password":
                        lignPassword.BackColor = Color.FromArgb(32, 31, 53);
                        txt_Password.DeselectAll();
                        break;
                    case "txt_UserType":
                        lignUserType.BackColor = Color.FromArgb(32, 31, 53);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (sender is DevExpress.XtraEditors.LookUpEdit)
                    lignUserName.BackColor = Color.FromArgb(32, 31, 53);
                else
                {
                    if (sender is DevExpress.XtraEditors.PictureEdit sendPIC)
                    {
                        switch (sendPIC.Name)
                        {
                            case "pic_UserName":
                                lignUserName.BackColor = Color.FromArgb(32, 31, 53);
                                break;
                            case "pic_Password":
                                lignPassword.BackColor = Color.FromArgb(32, 31, 53);
                                txt_Password.DeselectAll();
                                break;
                            case "pic_UserType":
                                lignUserType.BackColor = Color.FromArgb(32, 31, 53);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
