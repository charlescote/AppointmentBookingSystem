﻿#pragma checksum "..\..\..\searchPatient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DD9149034AC429EE32FDB58BC8C65C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace loginPage {
    
    
    /// <summary>
    /// searchPatient
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class searchPatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid searchPatientBox;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchLastName;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button selectButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchCancelButton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid searchDataGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\searchPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox searchPatLB;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/loginPage;component/searchpatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\searchPatient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.searchPatientBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.searchLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.selectButton = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\searchPatient.xaml"
            this.selectButton.Click += new System.Windows.RoutedEventHandler(this.selectButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\searchPatient.xaml"
            this.searchButton.Click += new System.Windows.RoutedEventHandler(this.searchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\searchPatient.xaml"
            this.searchCancelButton.Click += new System.Windows.RoutedEventHandler(this.searchCancelButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.searchPatLB = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

