// Updated by XamlIntelliSenseFileGenerator 10-Jul-21 2:54:50 PM
#pragma checksum "..\..\SourceListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F52DA3A081F606D24A3897B46F7EBBD7567D097E49F6D7337868092C1A8ECCD7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace _18120017_TripleNApp
{


    /// <summary>
    /// SourceListPage
    /// </summary>
    public partial class SourceListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {


#line 38 "..\..\SourceListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;

#line default
#line hidden


#line 48 "..\..\SourceListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;

#line default
#line hidden


#line 74 "..\..\SourceListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SourceListview;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/18120017_TripleNApp;component/sourcelistpage.xaml", System.UriKind.Relative);

#line 1 "..\..\SourceListPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.SearchButton = ((System.Windows.Controls.Button)(target));

#line 38 "..\..\SourceListPage.xaml"
                    this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));

#line 49 "..\..\SourceListPage.xaml"
                    this.SearchTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTexttBox_KeyDown);

#line default
#line hidden

#line 50 "..\..\SourceListPage.xaml"
                    this.SearchTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.SearchButton_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.BillAddButton = ((System.Windows.Controls.Button)(target));

#line 54 "..\..\SourceListPage.xaml"
                    this.BillAddButton.Click += new System.Windows.RoutedEventHandler(this.BillAddButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.SourceListview = ((System.Windows.Controls.ListView)(target));

#line 75 "..\..\SourceListPage.xaml"
                    this.SourceListview.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.SourceListview_MouseLeftButtonUp);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 5:

#line 97 "..\..\SourceListPage.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SourceDeleteButton_Click);

#line default
#line hidden
                    break;
            }
        }

        internal System.Windows.Controls.Button SourceAddButton;
    }
}
