﻿#pragma checksum "..\..\WindowTransferToBankAccount.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD3143C3F7831B9B139389CD4A178BB4374B628EF2500C26B8CA50CF6EA9057B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HomeWork_16;
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


namespace HomeWork_16 {
    
    
    /// <summary>
    /// WindowTransferToBankAccount
    /// </summary>
    public partial class WindowTransferToBankAccount : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\WindowTransferToBankAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBankAccount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowTransferToBankAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBankAccounts;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WindowTransferToBankAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSum;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\WindowTransferToBankAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slSum;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeWork_16;component/windowtransfertobankaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowTransferToBankAccount.xaml"
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
            
            #line 13 "..\..\WindowTransferToBankAccount.xaml"
            ((HomeWork_16.WindowTransferToBankAccount)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowTransferToBankAccount_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbBankAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbBankAccounts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\WindowTransferToBankAccount.xaml"
            this.cbBankAccounts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbBankAccounts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.slSum = ((System.Windows.Controls.Slider)(target));
            
            #line 48 "..\..\WindowTransferToBankAccount.xaml"
            this.slSum.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slSum_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 52 "..\..\WindowTransferToBankAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transfer);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 56 "..\..\WindowTransferToBankAccount.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

