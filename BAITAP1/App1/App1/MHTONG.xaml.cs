﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MHTONG : ContentPage
    {
        public MHTONG()
        {
            InitializeComponent();
        }
        private void cmdtinhtong_Clicked(object sender, EventArgs e)
        {
            double so1, so2, tong;
            so1 = double.Parse(txtsoa.Text);
            so2 = double.Parse(txtsob.Text);
            tong = so1 + so2;
            txttong.Text = tong.ToString();
        }
        
    }
}