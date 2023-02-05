using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lesson3_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtResult.FontSize = 25;
            btnStart.FontSize = 25;
        }

        private static double FindLastFibonacciNumber(object number)
        {
            if (number is not int) { throw new ArgumentNullException(); };
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Func<int, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            return fib.Invoke((int)number);
        }


        private  void btnStart_Click(object sender, RoutedEventArgs e)
        {
            var task = new Task<double>(FindLastFibonacciNumber, 41, TaskCreationOptions.LongRunning);
            task.ContinueWith((t) =>
            { txtResult.Text = t.Result.ToString(); }, TaskScheduler.FromCurrentSynchronizationContext()
            ) ;
            task.Start();
            //MessageBox.Show(task.Result.ToString());
        }
    }
}
