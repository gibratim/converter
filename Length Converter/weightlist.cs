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

namespace Length_Converter
{
    public class WeightList : List<weight>
    {
        public WeightList()
        {
            Add(new weight { weightUnits = "Kgs" });
            Add(new weight { weightUnits = "grams" });
            Add(new weight { weightUnits = "ounce" });
            Add(new weight { weightUnits = "pound" });
            Add(new weight { weightUnits = "tonnes" });
            Add(new weight { weightUnits = "milligrams" });
            

        }
    }
}
