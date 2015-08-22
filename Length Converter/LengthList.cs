using System;
using System.Net;
using System.Windows;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Unit_Conversion2
{
    public class LengthList:List<Length>
    {
        public LengthList()
        {
            Add(new Length { LengthUnits = "Millimeters" });
            Add(new Length { LengthUnits = "Centimeters" });
            Add(new Length { LengthUnits = "Meters" });
            Add(new Length { LengthUnits = "Kilometers" });
            Add(new Length { LengthUnits = "Inches" });
            Add(new Length { LengthUnits = "Feet" });
            Add(new Length { LengthUnits = "Yards" });
            Add(new Length { LengthUnits = "Miles" });

        }
    }
}
