using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfAsyncRunnerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _file;
        public MainWindow()
        {
            InitializeComponent();
        }


        private async void RunClick(object sender, RoutedEventArgs e)
        {
            ExitCode.Content = await Process.Start(_file);

            //ExitCode.Content = await Task.Run(() =>
            //    {
            //        var p = Process.Start(_file);
            //        p.WaitForExit();
            //        return p.ExitCode;
            //    });
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Executables|*.exe";

            if (dialog.ShowDialog() == true)
            {
                _file = dialog.FileName;
            }
        }
    }
}
