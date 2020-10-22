using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Info
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Second : ContentPage
    {
        public Second()
        {
            InitializeComponent();
         
            
        }

        private void Butto_Clicked(object sender, EventArgs e)
        {
            double sal = Convert.ToInt32(entrada.Text);
            if(sal >= 0.01 && sal<= 472)
            {
                mensaje.Text = "";
                lab.Text = "Sin Retencion";
                lab1.Text = "";
                lab2.Text = "";
            }
            else if (sal >= 472.01 && sal <= 895.24)
            {
                mensaje.Text = "Retencion del 10% " + "+ Retencion de $17.67";
                double su;
                double se;
                double fa;
                double on = 17.67;
                double fn;
                double db;
                su = sal * 10;
                se = su / 100;
                fa = se + on;
                fn = sal - fa;
                db = fn / 2;
                lab.Text = "Su Retencion sera: $" +fa;
                lab1.Text = "Salario Mensual: $" + fn;
                lab2.Text = "Salario Quincenal: $" + db;
            }
            else if (sal >= 895.25 && sal <= 2038.10)
            {
                mensaje.Text = "Retencion del 20% " + "+ Retencion de $60";
                double su;
                double se;
                double fa;
                double on = 60;
                double fn;
                double db;
                su = sal * 20;
                se = su / 100;
                fa = se + on;
                fn = sal - fa;
                db = fn / 2;
                lab.Text = "Su Retencion sera: $" + fa;
                lab1.Text = "Salario Mensual: $" + fn;
                lab2.Text = "Salario Quincenal: $" + db;
            }
            else if(sal >= 2038.11)
            {
                mensaje.Text = "Retencion del 30% " + "+ Retencion de $288.57";
                double su;
                double se;
                double fa;
                double on = 288.57;
                double fn;
                double db;
                su = sal * 30;
                se = su / 100;
                fa = se + on;
                fn = sal - fa;
                db = fn / 2;
                lab.Text = "Su Retencion sera: $" + fa;
                lab1.Text = "Salario Mensual: $" + fn;
                lab2.Text = "Salario Quincenal: $" + db;
            }
        }
    }
}
