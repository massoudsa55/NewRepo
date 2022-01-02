using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Gestion_Cabinet_Medical.Functions;

namespace Gestion_Cabinet_Medical.Forms.Patient
{
    public partial class Patient_Management : DevExpress.XtraEditors.XtraForm
    {
        int _ID_Patient = 0;
        public Patient_Management()
        {
            InitializeComponent();
        }

        private void Patient_Management_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_Add.ItemClick += Buttons_ItemClick;
            btn_Edit.ItemClick += Buttons_ItemClick;
            btn_Delete.ItemClick += Buttons_ItemClick;
            btn_Refresh.ItemClick += Buttons_ItemClick;
            btn_Export.ItemClick += Buttons_ItemClick;
            btn_Exit.ItemClick += Buttons_ItemClick;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            gridView1.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            gridView1.RowCellClick += GridView1_RowCellClick;
            gridView1.DoubleClick += GridView1_DoubleClick;
            gridControl1.KeyDown += GridControl1_KeyDown;

        }

        private void GridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Delete:
                    Delete();
                    break;
                case Keys.F1:
                    Add();
                    break;
                case Keys.F2:
                    Edit();
                    break;
                case Keys.F3:
                    Delete();
                    break;
                case Keys.F4:
                    LoadData();
                    break;
                case Keys.F5:
                    popupMenu1.ShowPopup(new Point(365, 192));
                    break;
                case Keys.F6:
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs mouseEA = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(mouseEA.Location);
            if (info.InRow || info.InRowCell)
                Edit();
        }

        private void GridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            GetIdPatient();
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GetIdPatient();
        }

        public void LoadData()
        {
            var query = from patient in Master.db.Patient
                        join sexe in Master.db.Sexe on patient.ID_Sexe equals sexe.ID_Sexe
                        into s from sexe in s.DefaultIfEmpty()
                        join civilite in Master.db.Civilite on patient.ID_Civilite equals civilite.ID_Civilite
                        into c from civilite in c.DefaultIfEmpty()
                        join groupeSanguin in Master.db.GroupeSanguin on patient.ID_GroupeSanguin equals groupeSanguin.ID_GroupeSanguin
                        into gs from groupeSanguin in gs.DefaultIfEmpty()
                        join situatioFam in Master.db.SituationFam on patient.ID_SF equals situatioFam.ID_SF
                        into sf from situatioFam in sf.DefaultIfEmpty()
                        join daira in Master.db.Daira on patient.ID_Daira equals daira.ID_Daira
                        into d from daira in d.DefaultIfEmpty()
                        join wilaya in Master.db.Wilaya on daira.ID_Wilaya equals wilaya.ID_Wilaya
                        into w from wilaya in w.DefaultIfEmpty()
                        select new
                        {
                            patient.ID_Patient,
                            patient.Code,
                            patient.Nom,
                            patient.Prenom,
                            patient.DOB,
                            patient.Age,
                            ID_Sexe = sexe.Type,
                            ID_Civilite = civilite.Type,
                            ID_GroupeSanguin = groupeSanguin.Type,
                            ID_SF = situatioFam.Type,
                            patient.Phone1,
                            patient.Phone2,
                            patient.Email,
                            Address = patient.Address + " " + daira.NameDaira + " du " + wilaya.NameWilaya,
                            patient.Profession,
                            patient.Note
                        };
            gridControl1.DataSource = query.ToList();
        }

        public void GetIdPatient()
        {
            if (gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)) == null) return;
            var id = int.Parse(gridView1.GetFocusedRowCellValue(nameof(DAL.Patient.ID_Patient)).ToString());
            if (id != 0)
                _ID_Patient = id;
        }

        public void Delete()
        {
            if (_ID_Patient != 0)
            {
                var patient = Master.db.Patient.First(a => a.ID_Patient == _ID_Patient);
                if (patient != null)
                {
                    if (MessageBox.Show("Est ce que vous supprimier cette patient ?", "Supprission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Master.db.Patient.Remove(patient);
                        Master.db.SaveChanges();
                        MessageBox.Show("Supprission Succse", "Supprission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                        return;
                }
            }
        }

        public void Edit()
        {
            Nouveau_Patient ptn = new Nouveau_Patient();
            ptn.Text = "Modifier le Patient : "+ptn.GetFirsname(_ID_Patient);
            ptn._ID_Patient = _ID_Patient;
            ptn.EditOrAdd = "Edit";
            ptn.ShowDialog();
            LoadData();
        }

        public void Add()
        {
            Nouveau_Patient ptn = new Nouveau_Patient
            {
                EditOrAdd = "Add"
            };
            ptn.ShowDialog();
            LoadData();
        }

        private void Buttons_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "btn_Add":
                    Add();
                    break;
                case "btn_Edit":
                    Edit();
                    break;
                case "btn_Delete":
                    Delete();
                    break;
                case "btn_Refresh":
                    LoadData();
                    break;
                case "btn_Export":
                    popupMenu1.ShowPopup(new Point(365, 192));
                    break;
                case "btn_Exit":
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
