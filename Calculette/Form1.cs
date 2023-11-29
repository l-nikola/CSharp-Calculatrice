using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Operateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Nombre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcul_Click(object sender, EventArgs e)
        {

            double nb1, nb2;
            double resultat = 0;
            string operateur;
            nb1 = Convert.ToDouble(Nombre1.Text);
            nb2 = Convert.ToDouble(Nombre2.Text);
            operateur = Operateur.Text;
         
            switch (operateur)
            {
                case "+":
                    resultat = nb1 + nb2;
                    Result.Text = resultat.ToString();
                    break;
                case "-":
                    resultat = nb1 - nb2;
                    Result.Text = resultat.ToString();
                    break;
                case "*":
                    resultat = nb1 * nb2;
                    Result.Text = resultat.ToString();
                    break;
                case "/":
                    resultat = nb1 / nb2;
                    if (nb2 == 0)
                    {
                        label5.Text = " Une division par 0 n'est pas possible ";
                        Result.Text = "ERR!!";
                    }
                    
                    else
                        Result.Text = resultat.ToString();
                    break;
                case "":
                    label5.Text = "Il faut saisir deux nombres et sélectionner un opérateur !";
                    Result.Text = "ERR!!";
                    break;
            }
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
 
        }

        private void Nombre1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
