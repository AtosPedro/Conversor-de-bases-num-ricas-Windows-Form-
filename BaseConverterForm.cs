using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConversorDeBases
{
    public partial class BaseConverterForm : Form
    {
        public BaseConverterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isValid = Validade();
            switch (isValid)
            {
                case "decimal":
                    DecimalConvert();
                    break;
                case "binário":
                    BinaryConvert();
                    break;
                case "hexa":
                    HexaConvert();
                    break;
                case "octal":
                    OctalConvert();
                    break;
                case "":
                    break;
            }
        }
        private string Validade()
        {
            bool inputDecimal = txtDecimal.Text != "";
            bool inputBinary = txtBinary.Text != "";
            bool inputHexa = txtHexa.Text != "";
            bool inputOctal = txtOctal.Text != "";

            if (inputDecimal && !inputBinary && !inputHexa && !inputOctal)
            {
                return "decimal";
            }
            else if (!inputDecimal && inputBinary && !inputHexa && !inputOctal)
            {
                return "binário";
            }
            else if (!inputDecimal && !inputBinary && inputHexa && !inputOctal)
            {
                return "hexa";
            }
            else if (!inputDecimal && !inputBinary && !inputHexa && inputOctal)
            {
                return "octal";
            }
            else
            {
                return "";
            }
        }
        private void DecimalConvert()
        {
            string decimalValue = txtDecimal.Text.Trim();
            txtBinary.Text = NumberConverter.Binary(decimalValue);
            txtHexa.Text = NumberConverter.Hexadecimal(decimalValue);
            txtOctal.Text = NumberConverter.Octal(decimalValue);
        }
        private void BinaryConvert()
        {
            string decimalValue = NumberConverter.BinaryToDecimal(txtBinary.Text.Trim());
            txtDecimal.Text = decimalValue;
            txtHexa.Text = NumberConverter.Hexadecimal(decimalValue);
            txtOctal.Text = NumberConverter.Octal(decimalValue);
        }
        private void HexaConvert()
        {
            string decimalValue = NumberConverter.HexToDecimal(txtHexa.Text.Trim());
            txtBinary.Text = NumberConverter.Binary(decimalValue);
            txtDecimal.Text = decimalValue;
            txtOctal.Text = NumberConverter.Octal(decimalValue);
        }
        private void OctalConvert()
        {
            string decimalValue = NumberConverter.OctalToDecimal(txtOctal.Text.Trim());
            txtBinary.Text = NumberConverter.Binary(decimalValue);
            txtHexa.Text = NumberConverter.Hexadecimal(decimalValue);
            txtDecimal.Text = decimalValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBinary.Text = "";
            txtDecimal.Text = "";
            txtOctal.Text = "";
            txtHexa.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string message = $"Conversor de bases numéricas\n\n" +
                             $"Desenvolvido por: Atos Pedro\n\n" +
                             $"Insira o numero que quer converter em seu respectivo campo e clique em converter, " +
                             $"que isso preencherá os outros campos com as respectivas bases convertidas";
            string caption = "Informações";
            MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK);
        }
    }
}
