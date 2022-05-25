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

namespace JosePutoAmoWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> rutasRecursos;
        string prefijoRuta = "..\\..\\Imagenes\\";

        public MainWindow()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            this.rutasRecursos = new List<string>();
            DirectoryInfo directorio;
            directorio = new DirectoryInfo(new Uri("..\\..\\Imagenes\\", UriKind.Relative).ToString());
            FileInfo[] archivos = directorio.GetFiles();
            System.Diagnostics.Debug.WriteLine("Archivos encontrados: " + archivos.Length);
            for (int i=0; i< archivos.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(archivos[i].ToString());
                this.rutasRecursos.Add(prefijoRuta + archivos[i].ToString());
                this.sliderImagenes.Maximum = this.rutasRecursos.Count -1;
            }
        }

        private void SliderImagenes_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int indice = (int)Math.Round(this.sliderImagenes.Value);
            imgElegida.Source = new BitmapImage(new Uri(this.prefijoRuta + rutasRecursos[indice], UriKind.Relative));
        }
    }
}
