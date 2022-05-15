using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class Fiche_Bilan : XtraForm
    {
        public int _ID_Patient = 3;
        public int _ID_Consultation;
        public int _ID_FA;
        DAL.Patient patient;
        public Fiche_Bilan()
        {
            InitializeComponent();
        }

        private void Fiche_Bilan_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            LoadTypeBilan();
            GetBilanSelected();
            GetBilanForPatientAdd();
            LoadConsultation(_ID_Patient);
            EditableGridControl();
            //LoadPatientInfo(_ID_Patient);
            #region Evants Button Click
            btn_AddBialnSelected.Click += All_Buttons_Clicks;
            btn_BilanStandard.Click += All_Buttons_Clicks;
            btn_Cancel.Click += All_Buttons_Clicks;
            btn_DeleteBilan.Click += All_Buttons_Clicks;
            btn_EditBilan.Click += All_Buttons_Clicks;
            btn_NewBilan.Click += All_Buttons_Clicks;
            btn_ToutBilans.Click += All_Buttons_Clicks;
            btn_Valid.Click += All_Buttons_Clicks;
            #endregion
            #region RepositoryItem
            RepositoryItemCheckEdit repoItemCheckBilan = new RepositoryItemCheckEdit();
            gridControl_ForSelect.RepositoryItems.Add(repoItemCheckBilan);
            gridView_ForSelect.Columns["Action"].ColumnEdit = repoItemCheckBilan;
            repoItemCheckBilan.CheckedChanged += RepoItemCheckBilan_CheckedChanged;
            #endregion
            gridView_ForSelect.Columns["Action"].UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            gridView_ForSelect.OptionsSelection.MultiSelect = true;
            gridView_ForSelect.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView_ForSelect.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;


        }

        public void code()
        {
            /*void repchkCheckbox_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
            {
                DataTable dt_check = new DataTable();
                dt_check = (DataTable)gridControl_ForSelect.DataSource;
                Int64 sItemId = Convert.ToInt64(gridControl_ForSelect.GetRowCellValue(gridControl_ForSelect.FocusedRowHandle, gridControl_ForSelect.Columns["ItemID"]));
                bool bDiscount = Convert.ToBoolean(e.Value);
                int iItemcount = (from DataRow row in dt_check.Rows where (string)row["ItemID"] == "1" select row).Count();
                int iRowHandle = gridControl_ForSelect.FocusedRowHandle;
                for (int i = 0; i < iItemcount; i++)
                {
                    if (bDiscount)
                        gridControl_ForSelect.SetRowCellValue(iRowHandle, gridControl_ForSelect.Columns["AllowDiscount"], true);
                    else
                        gridControl_ForSelect.SetRowCellValue(iRowHandle, gridControl_ForSelect.Columns["AllowDiscount"], false);

                    iRowHandle++;
                }
            }

            Int64 iItemId = Convert.ToInt64(gridControl_ForSelect.GetRowCellValue(e.RowHandle, "ItemID"));
            bool bDiscount = Convert.ToBoolean(e.Value);

            for (int i = 0; i < gridControl_ForSelect.DataRowCount; i++)
            {
                Int64 id = Convert.ToInt64(gridControl_ForSelect.GetRowCellValue(i, "ItemID"));
                if (id == iItemId)
                {
                    if (bDiscount)
                        gridControl_ForSelect.SetRowCellValue(i, gridControl_ForSelect.Columns["" + sColumn.Replace(" ", "") + ""], true);
                    else
                        gridControl_ForSelect.SetRowCellValue(i, gridControl_ForSelect.Columns["" + sColumn.Replace(" ", "") + ""], false);
                }
            }*/
        }

        private void RepoItemCheckBilan_CheckedChanged(object sender, EventArgs e)
        {
            //XtraMessageBox.Show("Bilan selected");
        }

        private void EditableGridControl()
        {
            gridView_ForSelect.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView_ForSelect.Columns.ColumnByName("gridColumn1").FieldName = "Action";
            gridView_ForSelect.Columns["Action"].OptionsColumn.AllowEdit = true;
            gridView_ForSelect.Columns["Nome"].OptionsColumn.AllowEdit = false;
        }

        public void All_Buttons_Clicks(object sender, EventArgs e)
        {
            if (sender is SimpleButton sendBTN && sendBTN != null) 
                switch (sendBTN.Name)
                {
                    case "btn_AddBialnSelected":
                        LoadBilanSelected();
                        break;
                    case "btn_BilanStandard":
                        LoadBilanStandard();
                        break;
                    case "btn_Cancel":
                        Close();
                        break;
                    case "btn_DeleteBilan":
                        DeleteBilan();
                        break;
                    case "btn_EditBilan":
                        EditBilan();
                        break;
                    case "btn_NewBilan":
                        NewBilan();
                        break;
                    case "btn_ToutBilans":
                        LoadToutBilans();
                        break;
                    case "btn_Valid":
                        Save();
                        break;
                    default:
                        break;
                }
        }

        private void LoadBilanSelected()
        {
            gridControl_ForSelect.DataSource = null;
            GetIdFamAnalyse();
            using (DAL.Database db = new DAL.Database())
            {
                var bilanSelected = db.Analyse.Select(a => a.ID_FA == _ID_FA).ToList();
                gridControl_ForSelect.DataSource = bilanSelected;
            }
        }

        private void LoadBilanStandard()
        {
            gridControl_ForSelect.DataSource = null;
            using (DAL.Database db = new DAL.Database())
            {
                var bilanStandard = from standarBilan in db.Bilans
                                    join analyse in db.Analyse on standarBilan.ID_Analyse equals analyse.ID_Analyse
                                    into a
                                    from analyse in a.DefaultIfEmpty()
                                    where standarBilan.ID_Cat_Bilans == 1
                                    select new
                                    {
                                        standarBilan.ID_Analyse,
                                        analyse.Nome
                                    };
                gridControl_ForSelect.DataSource = bilanStandard.ToList();
            }
        }

        private void LoadToutBilans()
        {
            gridControl_ForSelect.DataSource = null;
            using (DAL.Database db = new DAL.Database())
            {
                var toutBilan = from evryBilan in db.Analyse
                                select new 
                                { 
                                    evryBilan.ID_Analyse,
                                    evryBilan.Nome
                                };
                gridControl_ForSelect.DataSource = toutBilan.ToList();
            }
        }

        private void NewBilan()
        {
        }

        private void EditBilan()
        {
        }

        private void DeleteBilan()
        {
        }

        private void Save()
        {
        }

        private void LoadPatientInfo(int iD_Patient)
        {
            using (DAL.Database db = new DAL.Database())
            {

                patient = db.Patient.First(a => a.ID_Patient == _ID_Patient);
                if (patient == null)
                    return;
                label_NomPrenom.Text = patient.Nom + " " + patient.Prenom;
                layoutControlGroup_PatientInfo.Text = patient.Nom + " " + patient.Prenom;
                if (patient.Image != null)
                    pic_ImagePatient.Image = Master.GetImageFromByteArray(patient.Image);
                label_NumbreConsultation.Text = db.Consultations.Count(a => a.ID_Patient == _ID_Patient).ToString();
                if (db.Attende.Any(a => a.ID_Patient == _ID_Patient))
                    label_SalleAttente.Text = "Oui";
                else
                    label_SalleAttente.Text = "Non";
            }
        }

        public void LoadConsultation(int iD_Patient)
        {
            using (DAL.Database db = new DAL.Database())
            {


                var query = from consult in db.Consultations
                            join motifs in db.Motifs on consult.ID_Motifs equals motifs.ID_Motifs
                            into m
                            from motifs in m.DefaultIfEmpty()
                            where consult.ID_Patient == iD_Patient
                            select new
                            {
                                consult.DateTime,
                                Motifs = motifs.Libelle,
                            };
                lkp_Consultation.Properties.DataSource = query.ToList();
            }
        }

        public void GetBilanForPatientAdd()
        {
        }

        public void GetBilanSelected()
        {
            
        }

        public void GetIdFamAnalyse()
        {
            if (lkp_TypeBilan.EditValue != null && lkp_TypeBilan.Text != string.Empty)
            {
                using (DAL.Database db = new DAL.Database())
                {
                    var id_FamAnalyse = (int?)db.FamAnalyse.First(a => a.Categorie == lkp_TypeBilan.Text).ID_FA ?? 0;
                    if (id_FamAnalyse > 0)
                        _ID_FA = id_FamAnalyse;
                }
            }
        }

        public void LoadTypeBilan()
        {
            using (DAL.Database db = new DAL.Database())
            {
                var query = from famAnalayse in Master.db.FamAnalyse
                            select new
                            {
                                famAnalayse.ID_FA,
                                famAnalayse.Categorie
                            };
                lkp_TypeBilan.Properties.DataSource = query.ToList();
                lkp_TypeBilan.Properties.ValueMember = nameof(DAL.FamAnalyse.ID_FA);
                lkp_TypeBilan.Properties.DisplayMember = nameof(DAL.FamAnalyse.Categorie);
            }
        }
    }
}
