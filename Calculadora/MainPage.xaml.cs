using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        double res = 0;
        public MainPage()
        {
            InitializeComponent();
            pik.Items.Add("suma");
            pik.Items.Add("resta");
            pik.Items.Add("multiplicacion");
            pik.Items.Add("division");
            pik.SelectedIndexChanged += w_SelectedIndexChanged;
            btnres.Clicked += btnres_Clicked;
        }

        private void w_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnres_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nu1.Text) && !string.IsNullOrEmpty(nu2.Text))
            {
                String operacion = pik.SelectedItem.ToString();
                int n1 = Int32.Parse(nu1.Text);
                int n2 = Int32.Parse(nu2.Text);


                if (operacion == "suma")
                {
                    res = n1 + n2;
                }
                else if (operacion == "resta")
                {
                    res = n1 - n2;
                }
                else if (operacion == "multiplicacion")
                {
                    res = n1 * n2;
                }
                else if (operacion == "division")
                {
                    res = n1 / n2;
                }
            }
            labelresu.Text = res + "";
        }
    
    }
}
