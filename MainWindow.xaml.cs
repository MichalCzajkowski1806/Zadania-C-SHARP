using System;
using System.Collections.Generic;
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
using Geometria;
using ExtensionMethods;

namespace Zadanie_B
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKula_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Kula k1 = new Kula("Kuleczka", 4, 12, 3.5);
 
                lblWyswietlanie.Content = k1.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Błędne dane!");
            }
        }

        private void btnStozek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Stozek s1 = new Stozek("Stożeczek", 2, 5, 1.5, 4);

                lblWyswietlanie.Content = s1.ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Błędne dane!");
            }
        }

        private void btnLista_Click(object sender, RoutedEventArgs e)
        {
            Stozek s1 = new Stozek("Stożek", 2, 4, 2.5, 5);
            Kula k1 = new Kula("Kuleczka", 3, 1, 3.5);
            Kula k2 = new Kula("Kulka", 4, 3, 1.5);
            Student st1 = new Student("Marcin", "Neinman");
            Student st2 = new Student("Barbara", "Jonik");
            Student st3 = new Student("Marek", "Piktalski");
            List<IWyswietl> figury = new List<IWyswietl>() { st1, st2, st3, k1, k2, s1 };
            figury.Sort();
            foreach (var item in figury)
            {
                lstBryly.Dodaj(item.PobierzIdentyfikator());
            }
        }
        private void btnZwieksz_Click(object sender, RoutedEventArgs e)
        {
            Kula k1 = new Kula("Kuleczka", 3, 1, 3.5);
            Kula k2 = new Kula("Kulka", 4, 3, 1.5);

            lstZwieksz.Items.Add(k1 + k2);
            lstZwieksz.Items.Add(k1 - k2);
            lstZwieksz.Items.Add(++k2);
        }
    }
}
namespace ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static void Dodaj(this ListBox lista, string obiekt)
        {
            lista.Items.Add(obiekt);
        }
    }
}
