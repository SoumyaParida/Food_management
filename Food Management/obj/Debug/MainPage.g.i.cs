﻿#pragma checksum "C:\Users\soumya\Documents\visual studio 2012\Projects\Food Management\Food Management\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7FED69064CDBC30DDB49B4E810F70E88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace Food_Management {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.DataTemplate ListPickerItemTemplate;
        
        internal System.Windows.DataTemplate ListPickerFullModeItemTemplate;
        
        internal System.Windows.Controls.TextBox AddFood;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Food%20Management;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.ListPickerItemTemplate = ((System.Windows.DataTemplate)(this.FindName("ListPickerItemTemplate")));
            this.ListPickerFullModeItemTemplate = ((System.Windows.DataTemplate)(this.FindName("ListPickerFullModeItemTemplate")));
            this.AddFood = ((System.Windows.Controls.TextBox)(this.FindName("AddFood")));
        }
    }
}
