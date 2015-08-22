using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Unit_Conversion2;

namespace Length_Converter
{
    public partial class AreaConverter : PhoneApplicationPage
    {
        public AreaConverter()
        {
            InitializeComponent();
            FillAreaBox();
        }
        private void FillAreaBox()
        {
            lstFrom.ItemsSource = new AreaList();
            lstTo.ItemsSource = new AreaList();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "9";
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "0";
        }

        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "e";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "-";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += "+";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text += ".";

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            txtTo.Text = "";
            Int32 l = Convert.ToInt32(txtFrom.Text.Length) - 1;
            if (txtFrom.Text == "")
            {
            }
            else
            {
                txtFrom.Text = txtFrom.Text.Substring(0, l);
                if (l < 1)
                {
                    txtFrom.Text = "";
                    txtTo.Text = "";
                }
            }

        }

        private void btnLstFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            FromGrid.Visibility = Visibility.Visible;
            MainGrid.Visibility = Visibility.Collapsed;

            lstFrom.Visibility = Visibility.Visible;

        }

        private void txtFrom_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtError.Visibility = Visibility.Collapsed;
            if (txtFrom.Text == "")
            {
                txtFrom.Text = "";
                txtTo.Text = "";
            }
            else
            {
                // Millimeter square //

                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);
                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00155);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Foot square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000011);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Yard square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);

                }

                // Centimeter Square //

                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Meter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0001);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.155);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Foot square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001076);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Yard square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00012);

                }

                // Meter Square //

                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10000);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Inch square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1550.003);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Foot square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10.76391);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Yard square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.19599);

                }

                // Inch Square //
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 645.16);

                }
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.4516);

                }
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Meter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000645);

                }
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                }
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Foot square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.006944);

                }
                if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Yard square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000772);

                }


                //Foot Square//

                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 92903);

                }
                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 929.0304);

                }
                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.092903);

                }
                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 144);

                }
                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Foot square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }

                }
                if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Yard square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.111111);

                }

                // Yard Square //

                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 836127);

                }
                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 8361.274);

                }
                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.836127);

                }
                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Inch square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1296);

                }
                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Foot square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 9);


                }
                if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Yard square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                }

            }
        }
        private void btnLstTo_GotFocus(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Collapsed;
            ToGrid.Visibility = Visibility.Visible;
            lstTo.Visibility = Visibility.Visible;
        }
        private void txtTo_GotFocus(object sender, RoutedEventArgs e)
        {
            lstTo.Visibility = Visibility.Collapsed;
            lstFrom.Visibility = Visibility.Collapsed;
        }

        private void lstFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Visible;
            FromGrid.Visibility = Visibility.Collapsed;
            if (txtFrom.Text == "")
            {
                txtError.Visibility = Visibility.Visible;
            }
            else
            {

                if (lstFrom.SelectedIndex.Equals(0))
                {
                    btnLstFrom.Content = "Millimeter square";

                }
                if (lstFrom.SelectedIndex.Equals(1))
                {
                    btnLstFrom.Content = "Centimeter square";
                }
                if (lstFrom.SelectedIndex.Equals(2))
                {
                    btnLstFrom.Content = "Meter square";
                }

                if (lstFrom.SelectedIndex.Equals(3))
                {
                    btnLstFrom.Content = "Inch square";
                }
                if (lstFrom.SelectedIndex.Equals(4))
                {
                    btnLstFrom.Content = "Foot square";
                }
                if (lstFrom.SelectedIndex.Equals(5))
                {
                    btnLstFrom.Content = "Yard square";
                }

                if (txtTo.Text == "")
                {
                    txtTo.Text = "1";
                }

                // Millimeter square //

                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    if (txtFrom.Text.Contains('.'))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    else
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Meter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00155);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Foot square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000011);

                }
                if ((btnLstFrom.Content.Equals("Millimeter square") && (btnLstTo.Content.Equals("Yard square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);

                }

                // Centimeter Square //

                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {
                    txtTo.Text = txtFrom.Text;

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0001);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Inch square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.155);

                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Foot square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001076);
                }
                if ((btnLstFrom.Content.Equals("Centimeter square") && (btnLstTo.Content.Equals("Yard square"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00012);

                }

                // Meter Square //

                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Millimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Centimeter square"))))
                {

                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10000);

                }
                if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Meter square"))))
                {
                    txtTo.Text = txtFrom.Text;
                }

            }
            if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Inch square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1550.003);

            }
            if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Foot square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10.76391);

            }
            if ((btnLstFrom.Content.Equals("Meter square") && (btnLstTo.Content.Equals("Yard square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.19599);

            }

            // Inch Square //
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Millimeter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 645.16);

            }
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Centimeter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.4516);

            }
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Meter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000645);

            }
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Inch square"))))
            {
                if (txtFrom.Text.Contains('.'))
                {
                    txtTo.Text = txtFrom.Text;
                }
                else
                {
                    txtTo.Text = txtFrom.Text;
                }
            }
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Foot square"))))
            {

                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.006944);

            }
            if ((btnLstFrom.Content.Equals("Inch square") && (btnLstTo.Content.Equals("Yard square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000772);

            }


            //Foot Square//

            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Millimeter square"))))
            {

                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 92903);

            }
            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Centimeter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 929.0304);
            }
            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Meter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.092903);

            }
            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Inch square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 144);

            }
            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Foot square"))))
            {
                if (txtFrom.Text.Contains('.'))
                {
                    txtTo.Text = txtFrom.Text;
                }
                else
                {
                    txtTo.Text = txtFrom.Text;
                }

            }
            if ((btnLstFrom.Content.Equals("Foot square") && (btnLstTo.Content.Equals("Yard square"))))
            {

                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.111111);

            }

            // Yard Square //

            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Millimeter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 836127);

            }
            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Centimeter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 8361.274);

            }
            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Meter square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.836127);

            }
            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Inch square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1296);
            }
            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Foot square"))))
            {
                txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 9);


            }
            if ((btnLstFrom.Content.Equals("Yard square") && (btnLstTo.Content.Equals("Yard square"))))
            {
                if (txtFrom.Text.Contains('.'))
                {
                    txtTo.Text = txtFrom.Text;
                }
                else
                {
                    txtTo.Text = txtFrom.Text;
                }
            }


            lstFrom.Visibility = Visibility.Collapsed;
            txtFrom.Visibility = Visibility.Visible;
            btnLstTo.Visibility = Visibility.Visible;
            txtTo.Visibility = Visibility.Visible;



        }

        private void lstTo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Visible;
            ToGrid.Visibility = Visibility.Collapsed;
            if (txtFrom.Text == "")
            {

                txtError.Visibility = Visibility.Visible;
            }
            else
            {
                txtError.Visibility = Visibility.Collapsed;
                if (lstTo.SelectedIndex.Equals(0))
                {
                    btnLstTo.Content = "Millimeter square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);

                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);

                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 645.16);

                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 92903);

                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 836127);

                    }


                }

                //Centimeter Square//
                if (lstTo.SelectedIndex.Equals(1))
                {
                    btnLstTo.Content = "Centimeter square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);

                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {
                        if (txtFrom.Text.Contains('.'))
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                        else
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10000);

                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.4516);

                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 929.0304);

                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 8361.274);

                    }
                }

                // Meter Square //

                if (lstTo.SelectedIndex.Equals(2))
                {
                    btnLstTo.Content = "Meter square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);

                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0001);

                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {
                        if (txtFrom.Text.Contains('.'))
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                        else
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000645);

                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.092903);

                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.836127);

                    }


                }

                // Inch Square //

                if (lstTo.SelectedIndex.Equals(3))
                {
                    btnLstTo.Content = "Inch square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00155);

                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.155);

                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1550.003);

                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {
                        if (txtFrom.Text.Contains('.'))
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                        else
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 144);

                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1296);

                    }
                }

                // Foot Square //

                if (lstTo.SelectedIndex.Equals(4))
                {
                    btnLstTo.Content = "Foot square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000011);

                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001076);

                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10.76391);

                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.006944);

                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {
                        if (txtFrom.Text.Contains('.'))
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                        else
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 9);

                    }
                }


                // Yard Square //

                if (lstTo.SelectedIndex.Equals(5))
                {
                    btnLstTo.Content = "Yard square";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeter square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);

                    }
                    if (btnLstFrom.Content.Equals("Centimeter square"))
                    {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00012);


                    }
                    if (btnLstFrom.Content.Equals("Meter square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.19599);

                    }
                    if (btnLstFrom.Content.Equals("Inch square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000772);

                    }
                    if (btnLstFrom.Content.Equals("Foot square"))
                    {

                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.111111);

                    }
                    if (btnLstFrom.Content.Equals("Yard square"))
                    {
                        if (txtFrom.Text.Contains('.'))
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                        else
                        {
                            txtTo.Text = txtFrom.Text;
                        }
                    }

                }
                lstTo.Visibility = Visibility.Collapsed;
                btnLstTo.Visibility = Visibility.Visible;
                txtTo.Visibility = Visibility.Visible;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/AreaConverter.xaml?Refresh=true&random={0}", Guid.NewGuid()), UriKind.Relative));
        }



    }
}