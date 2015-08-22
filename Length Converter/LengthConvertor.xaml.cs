using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Unit_Conversion2
{
    public partial class LengthConvertor : PhoneApplicationPage
    {
        public LengthConvertor()
        {
            InitializeComponent();
            FillLengthBox();


        }
        private void FillLengthBox()
        {
            lstFrom.ItemsSource = new LengthList();
            lstTo.ItemsSource = new LengthList();
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
                    btnLstFrom.Content = "Millimeters";

                }
                if (lstFrom.SelectedIndex.Equals(1))
                {
                    btnLstFrom.Content = "Centimeters";
                }
                if (lstFrom.SelectedIndex.Equals(2))
                {
                    btnLstFrom.Content = "Meters";
                }
                if (lstFrom.SelectedIndex.Equals(3))
                {
                    btnLstFrom.Content = "Kilometers";
                }
                if (lstFrom.SelectedIndex.Equals(4))
                {
                    btnLstFrom.Content = "Inches";
                }
                if (lstFrom.SelectedIndex.Equals(5))
                {
                    btnLstFrom.Content = "Feet";
                }
                if (lstFrom.SelectedIndex.Equals(6))
                {
                    btnLstFrom.Content = "Yards";
                }
                if (lstFrom.SelectedIndex.Equals(7))
                {
                    btnLstFrom.Content = "Miles";
                }
                if (txtTo.Text == "")
                {
                    txtTo.Text = "1";
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Millimeters"))))
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
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.1);
                    
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Meters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                   
                }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);
                   
                }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Inches"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.03937);
                 }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Feet"))))
                {
                  
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.003281);
                 
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Yards"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001094);
                    
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Miles"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.21e-07);
                    
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.1);
                    
                }


                //  For Centimeter //


                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10);
                   
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Centimeters"))))
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
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Meters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);
                    
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00001);
                    
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Inches"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.393701);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Feet"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.032808);
                    
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.010936);
                   
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Miles"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000006);
                    
                }

                // Meters //

                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                    
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);
                    
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Meters"))))
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
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Inches"))))
                {
                       txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39.37008);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Feet"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3.28084);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Yards"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.093613);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Miles"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000621);
                   
                }

                // Kilometers //


                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);
                    
                    
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100000);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Meters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Kilometers"))))
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
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Inches"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39370.08);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Feet"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3280.84);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Yards"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1093.613);
                    
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Miles"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.621371);
                   
                }


                //Inches//

                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 25.4);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 2.54);
                   
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Meters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0254);
                   
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000025);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Inches"))))
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
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Feet"))))
                {
                  
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.083333);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.027778);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Miles"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000016);
                    
                }

                // Feet //

                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 304.8);
                   
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 30.48);
                   
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.3048);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000305);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Inches"))))
                {
                  
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 12);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Feet"))))
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
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.333333);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Miles"))))
                {
                     txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000189);
                   
                }

                // Yards //

                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 914.4);
                    
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 91.44);
                    
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.9144);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000914);
                    
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Inches"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 36);
                  
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Feet"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Yards"))))
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
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Miles"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000568);
                      txtTo.Text = Convert.ToString(Convert.ToInt32(txtFrom.Text) * 0.000568);
                    
                }

                // Miles //

                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609344);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 160934.4);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609.344);
                    
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.609344);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Inches"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 63360);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Feet"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 5280);
                    
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Yards"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1760);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Miles"))))
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

            lstFrom.Visibility = Visibility.Collapsed;
            txtFrom.Visibility = Visibility.Visible;
            btnLstTo.Visibility = Visibility.Visible;
            txtTo.Visibility = Visibility.Visible;


        }

        private void btnLstFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            
            FromGrid.Visibility = Visibility.Visible;
            MainGrid.Visibility = Visibility.Collapsed;

            lstFrom.Visibility = Visibility.Visible;
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
                    btnLstTo.Content = "Millimeters";
                    //txtLstTo.Text = "Millimeters";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10);
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                      
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                       
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);
                       
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 25.4);
                       
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 304.8);
                       
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 914.4);
                       
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609344);
                       
                    }


                }
                if (lstTo.SelectedIndex.Equals(1))
                {
                    btnLstTo.Content = "Centimeters";
                    //txtLstTo.Text = "Centimeters";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.1);
                        
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100000);
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 2.54);
                    
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 30.48);
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 91.44);
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 160934.4);
                    }


                }
                if (lstTo.SelectedIndex.Equals(2))
                {
                    btnLstTo.Content = "Meters";
                    //txtLstTo.Text = "Meters";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                        
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);
                        
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                        
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0254);
                       
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.3048);
                       
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.9144);
                       
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609.344);
                    }

                }
                if (lstTo.SelectedIndex.Equals(3))
                {
                    btnLstTo.Content = "Kilometers";
                    //txtLstTo.Text = "Kilometers";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);
                       
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00001);
                       
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                       
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000025);

                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000305);
                        
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000914);
                        
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.609344);
                        
                    }

                }
                if (lstTo.SelectedIndex.Equals(4))
                {
                    btnLstTo.Content = "Inches";
                    //txtLstTo.Text = "Inches";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.03937);
                        
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.393701);
                        
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39.37008);
                        
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39370.08);
                        
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 12);
                        
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 36);
                        
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 63360);
                        
                    }

                }

                if (lstTo.SelectedIndex.Equals(5))
                {
                    btnLstTo.Content = "Feet";
                    //txtLstTo.Text = "Inches";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.003281);
                       
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.032808);
                       
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3.28084);
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3280.84);
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.083333);
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3);
                        
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 5280);
                        
                    }

                }


                if (lstTo.SelectedIndex.Equals(6))
                {
                    btnLstTo.Content = "Yards";
                    //txtLstTo.Text = "Inches";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001094);
                       
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.010936);
                        
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.093613);
                        
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1093.613);
                       
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.027778);
                     }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.333333);
                     }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1760);
                       
                    }

                }

                if (lstTo.SelectedIndex.Equals(7))
                {
                    btnLstTo.Content = "Miles";
                    //txtLstTo.Text = "Inches";
                    if (btnLstFrom.Content.Equals("Millimeters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.21e-07);
                       

                            txtTo.Text = Convert.ToString(Convert.ToInt32(txtFrom.Text) * 6.21e-07);
                        
                    }
                    if (btnLstFrom.Content.Equals("Centimeters"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000006);
                        
                    }
                    if (btnLstFrom.Content.Equals("Meters"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000621);
                        
                    }
                    if (btnLstFrom.Content.Equals("Kilometers"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.621371);
                       
                    }
                    if (btnLstFrom.Content.Equals("Inches"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000016);
                       
                    }
                    if (btnLstFrom.Content.Equals("Feet"))
                    {
                       
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000189);
                       
                    }
                    if (btnLstFrom.Content.Equals("Yards"))
                    {
                        
                            txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000568);
                        
                    }
                    if (btnLstFrom.Content.Equals("Miles"))
                    {
                        txtTo.Text = txtFrom.Text;
                    }


                }

            }
            lstTo.Visibility = Visibility.Collapsed;
            btnLstTo.Visibility = Visibility.Visible;
            txtTo.Visibility = Visibility.Visible;
        }

        private void btnLstTo_GotFocus(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Collapsed;
            ToGrid.Visibility = Visibility.Visible;
            lstTo.Visibility = Visibility.Visible;

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
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Millimeters"))))
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
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.1);
                    
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Meters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                        
                    
                }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000001);
                }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Inches"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.03937);
                }

                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Feet"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.003281);
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Yards"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001094);
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Miles"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 6.21e-07);
                }
                if ((btnLstFrom.Content.Equals("Millimeters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.1);
                }


                //  For Centimeter //


                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 10);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Centimeters"))))
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
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Meters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.01);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.00001);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Inches"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.393701);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Feet"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.032808);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Yards"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.010936);
                }
                if ((btnLstFrom.Content.Equals("Centimeters") && (btnLstTo.Content.Equals("Miles"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000006);
                }

                // Meters //

                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Meters"))))
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
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.001);
                    
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Inches"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39.37008);
                    
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Feet"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3.28084);
                    
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.093613);
                   
                }
                if ((btnLstFrom.Content.Equals("Meters") && (btnLstTo.Content.Equals("Miles"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000621);
                   
                }

                // Kilometers //


                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000000);
                    
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 100000);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Meters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1000);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Kilometers"))))
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
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Inches"))))
                {
                  
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 39370.08);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Feet"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3280.84);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Yards"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1093.613);
                   
                }
                if ((btnLstFrom.Content.Equals("Kilometers") && (btnLstTo.Content.Equals("Miles"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.621371);
                   
                }


                //Inches//

                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 25.4);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 2.54);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.0254);
                    
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000025);
                   
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Inches"))))
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
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Feet"))))
                {
                       txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.083333);
                  
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.027778);
                   
                }
                if ((btnLstFrom.Content.Equals("Inches") && (btnLstTo.Content.Equals("Miles"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000016);
                    
                }

                // Feet //

                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 304.8);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 30.48);
                   
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.3048);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000305);
                    
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Inches"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 12);
                   
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Feet"))))
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
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.333333);
                   
                }
                if ((btnLstFrom.Content.Equals("Feet") && (btnLstTo.Content.Equals("Miles"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000189);
                    
                }

                // Yards //

                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 914.4);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 91.44);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Meters"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.9144);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000914);
                   
                }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Inches"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 36);
                   }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Feet"))))
                {
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 3);
                    }
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Yards"))))
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
                if ((btnLstFrom.Content.Equals("Yards") && (btnLstTo.Content.Equals("Miles"))))
                {
                       txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 0.000568);
                   
                }

                // Miles //

                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Millimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609344);
                  
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Centimeters"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 160934.4);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Meters"))))
                {
                  
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1609.344);
                    
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Kilometers"))))
                {
                      txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1.609344);
                    
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Inches"))))
                {
                    txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 63360);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Feet"))))
                {
                   
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 5280);
                   
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Yards"))))
                {
                    
                        txtTo.Text = Convert.ToString(Convert.ToDouble(txtFrom.Text) * 1760);
                    
                }
                if ((btnLstFrom.Content.Equals("Miles") && (btnLstTo.Content.Equals("Miles"))))
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

        



        private void txtTo_GotFocus(object sender, RoutedEventArgs e)
        {
            lstTo.Visibility = Visibility.Collapsed;
            lstFrom.Visibility = Visibility.Collapsed;
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

        private void txtFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFrom.Text = "";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            txtFrom.Text = "";
            txtTo.Text = "";
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/LengthConvertor.xaml?Refresh=true&random={0}", Guid.NewGuid()), UriKind.Relative));
        }

        



    }
}