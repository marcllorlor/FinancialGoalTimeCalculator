using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciCalcurradora
{
    public partial class FormCalcurradora : Form
    {
        public FormCalcurradora()
        {
            InitializeComponent();
        }

        private void FormCalcurradora_Load(object sender, EventArgs e)
        {
            this.Size = new Size(390,615);
            gbSolucioFinal.Visible = false;
            lbMinuts.Visible = false;
            lbHores.Visible = false;
            lbTotalHoresATreballar.Visible = false;
            lbTotalMinutsATreballar.Visible = false;
        }
        private void btnNumero9_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(((Button)sender).Text) != 0 || tbCalculadora.Text != "")
            {
                tbCalculadora.Text += Int32.Parse(((Button)sender).Text);
            }           
        }

        private void btnConfiguracio_Click(object sender, EventArgs e)
        {
            this.Size = new Size(821, 615);
            btnConfiguracio.Visible = false;
        }

        private void btnAcceptarConfiguracio_Click(object sender, EventArgs e)
        {
            this.Size = new Size(390, 615);
            btnConfiguracio.Visible = true;
        }

        private void btnNumeroIgual_Click(object sender, EventArgs e)
        {
            string missatgeerror = "";
            bool correcte = true;
            //AQUESTA ES LA FUNCIO EN LA QUE FEM EL CALCUL DE LES HORES QUE HAURIA DE TREBALLAR

            //Aqui estem comporvant el text de la calculadora
            if (string.IsNullOrEmpty(tbCalculadora.Text) || ((decimal)float.Parse(tbCalculadora.Text) == 0))
            {
                correcte = false;
                MessageBox.Show("Has posat malament la meta de diners", "Error");
            }

            //Aqui estem fent la comprovacio del Import de cada paga
            missatgeerror = "El numero que has introduit al import de cada paga es INCORRECTE!";
            correcte = comprovacionumeros(correcte, nudImportCadaPaga.Value,missatgeerror);

            //Aqui estem fent la comprovacio del numero de pagues al any
            missatgeerror = "El numero que has introduit al numero de pagues al any es INCORRECTE!";
            correcte = comprovacionumeros(correcte, nudNumeroPagues.Value, missatgeerror);

            //Aqui estem fent la comprovacio de les hores setmanals
            missatgeerror = "El numero que has introduit a les hores setmanals es INCORRECTE!";
            correcte = comprovacionumeros(correcte, nudHoresSetmanals.Value, missatgeerror);

            //Aqui estem fent la comprovacio dels dies de vacances al any
            missatgeerror = "El numero que has introduit al numero de dies de vacances es INCORRECTE!";
            correcte = comprovacionumeros(correcte, nudDiesVacancesAny.Value, missatgeerror);

            //Aqui estem fent la comprovacio dels dies de vacances adicionals al any
            missatgeerror = "El numero que has introduit al numero de dies de vacances adicionals es INCORRECTE!";
            correcte = comprovacionumeros(correcte, nudDiesVacancesAnyAdicionals.Value, missatgeerror);
            
            if (correcte == true)
            {
                calcularimprimir();
            }
            else
            {
                MessageBox.Show("Modifica els valors per poder continuar amb el programa", "Error");
            }
        }

        private bool comprovacionumeros(bool correcte, decimal numero, string missatgeerror)
        {
            if (numero <= 0 || numero.ToString().Trim() == "")
            {
                correcte = false;
                MessageBox.Show(missatgeerror, "Error");
            }
            return correcte;
        }

        private void btnNumeroBorrar_Click(object sender, EventArgs e)
        {
            tbCalculadora.Clear();
        }

        private void calcularimprimir()
        {
            decimal pagamensual = nudImportCadaPaga.Value;//Import cada paga mensual
            decimal numeropaguesany = nudNumeroPagues.Value;//Numero de pagues al any
            decimal numerohoressetmanals = nudHoresSetmanals.Value;//Hores setmanals
            decimal numerodiesvancancesany = nudDiesVacancesAny.Value;//Dies de vacances al any
            decimal numerodiesvacancesanyadicionals = nudDiesVacancesAnyAdicionals.Value;//Dies de vacances adicionals al any

            decimal salariAnual = pagamensual * numeropaguesany;
            decimal setmanesTreballades = (365 - numerodiesvancancesany - numerodiesvacancesanyadicionals) / 7;
            decimal horestreballades = setmanesTreballades * numerohoressetmanals;
            decimal souHora = salariAnual / horestreballades;
            decimal souMinut = souHora / 60;

            decimal metafinal = (decimal)float.Parse(tbCalculadora.Text);
            decimal cantitathores = metafinal / souHora;
            decimal cantitatminuts = metafinal / souMinut;

            lbTotalHoresATreballar.Text = cantitathores.ToString("N1");
            lbTotalMinutsATreballar.Text = cantitatminuts.ToString("N1");

            gbSolucioFinal.Visible = true;
            lbMinuts.Visible = true;
            lbHores.Visible = true;
            lbTotalHoresATreballar.Visible = true;
            lbTotalMinutsATreballar.Visible = true;
        }
    }
}
