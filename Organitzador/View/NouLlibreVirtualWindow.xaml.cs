using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Organitzador.View
{
    /// <summary>
    /// Lógica de interacción para NouLlibreVirtualWindow.xaml
    /// </summary>
    public partial class NouLlibreVirtualWindow : Window
    {
        public NouLlibreVirtualWindow()
        {
            InitializeComponent();
        }

        private void btn_seleccionar_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Mobi Files (.mobi)|*.mobi|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            openFileDialog1.ShowDialog();
        }
    }
}
