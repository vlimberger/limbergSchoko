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

namespace Limberger_Schokofabrik
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Limberger_Schokofabrik.SchokoVerwaltungDataSet schokoVerwaltungDataSet = ((Limberger_Schokofabrik.SchokoVerwaltungDataSet)(this.FindResource("schokoVerwaltungDataSet")));
            // Lädt Daten in Tabelle "Schokosorten". Sie können diesen Code nach Bedarf ändern.
            Limberger_Schokofabrik.SchokoVerwaltungDataSetTableAdapters.SchokosortenTableAdapter schokoVerwaltungDataSetSchokosortenTableAdapter = new Limberger_Schokofabrik.SchokoVerwaltungDataSetTableAdapters.SchokosortenTableAdapter();
            schokoVerwaltungDataSetSchokosortenTableAdapter.Fill(schokoVerwaltungDataSet.Schokosorten);
            System.Windows.Data.CollectionViewSource schokosortenViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("schokosortenViewSource")));
            schokosortenViewSource.View.MoveCurrentToFirst();
        }
    }
}
