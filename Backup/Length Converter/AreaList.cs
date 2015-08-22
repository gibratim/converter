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
    public class AreaList: List<AreaUnit>
    {
        public AreaList()
        {
            Add(new AreaUnit { AreaUnits = "Millimeter square" });
            Add(new AreaUnit { AreaUnits = "Centimeter square" });
            Add(new AreaUnit { AreaUnits = "Meter square " });
            Add(new AreaUnit { AreaUnits = "Inch square" });
            Add(new AreaUnit { AreaUnits = "Foot square" });
            Add(new AreaUnit { AreaUnits = "Yard square" });
            
        }
    }
}
