using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace Lesson3_4_IsolatedStorage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void cp_SelectedColorChanged_1(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
           var color= cp.SelectedColorText;
            lbl_color.Content = color;
            lbl_color.Background = (Brush)new BrushConverter().ConvertFromString(cp.SelectedColor.ToString());
           // MessageBox.Show(color.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if ( MessageBox.Show("Do you realy want to save?", "Confirmation", MessageBoxButton.YesNo)==MessageBoxResult.No)
            {
                return;
            }
            var nn =  IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream isolatedtream = 
                new IsolatedStorageFileStream(@"UserSettings.set", FileMode.OpenOrCreate,nn);
            StreamWriter writer=new StreamWriter(isolatedtream);
            writer.WriteLine(cp.SelectedColor.ToString());
            writer.Close();
            isolatedtream.Close();
            MessageBox.Show("completed");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var nn = IsolatedStorageFile.GetUserStoreForAssembly();

            IsolatedStorageFileStream isolatedtream =
            new IsolatedStorageFileStream(@"UserSettings.set", FileMode.OpenOrCreate, nn);
            StreamReader reader = new StreamReader(isolatedtream);
            var x = reader.ReadToEnd();

            reader.Close();
            isolatedtream.Close();
            nn.Close();
         //   MessageBox.Show(x);
            lbl_color.Background = (Brush)new BrushConverter().ConvertFromString(x);
            cp.ToolTip =lbl_color.Background;
        }
    }
}
