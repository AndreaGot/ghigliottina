using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;


namespace Ghigliottina
{
    public partial class Vittoria : PhoneApplicationPage
    {
        public Vittoria()
        {
            InitializeComponent();
        }

        private void ShareNewsArticle(string message)
        {
            ShareStatusTask sst = new ShareStatusTask();
            sst.Status = message;
            sst.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShareNewsArticle("Ho giocato a #LaGhigliottina e ho vinto! Credi di saper fare di meglio?");
        }
    }
}