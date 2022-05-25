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
    public partial class Nouveau_Type_Bilan : XtraForm
    {
        public int _ID_Cat_Bilans;
        public int _ID_Bilan;
        DAL.Bilans _Bilans;
        DAL.BilansCategories _BilansCategories;
        public Nouveau_Type_Bilan()
        {
            InitializeComponent();
        }

        private void Nouveau_Type_Bilan_Load(object sender, EventArgs e)
        {
            EditableGridControl();
            LoadAnalyse();
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
            if (IsBilanCategoryExist())
            {
                XtraMessageBox.Show($"Le catégorie '{txt_BilanCategory.Text}' il existe déjà !, S'il vous plait changer", "msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (IsAnyRowNotSelected())
                {
                    if (XtraMessageBox.Show("Vous n'avez sélectionné aucun Bilan ! \n Est ce que vous continuez pour enregistrer cet catégorie du bilan sans Bilans ?", "msg", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SaveNewBilanCategory();
                        XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        return;

                }
                else
                {
                    SaveNewBilanCategory();
                    GetLastIdOfBilanCategory();
                    SelectBilansForNewBilanCategory();
                    XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        bool IsBilanCategoryExist()
        {
            using (DAL.Database db = new DAL.Database())
            {
                return db.BilansCategories.Any(a => a.Libelle == txt_BilanCategory.Text);
            }
        }

        bool IsAnyRowNotSelected()
        {
            bool IsNotSelected = true;
            for (int i = 0; i < gridView1.DataRowCount; i++)
                if (gridView1.IsRowSelected(i))
                    IsNotSelected = false;
            return IsNotSelected;
        }
        void SaveNewBilanCategory()
        {
            using (DAL.Database db = new DAL.Database())
            {
                _BilansCategories = new DAL.BilansCategories
                {
                    Libelle = txt_BilanCategory.Text,
                    Raccourcis = txt_Raccourcis.Text
                };
                db.BilansCategories.Add(_BilansCategories);
                db.SaveChanges();
            }
        }

        void GetLastIdOfBilanCategory()
        {
            using (DAL.Database db = new DAL.Database())
            {
                _ID_Cat_Bilans = db.BilansCategories.Select(a => a.ID_Cat_Bilans).Max();
            }
        }

        void SelectBilansForNewBilanCategory()
        {
            if (gridView1.RowCount == 0)
                return;
            using (DAL.Database db = new DAL.Database())
            {
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    if (gridView1.IsRowSelected(i))
                    {
                        var idAnalyse = (int)gridView1.GetRowCellValue(i, gridView1.Columns[nameof(DAL.Analyse.ID_Analyse)]);
                        if (idAnalyse != 0)
                        {
                            _Bilans = new DAL.Bilans
                            {
                                ID_Cat_Bilans = _ID_Cat_Bilans,
                                ID_Analyse = idAnalyse
                            };
                            db.Bilans.Add(_Bilans);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void EditableGridControl()
        {
            gridView1.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        }

        public void LoadAnalyse()
        {
            using (DAL.Database db = new DAL.Database())
            {
                gridControl1.DataSource = db.Analyse.ToList();
            }
        }

        public bool IsDataValide()
        {
            int NumberOfErrors = 0;
            NumberOfErrors += Master.IsTextValide(txt_BilanCategory) ? 0 : 1;
            return (NumberOfErrors == 0);
        }
    }
}