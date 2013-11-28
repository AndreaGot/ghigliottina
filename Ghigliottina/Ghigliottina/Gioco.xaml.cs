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


        string[,] giuste = new string[40, 5] { { "Automatico", "Mentale", "Porta", "Posto", "Traffico" }, { "Numero", "Posto", "Anno", "Amore", "Levi" }, { "Contro", "Unico", "Orario", "Sesto", "Colpa" }, { "Codice", "Bancario", "Professionale", "Ingrediente", "Diario" }, { "Lusso", "Spese", "Riunione", "Regolamento", "Portiere" }, { "Mondo", "Prendere", "Insieme", "Gioco", "Prima" }, { "Vigile", "Testa", "Perdita", "Secco", "Colpo" }, { "Disco", "Fuori", "Senso", "Spettacolo", "Ridotto" }, { "Acqua", "Tempo", "Media", "Piano", "Vapore" }, { "Percorso", "Classici", "Terminare", "Settore", "Registrazione" }, { "Amaro", "Lancio", "Bianco", "Muovere", "Integrale" }, { "Colpo", "Saltare", "Cavallo", "Paglia", "Titoli" }, { "Nero", "Sacco", "Uomo", "Occhi", "Matto" }, { "Altri", "Sette", "Acqua", "Guccini", "Giro" }, { "Servizio", "Dare", "Arteria", "Verbale", "Urgente" }, { "Codice", "Settore", "Rilancio", "Massa", "Ministro" }, { "Situazione", "Uomo", "Assente", "Orologio", "Prendere" }, { "The", "Foto", "Matrimonio", "Sommario", "Formula" }, { "Omaggio", "Indiscusso", "Casinò", "Statistico", "Sangue" }, { "Bambini", "Giro", "Pesce", "Prima", "Giornale" }, { "Tartufi", "Pistola", "Sangue", "Corso", "Slitta" }, { "Donna", "Bergamotto", "Assassino", "Intenso", "Cinque" }, { "Pantaloni", "Febbre", "Vapore", "Pazzo", "Dondolo" }, { "Stare", "Vita", "Fuoco", "Testa", "Colpo" }, { "Stato", "Telefono", "Aria", "Cuore", "Basso" }, { "Magazine", "Giochi", "Patente", "Portatile", "Personale" }, { "Favore", "Fermo", "Bianco", "Domanda", "Croce" }, { "Barbera", "Codice", "Ottobre", "Conto", "Toro" }, { "Muro", "Strumento", "Tecnico", "Riproduzione", "Timbro" }, { "Cubo", "Ventuno", "Comico", "Matto", "Tratto" }, { "Sole", "Tavola", "Lavoro", "Testa", "Auto" }, { "Sole", "Palazzo", "Bacio", "Spaghetti", "Dopo" }, { "Cotta", "Catena", "Coste", "Ferro", "Salute" }, { "Folle", "Canto", "Angolo", "Improvviso", "Orchi" }, { "Pugile", "Fare", "Numero", "Magico", "Metro" }, { "Cassetta", "Salame", "Latte", "Vino", "Buono" }, { "Sale", "Zucchero", "Pistola", "Nera", "Brillante" }, { "Fresco", "Giro", "Rosso", "Scatola", "Vapore" }, { "Gioco", "Slancio", "Scuola", "Distesa", "Vetro" }, { "Ore", "Vista", "Bagno", "Servizio", "Numero" } };
        string[,] errate = new string[40, 5] { { "Manuale", "Mentina", "Finestra", "Sedia", "Incrocio" }, { "Lettera", "Sedia", "Mese", "Odio", "Metti" }, { "Favore", "Multiplo", "Orologio", "Terzo", "Colpo" }, { "Parola", "Banchiere", "Operaio", "Elemento", "Agenda" }, { "Povertà", "Costi", "Incontro", "Regole", "Attacco" }, { "Terra", "Lasciare", "Solo", "Partita", "Dopo" }, { "Carabiniere", "Piedi", "Sconfitta", "Umido", "Colpa" }, { "Cubo", "Dentro", "Sensato", "Commedia", "Intero" }, { "Terra", "Ora", "Medio", "Veloce", "Elettrico" }, { "Strada", "Moderni", "Cominciare", "Ambito", "Iscrizione" }, { "Dolce", "Presa", "Nero", "Vincere", "Derivata" }, { "Botta", "Cadere", "Alfiere", "Fieno", "Azioni" }, { "Bianco", "Secco", "Donna", "Occhio", "Jolly" }, { "Questo", "Mezzo", "Vino", "De Gregori", "Giri" }, { "Battuta", "Ricevere", "Vena", "Multa", "Ordinario" }, { "Numero", "Ambito", "Chiamata", "Masso", "Segretario" }, { "Caso", "Donna", "Presente", "Cronometro", "Lasciare" }, { "Caffè", "Video", "Unione", "Indice", "Miscela" }, { "Regalo", "Discusso", "Gioco", "Probabilistico", "Vino" }, { "Ragazzi", "Tondo", "Carne", "Seconda", "Rivista" }, { "Funghi", "Fucile", "Vino", "Corsa", "Scivola" }, { "Uomo", "Chinotto", "Killer", "Intensa", "Sette" }, { "Cintura", "Influenza", "Acqua", "Sano", "Poltrona" }, { "Andare", "Fianchi", "Brace", "Croce", "Colpe" }, { "Nazione", "Cellulare", "Opera", "Centro", "Tenore" }, { "Network", "Film", "Carta", "Fisso", "Riservato" }, { "Piacere", "Mobile", "Nero", "Risposta", "Testa" }, { "Hanna", "Numero", "Novembre", "Bolletta", "Corna" }, { "Mattone", "Attrezzo", "Artistico", "Copia", "Firma" }, { "Sfera", "Trentuno", "Triste", "Sano", "Ispirato" }, { "Luna", "Tavolo", "Svago", "Croce", "Moto" }, { "Compagnia", "Castello", "Nocciola", "Bucatini", "Prima" }, { "Amore", "Corda", "Litorali", "Ferrata", "Saluti" }, { "Pazzo", "Verso", "Angoli", "Subito", "Orche" }, { "Ring", "Dire", "Cifra", "Fatato", "Chilometro" }, { "DVD", "Prosciutto", "Caffè", "Acqua", "Cattivo" }, { "Scende", "Jovanotti", "Fucile", "Bianca", "Opaca" }, { "Sudato", "Tondo", "Verde", "Contenitore", "Cavallo" }, { "Scherzo", "Salto", "Campanella", "Sdraiata", "Sabbia" }, { "Minuti", "Chiusa", "Spiaggia", "Battuta", "Codice" } };
        string[] risposte = new string[40] {"blocco", "primo", "senso", "segreto", "condominio", "visione", "occhio", "orario", "cottura", "studi", "riso", "coda", "gatto", "vite", "comunicazione", "turismo", "polso", "rito", "campione", "occhiata", "cane", "profumo", "cavallo", "cerchio", "colpo", "computer", "punto", "osso", "suono", "dado", "posto", "mezzanotte", "maglia", "paradiso", "quadrato", "pane", "acqua", "tonno", "campana", "camera"};
        int[] risp = new int[5];
        int index;

        public Gioco()
        {
            Random r = new Random();
            InitializeComponent();
          
            risp[0] = r.Next(0,100);
            risp[1] = r.Next(0, 100);
            risp[2] = r.Next(0, 100);
            risp[3] = r.Next(0, 100);
            risp[4] = r.Next(0, 100);
            index = r.Next(0,39);

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
                button.Content = giuste[index, 0];
                button1.Content = errate[index, 0];
            }
            else
            {
                button.Content = errate[index, 0];
                button1.Content = giuste[index, 0];
            }



            if (risp[1]%2 == 1)
            {
                button2.Content = giuste[index, 1];
                button3.Content = errate[index, 1];
            }
            else
            {
                button2.Content = errate[index, 1];
                button3.Content = giuste[index, 1];
            }



            if (risp[2]%2 == 1)
            {
                button4.Content = giuste[index, 2];
                button5.Content = errate[index, 2];
            }
            else
            {
                button4.Content = errate[index, 2];
                button5.Content = giuste[index, 2];
            }



            if (risp[3]%2 == 1)
            {
                button6.Content = giuste[index, 3];
                button7.Content = errate[index, 3];
            }
            else
            {
                button6.Content = errate[index, 3];
                button7.Content = giuste[index, 3];
            }



            if (risp[4]%2 == 1)
            {
                button8.Content = giuste[index, 4];
                button9.Content = errate[index, 4];
            }
            else
            {
                button8.Content = errate[index, 4];
                button9.Content = giuste[index, 4];
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

            if (risposte[index].ToUpper() == (textBox.Text).ToUpper())
                NavigationService.Navigate(new Uri("/Vittoria.xaml", UriKind.Relative));
            else
            {
                NavigationService.Navigate(new Uri("/Sconfitta.xaml", UriKind.Relative));
                PhoneApplicationService.Current.State["risp"] = risposte[index].ToString();
            }

        }

        private void Cancella(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}