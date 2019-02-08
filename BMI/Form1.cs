using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void message_box(string message, string title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
            {
                mass_text_box.Text = String.Empty;
                height_taext_box.Text = String.Empty;
            }

        }


        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Double.Parse(height_taext_box.Text) / 100;
                double mass = Double.Parse(mass_text_box.Text);

                double bmi = ((mass) / (Math.Pow(height, 2)));

                bmi = Math.Round(bmi, 2);
                double correct_mass = 0;
                string resutl = "Your BMI: " + bmi.ToString();
                int p;
                if (bmi < 16)
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nNiedowaga\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + "kg a ";
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if ((bmi >= 16) && (bmi <= 16.99))
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nWychudzenie\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + "kg a ";
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if ((bmi >= 17) && (bmi <= 18.49))
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nNiedowaga\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + "kg a "; ;
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if ((bmi >= 18.5) && (bmi <= 24.99))
                {
                    resutl += "\nWaga prawidłowa";
                }
                if ((bmi >= 25) && (bmi <= 29.99))
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = correct_mass = Math.Floor(correct_mass);
                    resutl += "\nNadwaga\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + "kg a "; ;
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if ((bmi >= 30) && (bmi <= 34.99))
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nI stopień otyłości\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + "kg a ";
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if ((bmi >= 35) && (bmi <= 39.99))
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nII stopień otyłości\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + " "; ;
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                if (bmi >= 40)
                {
                    correct_mass = 18.5 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += "\nostyłość skrajna\nPrawidłowa waga pomiędzy:" + correct_mass.ToString() + " "; ;
                    correct_mass = 24.99 * Math.Pow(height, 2);
                    correct_mass = Math.Floor(correct_mass);
                    resutl += correct_mass.ToString() + "kg ";
                }
                resutl += "\nClose?";
                message_box(resutl, "Result");
            }
            catch (Exception ex)
            {
                message_box("Something gone wrong\nDo You want close?", "Error");
            }

        }
    }
}
