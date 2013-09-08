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


        string[,] giuste = new string[1, 5] {{ "giusto", "giusto", "giusto", "giusto", "giusto" }};
        string[,] errate = new string[1, 5] {{ "sbagliato", "sbagliato", "sbagliato", "sbagliato", "sbagliato" }};
        string[] risposte = new string[1] {"giusto"};
        int[] risp = new int[5];

        public Gioco()
        {
            Random r = new Random();
            InitializeComponent();
          
            risp[0] = r.Next(0,100);
            risp[1] = r.Next(0, 100);
            risp[2] = r.Next(0, 100);
            risp[3] = r.Next(0, 100);
            risp[4] = r.Next(0, 100);


            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;

            

            if (risp[0]%2 == 1)
            {
                button.Content = giuste[0, 0];
                button1.Content = errate[0, 0];
            }
            else
            {
                button.Content = errate[0, 0];
                button1.Content = giuste[0, 0];
            }



            if (risp[1]%2 == 1)
            {
                button2.Content = giuste[0, 1];
                button3.Content = errate[0, 1];
            }
            else
            {
                button2.Content = errate[0, 1];
                button3.Content = giuste[0, 1];
            }



            if (risp[2]%2 == 1)
            {
                button4.Content = giuste[0, 2];
                button5.Content = errate[0, 2];
            }
            else
            {
                button4.Content = errate[0, 2];
                button5.Content = giuste[0, 2];
            }



            if (risp[3]%2 == 1)
            {
                button6.Content = giuste[0, 3];
                button7.Content = errate[0, 3];
            }
            else
            {
                button6.Content = errate[0, 3];
                button7.Content = giuste[0, 3];
            }



            if (risp[4]%2 == 1)
            {
                button8.Content = giuste[0, 4];
                button9.Content = errate[0, 4];
            }
            else
            {
                button8.Content = errate[0, 4];
                button9.Content = giuste[0, 4];
            }

            EntrataRiga1.Begin();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (risp[0] % 2 == 1)
            {
                //evidenzia di verde
                Esci1dx.Begin();
            }
            else
            {
                //evidenzia di rosso
                Esci1sx.Begin();
            }

            button2.IsEnabled = true;
            button3.IsEnabled = true;
            EntrataRiga2.Begin();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (risp[1] % 2 == 1)
            {
                //evidenzia di verde
                Esci2dx.Begin();
            }
            else
            {
                //evidenzia di rosso
                Esci2sx.Begin();
            }

            button4.IsEnabled = true;
            button5.IsEnabled = true;

            EntrataRiga3.Begin();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (risp[2] % 2 == 1)
            {
                //evidenzia di verde
                Esci3dx.Begin();
            }
            else
            {
                //evidenzia di rosso
                Esci3sx.Begin();
            }

            button6.IsEnabled = true;
            button7.IsEnabled = true;

            EntrataRiga4.Begin();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (risp[3] % 2 == 1)
            {
                //evidenzia di verde
                Esci4sx.Begin();
            }
            else
            {
                //evidenzia di rosso
                Esci4dx.Begin();
            }

            button8.IsEnabled = true;
            button9.IsEnabled = true;

            EntrataRiga5.Begin();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            button6_Click(sender, e);
        }


        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (risp[4] % 2 == 1)
            {
                //evidenzia di verde
                Esci5dx.Begin();
            }
            else
            {
                //evidenzia di rosso
                Esci5sx.Begin();
            }

            SalitaRIsposta.Begin();

            Titolo.Text = "La tua risposta";   
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            button8_Click(sender, e);
        }




        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if(risposte[0] == textBox.Text)
                NavigationService.Navigate(new Uri("/Vittoria.xaml", UriKind.Relative));
            else
                NavigationService.Navigate(new Uri("/Sconfitta.xaml", UriKind.Relative));


        }

        private void Cancella(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}