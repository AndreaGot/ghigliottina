﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Ghigliottina
{
    public partial class Sconfitta : PhoneApplicationPage
    {
        public Sconfitta()
        {
            InitializeComponent();

            txtRisposta.Text = PhoneApplicationService.Current.State["risp"].ToString();

        }
    }
}