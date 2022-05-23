using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Gestion_Cabinet_Medical.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Bilans
{
    public partial class Fiche_Bilan : XtraForm
    {
        public int _ID_Patient = 3;
        public int _ID_Consultation;
        public int _ID_FA;
        public int _ID_Aanalyse;
        public int _ID_BilanCatigoty;
        DAL.Patient _Patient;
        DAL.Analyse _Analyse;
        DAL.Test _Test;
        List<DAL.Analyse> bilanSelected;
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
            #region Evants GridControl
            gridView_ForSelect.RowCellClick += GridView_ForSelect_RowCellClick;
            gridView_ForSelect.FocusedRowChanged += GridView_ForSelect_FocusedRowChanged;
            #endregion
            #region RepositoryItem

            RepositoryItemCheckEdit edit = new RepositoryItemCheckEdit();
            // Obtaining the column and changing its editor
            var checkColumn = gridView_ForSelect.VisibleColumns[0];
            checkColumn.ColumnEdit = edit;

            RepositoryItemButtonEdit riButton = new RepositoryItemButtonEdit();
            riButton.TextEditStyle = TextEditStyles.HideTextEditor;
            riButton.Buttons[0].Kind = ButtonPredefines.Glyph;
            riButton.Buttons[0].Image = Properties.Resources.Delete_16px;
            gridControl_ForPatient.RepositoryItems.Add(riButton);
            gridView_ForPatient.Columns["Action"].ColumnEdit = riButton;
            riButton.ButtonPressed += RiButton_ButtonPressed;
            #endregion
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
            #region Evants LookUpEdit EditValueChanged
            lkp_Consultation.EditValueChanged += Lkp_Consultation_EditValueChanged;
            lkp_FamBilan.EditValueChanged += Lkp_FamBilan_EditValueChanged;
            lkp_TypeBilan.EditValueChanged += Lkp_TypeBilan_EditValueChanged;
            #endregion
        }


        private void Lkp_Consultation_EditValueChanged(object sender, EventArgs e)
        {
            lkp_Consultation.Properties.Columns[nameof(DAL.Consultations.ID_Consultation)].Visible = false;
            _ID_Consultation = (int)lkp_Consultation.EditValue;
        }

        private void GridView_ForSelect_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetIdAnalyse();
        }

        private void GridView_ForSelect_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            GetIdAnalyse();
        }

        private void RiButton_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit btnEdit = sender as ButtonEdit;
            if (e.Button == btnEdit.Properties.Buttons[0])
                gridView_ForPatient.DeleteSelectedRows();
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

        private void EditableGridControl()
        {
            gridView_ForPatient.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView_ForPatient.Columns["Action"].OptionsColumn.AllowEdit = true;
            gridView_ForPatient.Columns["Nome"].OptionsColumn.AllowEdit = false;
            gridView_ForSelect.OptionsBehavior.Editable = false;
            gridView_ForSelect.OptionsSelection.MultiSelect = true;
            gridView_ForSelect.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView_ForSelect.FocusRectStyle = DrawFocusRectStyle.RowFocus;
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

            bilanSelected = new List<DAL.Analyse>();
            for (int i = 0; i < gridView_ForSelect.DataRowCount; i++)
            {
                if (gridView_ForSelect.IsRowSelected(i))
                {
                    // show who ID_Analyse is selected
                    var id = (int)gridView_ForSelect.GetRowCellValue(i, gridView_ForSelect.Columns[nameof(DAL.Analyse.ID_Analyse)]);
                    var name = (string)gridView_ForSelect.GetRowCellValue(i, gridView_ForSelect.Columns[nameof(DAL.Analyse.Nome)]) ?? "";
                    if (id != 0 || name != string.Empty)
                    {
                        _Analyse = new DAL.Analyse
                        {
                            ID_Analyse = id,
                            Nome = name
                        };
                        bilanSelected.Add(_Analyse);
                    }
                }
            }
            gridControl_ForPatient.DataSource = bilanSelected;
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
            Nouveau_Bilan nouveau_Bilan = new Nouveau_Bilan();
            nouveau_Bilan.EditOrAdd = "New";
            nouveau_Bilan.ShowDialog();
            LoadToutBilans();
        }

        private void EditBilan()
        {
            if (_ID_Aanalyse == 0)
            {
                XtraMessageBox.Show("Sélectionnez au moins un bilan s'il vous plaît", "msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Nouveau_Bilan nouveau_Bilan = new Nouveau_Bilan
            {
                _ID_Aanalyse = _ID_Aanalyse,
                EditOrAdd = "Edit"
            };
            nouveau_Bilan.ShowDialog();
            LoadToutBilans();
        }

        public void GetIdAnalyse()
        {
            if (gridView_ForSelect.GetFocusedRowCellValue(nameof(DAL.Analyse.ID_Analyse)) == null) return;
            var id = int.Parse(gridView_ForSelect.GetFocusedRowCellValue(nameof(DAL.Analyse.ID_Analyse)).ToString());
            if (id != 0)
                _ID_Aanalyse = id;
        }

        private void DeleteBilan()
        {
            if (_ID_Aanalyse != 0)
            {
                using (DAL.Database db = new DAL.Database())
                {
                    var analyse = db.Analyse.Single(a => a.ID_Analyse == _ID_Aanalyse);
                    if (analyse != null)
                    {
                        if (XtraMessageBox.Show("Attention, vous perdrez beaucoup de données lors de la suppristion.\n Est ce que vous supprimier cette analyse ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            db.Analyse.Remove(analyse);
                            db.SaveChanges();
                            XtraMessageBox.Show("Supprission Succse", "Supprission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            return;
                    }
                }
            }
            LoadToutBilans();
        }

        private void Save()
        {

            if (gridView_ForPatient.RowCount == 0)
                return;
            using (DAL.Database db = new DAL.Database())
            {
                if (_ID_Consultation == 0 || lkp_Consultation.EditValue == null)
                {
                    if (db.Consultations.Where(a => a.ID_Patient == _ID_Patient).Select(a => a.ID_Consultation).Max() != 0)
                        _ID_Consultation = db.Consultations.Where(a => a.ID_Patient == _ID_Patient).Select(a => a.ID_Consultation).Max();
                    XtraMessageBox.Show("Vous n'avez pas choisi l'un des consultations, donc nous choisirons automatiquement le dernier");
                }
                for (int i = 0; i < gridView_ForPatient.DataRowCount; i++)
                {
                    var idAnalyse = (int)gridView_ForPatient.GetRowCellValue(i, gridView_ForPatient.Columns[nameof(DAL.Analyse.ID_Analyse)]);
                    if (idAnalyse != 0 && _ID_Consultation != 0)
                    {
                        if (!db.Test.Where(b => b.ID_Consultation == _ID_Consultation).Any(a => a.ID_Analyse == idAnalyse))
                        {
                            _Test = new DAL.Test
                            {
                                ID_Consultation = _ID_Consultation,
                                IsAnalyse = true,
                                ID_Analyse = idAnalyse,
                                IsRadiographie = false,
                                IsRadiologie = false,
                                Date = dateEdit1.DateTime
                            };
                            db.Test.Add(_Test);
                            db.SaveChanges();
                        }
                        else
                            continue;
                    }
                }
                XtraMessageBox.Show("Saved Succesffuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void LoadPatientInfo(int iD_Patient)
        {
            using (DAL.Database db = new DAL.Database())
            {

                _Patient = db.Patient.First(a => a.ID_Patient == _ID_Patient);
                if (_Patient == null)
                    return;
                label_NomPrenom.Text = _Patient.Nom + " " + _Patient.Prenom;
                layoutControlGroup_PatientInfo.Text = _Patient.Nom + " " + _Patient.Prenom;
                if (_Patient.Image != null)
                    pic_ImagePatient.Image = Master.GetImageFromByteArray(_Patient.Image);
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
                                consult.ID_Consultation,
                                consult.DateTime,
                                motifs.Libelle
                            };
                lkp_Consultation.Properties.DataSource = query.ToList();
                lkp_Consultation.Properties.ValueMember = nameof(DAL.Consultations.ID_Consultation);
                lkp_Consultation.Properties.DisplayMember = nameof(DAL.Consultations.Motifs.Libelle);
                
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
