using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class Fiche_Bilan : XtraForm
    {
        public int _ID_Patient = 3;
        public int _ID_Consultation;
        public int _ID_FA;
        public int _ID_BilanCatigoty;
        DAL.Patient patient;
        public Fiche_Bilan()
        {
            InitializeComponent();
        }

        private void Fiche_Bilan_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now.Date;
            LoadFamBilan();
            LoadTypeBilan();
            GetBilanSelected();
            GetBilanForPatientAdd();
            LoadConsultation(_ID_Patient);
            EditableGridControl();
            LoadPatientInfo(_ID_Patient);
            //gridView_ForSelect.OptionsSelection.CheckBoxSelectorField = "Actin"; // Field name

            RepositoryItemCheckEdit edit = new RepositoryItemCheckEdit(); // Your editor
            // Obtaining the column and changing its editor
            var checkColumn = gridView_ForSelect.VisibleColumns[0];
            checkColumn.ColumnEdit = edit;

            gridView_ForSelect.SelectionChanged += GridView_ForSelect_SelectionChanged;
            gridView_ForSelect.MasterRowExpanded += GridView_ForSelect_MasterRowExpanded;

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
            //RepositoryItemCheckEdit repoItemCheckBilan = new RepositoryItemCheckEdit();
            //repoItemCheckBilan.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            //repoItemCheckBilan.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard;
            //repoItemCheckBilan.ValueChecked = true;
            //repoItemCheckBilan.ValueUnchecked = false;
            //gridControl_ForSelect.RepositoryItems.Add(repoItemCheckBilan);
            //gridView_ForSelect.Columns["Action"].ColumnEdit = repoItemCheckBilan;
            //repoItemCheckBilan.QueryCheckStateByValue += RepoItemCheckBilan_QueryCheckStateByValue;
            //repoItemCheckBilan.CheckedChanged += RepoItemCheckBilan_CheckedChanged;
            #endregion
            lkp_FamBilan.EditValueChanged += Lkp_FamBilan_EditValueChanged;
            lkp_TypeBilan.EditValueChanged += Lkp_TypeBilan_EditValueChanged;
        }

        private void GridView_ForSelect_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            UpdateSelection(e.RowHandle);
        }

        private void GridView_ForSelect_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridView_ForSelect.IsDetailView)
            {
                int masterRowHandle = gridView_ForSelect.SourceRowHandle;
                if (gridView_ForSelect.GetSelectedRows().Length == gridView_ForSelect.RowCount)
                    (gridView_ForSelect.ParentView as GridView).SelectRow(masterRowHandle);
                else 
                if (gridView_ForSelect.GetSelectedRows().Length == 0)
                    (gridView_ForSelect.ParentView as GridView).UnselectRow(masterRowHandle);
            }
            if (gridView_ForSelect.IsMasterRow(e.ControllerRow) || e.ControllerRow == GridControl.InvalidRowHandle)
                UpdateSelection(e.ControllerRow);
            if (e.Action == CollectionChangeAction.Refresh)
                foreach (BaseView baseView in gridView_ForSelect.GridControl.Views)
                {
                    int masterRowHandle = baseView.SourceRowHandle;
                    UpdateSelection(masterRowHandle);
                }
            /*if (gridView_ForSelect.GetFocusedRowCellValue(nameof(DAL.Analyse.ID_Analyse)) == null) return;
            var id = int.Parse(gridView_ForSelect.GetFocusedRowCellValue(nameof(DAL.Analyse.ID_Analyse)).ToString());
            if (id != 0)
            XtraMessageBox.Show("ID_Analyse : " + id);*/
        }

        private void UpdateSelection(int controllerRow)
        {
            GridView view = gridView_ForSelect.GetDetailView(controllerRow, 0) as GridView;
            if (view != null)
                if (gridView_ForSelect.IsRowSelected(controllerRow))
                    view.SelectAll();
                else
                    view.ClearSelection();
        }

        private void RepoItemCheckBilan_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            if (e.Value == null)
            {
                e.CheckState = CheckState.Unchecked;
                e.Handled = true;
            }
        }

        private void Lkp_TypeBilan_EditValueChanged(object sender, EventArgs e)
        {
            GetIdBilanCatigory();
            gridControl_ForSelect.DataSource = null;
            using (DAL.Database db = new DAL.Database())
            {
                var checkedBilanCatigory = sender as DAL.BilansCategories;

                var getBilanOfChckedType = from analyse in db.Analyse
                                           join bilan in db.Bilans on analyse.ID_Analyse 
                                           equals bilan.ID_Analyse
                                           join bilanCatigotry in db.BilansCategories on bilan.ID_Cat_Bilans 
                                           equals bilanCatigotry.ID_Cat_Bilans
                                           where bilanCatigotry.ID_Cat_Bilans == _ID_BilanCatigoty
                                           select new
                                           {
                                               analyse.ID_Analyse,
                                               analyse.Nome
                                           };
                gridControl_ForSelect.DataSource = getBilanOfChckedType.ToList();
            }
        }

        private void Lkp_FamBilan_EditValueChanged(object sender, EventArgs e)
        {
            GetIdFamAnalyse();
            gridControl_ForSelect.DataSource = null;
            using (DAL.Database db = new DAL.Database())
            {
                var checkedFamAnalyse = sender as DAL.FamAnalyse;

                var getBilanOfChckedType = from analyse in db.Analyse
                                           join famAnalyse in db.FamAnalyse on analyse.ID_FA equals famAnalyse.ID_FA
                                           where analyse.ID_FA == _ID_FA
                                           select new
                                           {
                                               analyse.ID_Analyse,
                                               analyse.Nome
                                           };
                gridControl_ForSelect.DataSource = getBilanOfChckedType.ToList();
            }
        }

        private void RepoItemCheckBilan_CheckedChanged(object sender, EventArgs e)
        {
           /* var obj = sender as CheckEdit;
            if (obj.Tag != null)
            {
                obj.Checked = true;
                repoItemCheckBilan.Enabled = false;
            }
            else
            {
                if (obj.Checked)
                {
                    obj.Tag = true;
                    repositoryItemCheckEdit1.Enabled = false;
                }
            }*/

        }

        private void EditableGridControl()
        {
            gridView_ForSelect.OptionsBehavior.Editable = false;
            gridView_ForSelect.OptionsSelection.MultiSelect = true;
            gridView_ForSelect.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView_ForSelect.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            //gridView_ForSelect.Columns.ColumnByName("gridColumn1").FieldName = "Action";
            //gridView_ForSelect.Columns["Action"].OptionsColumn.AllowEdit = true;
            //gridView_ForSelect.Columns["Nome"].OptionsColumn.AllowEdit = false;


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
            /*gridControl_ForSelect.DataSource = null;
            GetIdFamAnalyse();
            using (DAL.Database db = new DAL.Database())
            {
                var bilanSelected = db.Analyse.Select(a => a.ID_FA == _ID_FA).ToList();
                gridControl_ForSelect.DataSource = bilanSelected;
            }*/
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
            if (lkp_FamBilan.EditValue != null && lkp_FamBilan.Text != string.Empty)
            {
                using (DAL.Database db = new DAL.Database())
                {
                    var id_FamAnalyse = (int?)db.FamAnalyse.First(a => a.Categorie == lkp_FamBilan.Text).ID_FA ?? 0;
                    if (id_FamAnalyse > 0)
                        _ID_FA = id_FamAnalyse;
                }
            }
        }

        public void GetIdBilanCatigory()
        {
            if (lkp_TypeBilan.EditValue != null && lkp_TypeBilan.Text != string.Empty)
            {
                using (DAL.Database db = new DAL.Database())
                {
                    var id_BilanCatigory = (int?)db.BilansCategories.First(a => a.Libelle == lkp_TypeBilan.Text).ID_Cat_Bilans ?? 0;
                    if (id_BilanCatigory > 0)
                        _ID_BilanCatigoty = id_BilanCatigory;
                }
            }
        }

        public async void LoadFamBilan()
        {
            using (DAL.Database db = new DAL.Database())
            {
                await db.FamAnalyse.LoadAsync();
                var query = db.FamAnalyse.Select(a => a.Categorie);
                lkp_FamBilan.Properties.DataSource = query.ToList();
                //lkp_FamBilan.Properties.ValueMember = nameof(DAL.FamAnalyse.ID_FA);
                //lkp_FamBilan.Properties.DisplayMember = nameof(DAL.FamAnalyse.Categorie);
            }

        }

        public async void LoadTypeBilan()
        {
            using (DAL.Database db = new DAL.Database())
            {
                await db.BilansCategories.LoadAsync();
                var query = db.BilansCategories.Select(a => a.Libelle);
                lkp_TypeBilan.Properties.DataSource = query.ToList();
            }
        }
    }
}
