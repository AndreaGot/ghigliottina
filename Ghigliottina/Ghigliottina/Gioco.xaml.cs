using System;
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
    public partial class Gioco : PhoneApplicationPage
    {

        string[,] giuste = new string[1, 5];
        string[,] errate = new string[1, 5];

        string[] risp = new string[5];

        public Gioco()
        {
            InitializeComponent();
           

        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}