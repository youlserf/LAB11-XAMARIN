﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewOperaciones : ContentPage
    {
        public ViewOperaciones()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.ViewModelOperaciones();
        }

        
    }
}