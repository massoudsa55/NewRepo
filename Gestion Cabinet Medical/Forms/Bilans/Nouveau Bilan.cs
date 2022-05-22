using DevExpress.XtraEditors;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    public partial class Nouveau_Bilan : XtraForm
    {
        public int _ID_FA;
        public int _ID_Aanalyse;
        DAL.Analyse _Analyse;
        public string EditOrAdd;
        public Nouveau_Bilan()
        {
            InitializeComponent();
        }

        private void Nouveau_Bilan_Load(object sender, EventArgs e)
        {
            
            switch (EditOrAdd)
            {
                case "New":
                    {
                        analyseBindingSource.DataSource = new DAL.Analyse();
                        LoadAnalyseFamily();
                    }
                    break;
                case "Edit":
                    LoadAnalyseFamilyForEdit();
                    break;
                default:
                    break;
            }
            lkp_FamAnalyse.EditValueChanged += Lkp_FamAnalyse_EditValueChanged;
            btn_Annuler.Click += Btn_Annuler_Click;
            btn_Valid.Click += Btn_Valid_Click;
        }

        private void LoadAnalyseFamilyForEdit()
        {
            LoadAnalyseFamily();
            using (DAL.Database db = new DAL.Database())
            {
                var query = db.Analyse.Single(a => a.ID_Analyse == _ID_Aanalyse);
                analyseBindingSource.DataSource = query;
                lkp_FamAnalyse.EditValue = db.FamAnalyse.Single(a => a.ID_FA == query.ID_FA).Categorie;
            }
        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {
            if (!IsDataValide())
                return;
            switch (EditOrAdd)
            {
                case "New":
                    Save();
                    break;
                case "Edit":
                    Edit();
                    break;
                default:
                    break;
            }
            
        }

        private async void Edit()
        {
            using (DAL.Database db = new DAL.Database())
            {
                _Analyse.Nome = txt_NameAnalyse.Text;
                _Analyse.Prix = (double?)txt_PrixAnalyse.EditValue ?? null;
                _Analyse.ID_FA = db.FamAnalyse.First(a => a.Categorie == lkp_FamAnalyse.EditValue.ToString()).ID_FA;
                db.Entry(_Analyse).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            MessageBox.Show("Edited Succesffuly", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private async void Save()
        {
            using (DAL.Database db = new DAL.Database())
            {
                _Analyse = new DAL.Analyse()
                {
                    Nome = txt_NameAnalyse.Text,
                    Prix = (double?)txt_PrixAnalyse.EditValue ?? null,
                    ID_FA = _ID_FA
                };
                db.Analyse.Add(_Analyse);
                await db.SaveChangesAsync();
            }
            XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lkp_FamAnalyse_EditValueChanged(object sender, EventArgs e)
        {
            using (DAL.Database db = new DAL.Database())
                _ID_FA = db.FamAnalyse.Single(a => a.Categorie == lkp_FamAnalyse.EditValue.ToString()).ID_FA;
        }

        async void LoadAnalyseFamily()
        {
            analyseBindingSource.DataSource = new DAL.Analyse();
            using (DAL.Database db = new DAL.Database())
            {
                await db.FamAnalyse.LoadAsync();
                var query = db.FamAnalyse.Select(a => a.Categorie);
                lkp_FamAnalyse.Properties.DataSource = query.ToList();
            }
        }

        public bool IsDataValide()
        {
            int NumberOfErrors = 0;
            NumberOfErrors += Master.IsTextValide(txt_NameAnalyse) ? 0 : 1;
            NumberOfErrors += Master.IsEditValueValide(lkp_FamAnalyse) ? 0 : 1;
            return (NumberOfErrors == 0);
        }
    }
}