using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace TrabalhoDeConversao
{
    public partial class FormConverte : Form
    {
        public FormConverte()
        {
            InitializeComponent();
            comboBoxBase.SelectedIndex = 0;
            comboBoxQualConverter.SelectedIndex = 0;
        }
        short[] basePos = new short[4] {10,8,2,16 };    
        string Hexa = "0123456789ABCDEF";
        string[] rejeita = new string[] { @"[^0-9]", @"[^0-7]", @"[^0-1]",@"^[a-zA-Z0-9]*$ "};
        string[] extenso = new string[] { "Decimal", "Octal", "Binário", "Hexadecimal" };      
        private string decimalToBase(long n, short b)
        {   
            string  resultado=string.Empty;
            while (n>=b)
            {      
                resultado = Convert.ToString(Hexa[Convert.ToInt16(n % b)])+resultado;
                n = n / b;
            }
          return  resultado= Convert.ToString(Hexa[Convert.ToInt16(n) % b]) + resultado;         
        }
        private long baseToDecimal(string n, short b)
        {
            double resultado=0;
            int contador = 0,posicao;   
            for (int i = n.Length - 1; i >= 0; i--)
            {
                posicao = Hexa.IndexOf(n[contador]);
                resultado = (posicao* Math.Pow(b, i)) +resultado;
                contador++;                          
            }
            return Convert.ToInt64(resultado);
        }
        private void buttonConverter_Click(object sender, EventArgs e)
        {
            if (textBoxValorConverter.Text == string.Empty)
                return;           
            if (Regex.IsMatch(textBoxValorConverter.Text, rejeita[comboBoxBase.SelectedIndex]))
            {
                MessageBox.Show("Valor fora da faixa do inteiro 64 bits ou contem digitos inválidos", "ERRO");
                return;
            }      
            long resultado = baseToDecimal(textBoxValorConverter.Text.ToUpper(), (basePos[comboBoxBase.SelectedIndex]));
            richTextBoxMostrar.AppendText(textBoxValorConverter.Text + " Convertido para  " +
            extenso[comboBoxBase.SelectedIndex] + " "+decimalToBase(resultado, basePos[comboBoxQualConverter.SelectedIndex])
            +Environment.NewLine);               
        }
    }
}
