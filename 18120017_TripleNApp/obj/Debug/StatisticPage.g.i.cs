﻿#pragma checksum "..\..\StatisticPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2DE01FF07907B9B3CFF1A4723A706507698774DB77D68AE20D55E00E74701597"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using _18120017_TripleNApp;


namespace _18120017_TripleNApp {
    
    
    /// <summary>
    /// StatisticPage
    /// </summary>
    public partial class StatisticPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\StatisticPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox YearCombobox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\StatisticPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart ColumnChart;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\StatisticPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MonthCombobox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\StatisticPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EmptyPie;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\StatisticPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/18120017_TripleNApp;component/statisticpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StatisticPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.YearCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\StatisticPage.xaml"
            this.YearCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.YearCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColumnChart = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 3:
            this.MonthCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\StatisticPage.xaml"
            this.MonthCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MonthCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EmptyPie = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PieChart = ((LiveCharts.Wpf.PieChart)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
