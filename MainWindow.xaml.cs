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

namespace Calculo_IMC
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            txt_login.Focus();
        }

        private void txt_login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_entrar_Click(object sender, RoutedEventArgs e)
        {
            string senha = pw_senha.Password.ToString();
            string login = txt_login.Text;

            if (login == "R.Darold" && senha == "27261010")
            {
                MessageBox.Show("usuario logado");
                ImcWindow1 Imc = new ImcWindow1();
                Imc.Show();
                this.Close();
            }
            else
                MessageBox.Show("usuario desconhecido");
        }

        private void bt_sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                pw_senha.Focus();
            }
        }
    }
}
