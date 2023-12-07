using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace snookerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Versenyzők> versenyzok = new List<Versenyzők>();
        public MainWindow()
        {
            InitializeComponent();
            loadVersenyzok("snooker.txt");
            comboboxFeltoltes();
        }
        public void loadVersenyzok(string eleresiUt)
        {
            bool elsosor = false;
            var betoltottSorok = File.ReadAllLines(eleresiUt);
            foreach (var item in betoltottSorok)
            {
                if (elsosor)
                {
                versenyzok.Add(new Versenyzők(item));
                }
                else
                {
                    elsosor = true;
                }
            }
        }

        private void btnF3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"3. Feladat: A világranglistán {versenyzok.Count} versenyző szerepel");
        }

        private void btnF4_Click(object sender, RoutedEventArgs e)
        {
            List<double> atlagGBP = new List<double>();

            for (int i = 0; i < versenyzok.Count; i++)
            {
                atlagGBP.Add(versenyzok[i].Nyeremeny);
            }
            MessageBox.Show($"4. feladat: A versenyzők átlagosan {Math.Round(atlagGBP.Average(),2)} fontot kerestek");
        }
        private void comboboxFeltoltes()
        {
            List<string> orszgok = new List<string>();
            foreach (var item in versenyzok)
            {
                orszgok.Add(item.Orszag);
            }
            orszgok.Sort();
            foreach (var item in orszgok.Distinct())
            {
                cbOrszag.Items.Add(item);
            }
        }
    }
}
