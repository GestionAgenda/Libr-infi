using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionInfirmerieBLL;
using GestionInfirmerieBO;
using System.Configuration;

namespace GestionInfirmerie
{
    public partial class FrmModuleSynthese : Form
    {
        DateTime dateDebut;
        DateTime dateFin;
        public FrmModuleSynthese()
        {

            InitializeComponent();
            dateTimeDateDebut.Value = Convert.ToDateTime("29/04/2015 00:00:00");
            dateTimeDateFin.Value= DateTime.Now;
            dateDebut=dateTimeDateDebut.Value;
            dateFin=dateTimeDateFin.Value;
            lblTempsMoy.Text = "Temps moyen d'une visite par élève : " + GestionSynthese.GetTempsMoyVis(dateDebut, dateFin).ToString("0.00");
            lblTotalEleve.Text = "Total élève dans l'établissement : " + GestionSynthese.GetNbTotEleve();
            lblTotalVisite.Text = "Total visites médicales         : " + GestionSynthese.GetNbTotVisite(dateDebut, dateFin);
            lblNbVisMoy.Text = "Nombre de visite moyenne par élève: " + GestionSynthese.GetVisiteMoyEleve(dateDebut, dateFin).ToString("0.00");
            lblTotalMedic.Text = "Total médicament sur l'année     : " + GestionSynthese.GetTotalMedic(dateDebut, dateFin);
            lblMedicMoyV.Text = "Nombre moyen de médicaments donnés par visite:" + GestionSynthese.GetMedicM(dateDebut, dateFin).ToString("0.00");
            
        }

        private void dateTimeDateDebut_ValueChanged(object sender, EventArgs e)
        {
            dateDebut = dateTimeDateDebut.Value;
            lblTempsMoy.Text = "Temps moyen d'une visite par élève : " + GestionSynthese.GetTempsMoyVis(dateDebut, dateFin).ToString("0.00");
            lblTotalEleve.Text = "Total élève dans l'établissement : " + GestionSynthese.GetNbTotEleve();
            lblTotalVisite.Text = "Total visites médicales         : " + GestionSynthese.GetNbTotVisite(dateDebut, dateFin);
            lblNbVisMoy.Text = "Nombre de visite moyenne par élève: " + GestionSynthese.GetVisiteMoyEleve(dateDebut, dateFin).ToString("0.00");
            lblTotalMedic.Text = "Total médicament sur l'année     : " + GestionSynthese.GetTotalMedic(dateDebut, dateFin);
            lblMedicMoyV.Text = "Nombre moyen de médicaments donnés par visite:" + GestionSynthese.GetMedicM(dateDebut, dateFin).ToString("0.00");
        }

        private void dateTimeDateFin_ValueChanged(object sender, EventArgs e)
        {
            dateFin = dateTimeDateFin.Value;
            lblTempsMoy.Text = "Temps moyen d'une visite par élève : " + GestionSynthese.GetTempsMoyVis(dateDebut, dateFin).ToString("0.00");
            lblTotalEleve.Text = "Total élève dans l'établissement : " + GestionSynthese.GetNbTotEleve();
            lblTotalVisite.Text = "Total visites médicales         : " + GestionSynthese.GetNbTotVisite(dateDebut, dateFin);
            lblNbVisMoy.Text = "Nombre de visite moyenne par élève: " + GestionSynthese.GetVisiteMoyEleve(dateDebut, dateFin).ToString("0.00");
            lblTotalMedic.Text = "Total médicament sur l'année     : " + GestionSynthese.GetTotalMedic(dateDebut, dateFin);
            lblMedicMoyV.Text = "Nombre moyen de médicaments donnés par visite:" + GestionSynthese.GetMedicM(dateDebut, dateFin).ToString("0.00");
        }

        private void lblMenuEleve_Click(object sender, EventArgs e)
        {
            FrmModuleListeEleve frm = new FrmModuleListeEleve();
            frm.Show();
            this.Hide();
        }

        private void lblMenuVisites_Click(object sender, EventArgs e)
        {
            FrmModuleListeVisites frm = new FrmModuleListeVisites();
            frm.Show();
            this.Hide();
        }


        private void lblMenuGestion_Click(object sender, EventArgs e)
        {
            FrmModuleGestion frm = new FrmModuleGestion();
            frm.Show();
            this.Hide();
        }

        private void lblMenuSynthese_Click(object sender, EventArgs e)
        {
            FrmModuleSynthese frm = new FrmModuleSynthese();
            frm.Show();
            this.Hide();
        }

        private void lblMenuMaintenance_Click(object sender, EventArgs e)
        {
            FrmModuleMaintenance frm = new FrmModuleMaintenance();
            frm.Show();
            this.Hide();
        }




            
    }
}
