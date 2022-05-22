using System;
using System.Linq;

namespace Gestion_Cabinet_Medical.Forms.User
{
    public partial class User_Management : DevExpress.XtraEditors.XtraForm
    {
        public User_Management()
        {
            InitializeComponent();
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        public void LoadUser()
        {
            user_list.DataSource = Functions.Master.db.Users.ToList();
        }

        private void Btn_Colse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void Btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadUser();
        }

        private void Btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add_User user = new Add_User();
            user.Show();
        }
    }
}
