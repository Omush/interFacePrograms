using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int iloscKot = 0;
        public int iloscPaczek = 0;
        public int iloscFarba = 0;
        public int iloscRower = 0;
        public int kwotaKot = 20;
        public int kwotaPaczek = 40;
        public int kwotaFarba = 60;
        public int kwotaRower = 80;

        // zmien saldo + jedno przejscie ( klikniecie ma generować 2 doli) 

        public int saldo = 0;


        DispatcherTimer progressTimerKot;
        DispatcherTimer progressTimerPaczek;
        DispatcherTimer progressTimerFarba;
        DispatcherTimer progressTimerRower;
        public MainWindow()
        {
            progressTimerKot = new DispatcherTimer();
            progressTimerKot.Interval = TimeSpan.FromMilliseconds(10);
            progressTimerKot.Tick += ProgresBarTimerElapsedKot;
            progressTimerPaczek = new DispatcherTimer();
            progressTimerPaczek.Interval = TimeSpan.FromMilliseconds(10);
            progressTimerPaczek.Tick += ProgresBarTimerElapsedPaczek;
            progressTimerFarba = new DispatcherTimer();
            progressTimerFarba.Interval = TimeSpan.FromMilliseconds(10);
            progressTimerFarba.Tick += ProgresBarTimerElapsedFarba;
            progressTimerRower = new DispatcherTimer();
            progressTimerRower.Interval = TimeSpan.FromMilliseconds(10);
            progressTimerRower.Tick += ProgresBarTimerElapsedRower;
            InitializeComponent();


        }

        public void Generuj(TextBlock a, object sender)
        {
            // rzecz++;
            var button = sender as Button;
            if (button.Name == "Kot")
            {
                saldo++;
                a.Text = $"Ilosc: { iloscKot}";
                Saldo.Text = $"Saldo: {saldo}$";
            }
            if (button.Name == "Paczek")
            {
                saldo += 2;
                a.Text = $"Ilosc: { iloscPaczek}";
                Saldo.Text = $"Saldo: {saldo}$";
            }
            if (button.Name == "Farba")
            {
                saldo += 5;
                a.Text = $"Ilosc: { iloscFarba}";
                Saldo.Text = $"Saldo: {saldo}$";
            }
            if (button.Name == "Rower")
            {
                saldo += 7;
                a.Text = $"Ilosc: { iloscRower}";
                Saldo.Text = $"Saldo: {saldo}$";
            }

            
        }
       

        private void ProgresBarTimerElapsedKot(object sender, EventArgs e)
        {
            prb_Kot.Value++;
            if (prb_Kot.Value == prb_Kot.Maximum)
            {
                prb_Kot.Value = 0;
                saldo += iloscKot;
                Saldo.Text = $"Saldo: { saldo}$";
                //  Update();
            }
        }
        private void ProgresBarTimerElapsedPaczek(object sender, EventArgs e)
        {
            prb_Paczek.Value++;
            if (prb_Paczek.Value == prb_Paczek.Maximum)
            {
                prb_Paczek.Value = 0;
                saldo += iloscPaczek;
                Saldo.Text = $"Saldo: { saldo}$";
                //Update();
            }
        }
        private void ProgresBarTimerElapsedFarba(object sender, EventArgs e)
        {
            prb_Farba.Value++;
            if (prb_Farba.Value == prb_Farba.Maximum)
            {
                prb_Farba.Value = 0;
                saldo += iloscFarba;
                Saldo.Text = $"Saldo: { saldo}$";
                //Update();
            }
        }
        private void ProgresBarTimerElapsedRower(object sender, EventArgs e)
        {
            prb_Rower.Value++;
            if (prb_Rower.Value == prb_Rower.Maximum)
            {
                prb_Rower.Value = 0;
                saldo += iloscRower;
                Saldo.Text = $"Saldo: { saldo}$";
                //Update();
            }
        }

        private void btn_Kot_Kup(object sender, RoutedEventArgs e)
        {
            Generuj(TextKot, Kot);
        }
        private void btn_kot_UP(object sender, RoutedEventArgs e)
        {
            upgrade(ref kwotaKot, TextKot, _Kot, ref saldo, progressTimerKot, ref iloscKot);
        }
       
        //gen nie kup
        private void btn_Paczek_Kup(object sender, RoutedEventArgs e)
        {
            Generuj(TextPaczek, Paczek);
        }
        private void btn_Paczek_UP(object sender, RoutedEventArgs e)
        {
            upgrade(ref kwotaPaczek, TextPaczek, _Paczek, ref saldo, progressTimerPaczek, ref iloscPaczek);
        }

        private void btn_Kup_Farba(object sender, RoutedEventArgs e)
        {
            Generuj(TextFarba, Farba);
        }
        private void btn_Farba_UP(object sender, RoutedEventArgs e)
        {
            upgrade(ref kwotaFarba, TextFarba, _Farba, ref saldo, progressTimerFarba,ref iloscFarba);
        }
        void upgrade(ref int kwota, TextBlock text, Button button, ref int saldo, DispatcherTimer timer, ref int rzecz)
        {

            //   Saldo.Text = $"Saldo: {saldo}";
            if (saldo >= kwota)
            {
                saldo -= kwota;
                kwota += kwota;
                button.Content = $"x1         {kwota}$";
                text.Text = $"Ilosc: { ++rzecz}";
                //  Update();
                if (!timer.IsEnabled)
                {
                    timer.Start();
                }
                else
                {
                    timer.Interval -= TimeSpan.FromMilliseconds(2);
                }
            }

        }

        private void btn_Kup_Rower(object sender, RoutedEventArgs e)
        {
            Generuj(TextRower, Rower);
        }
        private void btn_Rower_UP(object sender, RoutedEventArgs e)
        {
            upgrade(ref kwotaRower, TextRower, _Rower, ref saldo, progressTimerRower, ref iloscRower);
        }

        private void btn_Paczek_Odblokuj(object sender, RoutedEventArgs e)
        {
            if (saldo >= 60)
            {
                Paczek.Visibility = Visibility.Visible;
                _Paczek.Visibility = Visibility.Visible;
                OdblokujPaczek.Visibility = Visibility.Hidden;
                OdblokujPaczek.IsEnabled = false;
                saldo -= 60;

            }
        }

        private void btn_Farbe_Odblokuj(object sender, RoutedEventArgs e)
        {
            if (saldo > 260)
            {
                Farba.Visibility = Visibility.Visible;
                _Farba.Visibility = Visibility.Visible;
                OdblokujFarba.Visibility = Visibility.Hidden;
                OdblokujFarba.IsEnabled = false;
                saldo -= 260;
            }
        }

        private void btn_Rower_Odblokuj(object sender, RoutedEventArgs e)
        {
            if (saldo > 440)
            {
                Rower.Visibility = Visibility.Visible;
                _Rower.Visibility = Visibility.Visible;
                OdblokujRower.Visibility = Visibility.Hidden;
                OdblokujRower.IsEnabled = false;
                saldo -= 440;
            }
        }
    }
}


