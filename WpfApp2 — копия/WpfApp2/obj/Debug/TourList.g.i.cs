﻿#pragma checksum "..\..\TourList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5B5B1AA64BBE721464621704B154FE9A1C7ADEF96391E208A73C41081A34AFF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// TourList
    /// </summary>
    public partial class TourList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\TourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtFindedTourName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\TourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTypes;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\TourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChbActual;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnListHotelsView;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\TourList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListTours;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/tourlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TourList.xaml"
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
            this.TxtFindedTourName = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\TourList.xaml"
            this.TxtFindedTourName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtFindedTourName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\TourList.xaml"
            this.CmbTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbTypes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChbActual = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\TourList.xaml"
            this.ChbActual.Checked += new System.Windows.RoutedEventHandler(this.ChbActual_Checked);
            
            #line default
            #line hidden
            
            #line 38 "..\..\TourList.xaml"
            this.ChbActual.Unchecked += new System.Windows.RoutedEventHandler(this.ChbActual_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnListHotelsView = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\TourList.xaml"
            this.BtnListHotelsView.Click += new System.Windows.RoutedEventHandler(this.BtnListHotelsView_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListTours = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

