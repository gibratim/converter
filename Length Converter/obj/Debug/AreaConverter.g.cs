﻿#pragma checksum "F:\Length Converter\Length Converter\AreaConverter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "19099C1809448A09DA05FEF2D7BEB12B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Length_Converter {
    
    
    public partial class AreaConverter : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid FromGrid;
        
        internal System.Windows.Controls.ListBox lstFrom;
        
        internal System.Windows.Controls.Grid ToGrid;
        
        internal System.Windows.Controls.ListBox lstTo;
        
        internal System.Windows.Controls.Grid MainGrid;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox txtFrom;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBox txtTo;
        
        internal System.Windows.Controls.Button btnLstTo;
        
        internal System.Windows.Controls.Button btnLstFrom;
        
        internal System.Windows.Controls.TextBlock txtError;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Length%20Converter;component/AreaConverter.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.FromGrid = ((System.Windows.Controls.Grid)(this.FindName("FromGrid")));
            this.lstFrom = ((System.Windows.Controls.ListBox)(this.FindName("lstFrom")));
            this.ToGrid = ((System.Windows.Controls.Grid)(this.FindName("ToGrid")));
            this.lstTo = ((System.Windows.Controls.ListBox)(this.FindName("lstTo")));
            this.MainGrid = ((System.Windows.Controls.Grid)(this.FindName("MainGrid")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.txtFrom = ((System.Windows.Controls.TextBox)(this.FindName("txtFrom")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.txtTo = ((System.Windows.Controls.TextBox)(this.FindName("txtTo")));
            this.btnLstTo = ((System.Windows.Controls.Button)(this.FindName("btnLstTo")));
            this.btnLstFrom = ((System.Windows.Controls.Button)(this.FindName("btnLstFrom")));
            this.txtError = ((System.Windows.Controls.TextBlock)(this.FindName("txtError")));
        }
    }
}
