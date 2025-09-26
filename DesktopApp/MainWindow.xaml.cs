using DesktopApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using SbRf.Gestao.Infra.Sqlite.Context;
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

namespace DesktopApp
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var produtoWindow = App.Services.GetRequiredService<ProdutoWindow>();
            produtoWindow.DataContext = App.Services.GetRequiredService<ProdutoViewModel>();
            produtoWindow.ShowDialog();
        }
    }
}
