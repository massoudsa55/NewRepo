using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Consultation
{
    public partial class Consultation_Management : XtraForm
    {
        public Consultation_Management()
        {
            InitializeComponent();
        }

        private void Consultation_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medical_DBDataSet.Consultations' table. You can move, or remove it, as needed.
            this.consultationsTableAdapter.Fill(this.medical_DBDataSet.Consultations);

        }
    }
}
