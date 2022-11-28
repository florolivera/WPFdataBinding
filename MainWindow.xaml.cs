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

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        /*de la clase persona, definimos el nombre y edad que van a estar ingresados
        por defecto*/
        Person person = new Person { Name = "Florencia", Age = 21 };
        
        //se inicializa la ventana dandole como contexto lo que tenemos en la clase person 
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        //funcion button click para que cuando demos click al boton aparezca un cartel que diga el nombre y la edad seteada
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }
    }

    
}
