using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

            double liczba1 = 0;
            double liczba2 = 0;
            string operacja = "";

            public MainWindow()
            {
                InitializeComponent();
            }

            private void Guzi1_Click(object sender, RoutedEventArgs e)
            {

                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 1;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 1;
                    txtWyswietlaj.Text = liczba2.ToString();
                }

            }

            private void Guzi2_Click(object sender, RoutedEventArgs e)
            {

                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 2;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 2;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi3_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 3;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 3;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi4_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 4;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 4;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi5_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 5;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 5;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi6_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 6;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 6;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi7_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 7;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 7;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi8_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 8;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 8;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi9_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 9;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 9;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void Guzi0_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 * 10) + 0;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 * 10) + 0;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void GuziPlus_Click(object sender, RoutedEventArgs e)
            {
                operacja = "+";
                txtWyswietlaj.Text = "0";
            }

            private void GuziMinus_Click(object sender, RoutedEventArgs e)
            {
                operacja = "-";
                txtWyswietlaj.Text = "0";
            }

            private void GuziDziel_Click(object sender, RoutedEventArgs e)
            {
                operacja = "/";
                txtWyswietlaj.Text = "0";
            }

            private void GuziMnóż_Click(object sender, RoutedEventArgs e)
            {
                operacja = "x";
                txtWyswietlaj.Text = "0";
            }

            private void GuziWynik_Click(object sender, RoutedEventArgs e)
            {
                switch (operacja)
                {
                    case "+":
                        txtWyswietlaj.Text = (liczba1 + liczba2).ToString();
                        break;
                    case "-":
                        txtWyswietlaj.Text = (liczba1 - liczba2).ToString();
                        break;
                    case "x":
                        txtWyswietlaj.Text = (liczba1 * liczba2).ToString();
                        break;
                    case "/":
                        txtWyswietlaj.Text = (liczba1 / liczba2).ToString();
                        break;
                }
            }

            private void GuziKasuj_Click(object sender, RoutedEventArgs e)
            {
                liczba1 = 0;
                liczba2 = 0;
                operacja = "";
                txtWyswietlaj.Text = "0";
            }

            private void GuziBack_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 = (liczba1 / 10);
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 = (liczba2 / 10);
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }

            private void GuziPluMi_Click(object sender, RoutedEventArgs e)
            {
                if (operacja == "")
                {
                    liczba1 *= -1;
                    txtWyswietlaj.Text = liczba1.ToString();
                }
                else
                {
                    liczba2 *= -1;
                    txtWyswietlaj.Text = liczba2.ToString();
                }
            }
        }
    }

