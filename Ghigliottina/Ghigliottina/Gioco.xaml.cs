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
        public Gioco()
        {
            InitializeComponent();
            EntrataRiga1.Begin();
            EntratRiga2.Begin();
            EntrataRiga3.Begin();
            EntrataRiga4.Begin();
            EntrataRiga5.Begin();
        }
        
    }
}