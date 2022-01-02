using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using Gestion_Cabinet_Medical.Forms.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Cabinet_Medical.Forms.Principale_Form
{
    public partial class Principal_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal_Form()
        {
            InitializeComponent();
        }

        public static void OpenFormByName(string name)
        {
            Form frm = null;
            if (frm != null)
            {
                frm.ShowDialog();
                return;
            }
            else
            {
                var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
                if (ins != null)
                {
                    frm = Activator.CreateInstance(ins) as Form;
                    if (Application.OpenForms[frm.Name] != null)
                        frm = Application.OpenForms[frm.Name];
                    else
                        frm.ShowDialog();
                    frm.BringToFront();
                }
            }

        }

        public Form IsActivateForm(Type type)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == type)
                    return f;
            return null;
        }

        private void Principal_Form_Load(object sender, EventArgs e)
        {
            formMenu();
            barStaticDate.Caption = DateTime.Now.ToLongDateString();
            barStaticUsername.Caption = Properties.Settings.Default.LoginUsername;
            this.KeyPreview = true;
            Timer timer = new Timer
            {
                Enabled = true
            };
            timer.Tick += Timer_Tick;
            barBtnMenu.ItemClick += Bar_ItemClick;
            barBtnStat.ItemClick += Bar_ItemClick;
            barBtnAgenda.ItemClick += Bar_ItemClick;
            barBtnSearchPatient.ItemClick += Bar_ItemClick;
            barBtnNewDossier.ItemClick += Bar_ItemClick;
            barBtnManagPatient.ItemClick += Bar_ItemClick;
            barBtnSalleAttente.ItemClick += Bar_ItemClick;
            barBtnNewConsult.ItemClick += Bar_ItemClick;
            barBtnNewConsult.ItemClick += Bar_ItemClick;
            barBtnMotifs.ItemClick += Bar_ItemClick;
            barBtnConsultManag.ItemClick += Bar_ItemClick;

        }

        public void formMenu()
        {
            Form frm = IsActivateForm(typeof(Home.Menu_Principal));
            if (frm == null)
            {
                Home.Menu_Principal menu = new Home.Menu_Principal();
                menu.MdiParent = this;
                menu.Show();
            }
            else
                frm.Activate();
        }

        private void Bar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "barBtnMenu":
                    formMenu();
                    break;
                case "barBtnStat":
                    {
                        Form frm = IsActivateForm(typeof(Home.Statistique_d_accueil));
                        if (frm == null)
                        {
                            Home.Statistique_d_accueil stat = new Home.Statistique_d_accueil();
                            stat.MdiParent = this;
                            stat.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnAgenda":
                    {
                        Form frm = IsActivateForm(typeof(Home.Agenda));
                        if (frm == null)
                        {
                            Home.Agenda agenda = new Home.Agenda();
                            agenda.MdiParent = this;
                            agenda.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnSearchPatient":
                    OpenFormByName(e.Item.Tag.ToString());
                    break;
                case "barBtnNewDossier":
                    {
                        Nouveau_Patient ptn = new Nouveau_Patient
                        {
                            EditOrAdd = "Add"
                        };
                        ptn.ShowDialog();
                    }
                    break;
                case "barBtnManagPatient":
                    {
                        Form frm = IsActivateForm(typeof(Patient_Management));
                        if (frm == null)
                        {
                            Patient_Management patient = new Patient_Management
                            {
                                MdiParent = this
                            };
                            patient.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnSalleAttente":
                    {
                        Form frm = IsActivateForm(typeof(Salle_d_attente));
                        if (frm == null)
                        {
                            Salle_d_attente attente = new Salle_d_attente
                            {
                                MdiParent = this
                            };
                            attente.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnNewConsult":
                    {
                        Form frm = IsActivateForm(typeof(Consultation.Nouvelle_Consultation));
                        if (frm == null)
                        {
                            Consultation.Nouvelle_Consultation newConsult = new Consultation.Nouvelle_Consultation
                            {
                                MdiParent = this
                            };
                            newConsult.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnConsultManag":
                    {
                        Form frm = IsActivateForm(typeof(Consultation.Consultation_Management));
                        if (frm == null)
                        {
                            Consultation.Consultation_Management consult = new Consultation.Consultation_Management
                            {
                                MdiParent = this
                            };
                            consult.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                case "barBtnMotifs":
                    {
                        Form frm = IsActivateForm(typeof(Consultation.Motifs));
                        if (frm == null)
                        {
                            Consultation.Motifs motif = new Consultation.Motifs
                            {
                                MdiParent = this
                            };
                            motif.Show();
                        }
                        else
                            frm.Activate();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            barStaticTime.Caption = DateTime.Now.ToLongTimeString();
        }

        private void Principal_Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    ribbonControl1.SelectedPage = RP_Acceil;
                    break;
                case Keys.P:
                    ribbonControl1.SelectedPage = RP_Patient;
                    break;
                case Keys.C:
                    ribbonControl1.SelectedPage = RP_Consultation;
                    break;
                case Keys.O:
                    ribbonControl1.SelectedPage = RP_Ordonnances;
                    break;
                case Keys.U:
                    ribbonControl1.SelectedPage = RP_User;
                    break;
                case Keys.F:
                    ribbonControl1.SelectedPage = RP_Finance;
                    break;
                case Keys.T:
                    ribbonControl1.SelectedPage = RP_Table;
                    break;
                case Keys.I:
                    ribbonControl1.SelectedPage = RP_Outils;
                    break;
                case Keys.G:
                    ribbonControl1.SelectedPage = RP_Configuration;
                    break;
                default:
                    break;
            }
        }
    }
}
