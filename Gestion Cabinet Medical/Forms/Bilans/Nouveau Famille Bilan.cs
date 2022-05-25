using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    public partial class Neauvou_Famille_Bilan : DevExpress.XtraEditors.XtraForm
    {
        public int _ID_FA;
        DAL.FamAnalyse _FamAnalyse;
        public Neauvou_Famille_Bilan()
        {
            InitializeComponent();
        }

        private void Neauvou_Famille_Bilan_Load(object sender, EventArgs e)
        {
            #region Evants Buttons click
            btn_Annuler.Click += Btn_Annuler_Click;
            btn_Valid.Click += Btn_Valid_Click;
            #endregion
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            Save();
        }

        private void Save()
        {
            using (DAL.Database db = new DAL.Database())
            {
                if (db.FamAnalyse.Any(a => a.Categorie == txt_FamAnalyse.Text))
                {
                    XtraMessageBox.Show($"Le catégorie '{txt_FamAnalyse.Text}' il existe déjà !, S'il vous plait changer", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    _FamAnalyse = new DAL.FamAnalyse
                    {
                        Categorie = txt_FamAnalyse.Text
                    };
                    db.FamAnalyse.Add(_FamAnalyse);
                    db.SaveChanges();
                }
            }
            XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }        

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool IsDataValide()
        {
            int NumberOfErrors = 0;
            NumberOfErrors += Master.IsTextValide(txt_FamAnalyse) ? 0 : 1;
            return (NumberOfErrors == 0);
        }
    }
}