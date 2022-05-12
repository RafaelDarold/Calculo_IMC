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

namespace Calculo_IMC
{
    /// <summary>
    /// Lógica interna para ImcWindow1.xaml
    /// </summary>
    public partial class ImcWindow1 : Window
    {
        public ImcWindow1()
        {
            InitializeComponent();
            Loaded += ImcWindow_Loaded; ;
        }

        private void ImcWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Txt_peso.Focus();
        }


        private void Txt_altura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                Txt_altura.Focus();
        }


        private void bt_calcular_click(object sender, RoutedEventArgs e)
        {
            double peso, altura, resultado;
            peso = Convert.ToDouble(Txt_peso.Text);
            altura = Convert.ToDouble(Txt_altura.Text);

            resultado = peso / (altura * altura);
            Txt_imc.Text = resultado.ToString();
        }

        private void bt_sair_imc_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
                Txt_peso.Focus();
        }

        private void bt_limpar_Click(object sender, RoutedEventArgs e)
        {
            Txt_peso.Clear();
            Txt_altura.Clear();
            Txt_imc.Clear();

            Txt_peso.Focus();
        }
    }
}
