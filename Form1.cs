using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fromHexademicalRB_CheckedChanged(object sender, EventArgs e)
        {
            if (fromBinaryRB.Checked)
            {
                toBinaryRB.Enabled = false;
                toDecimalRB.Enabled = true;
                toHexadecimalRB.Enabled = true;
                if (toBinaryRB.Checked)
                {
                    toBinaryRB.Checked = false;
                    toDecimalRB.Checked = true;
                }
            }
            if (fromDecimalRB.Checked)
            {
                toBinaryRB.Enabled = true;
                toDecimalRB.Enabled = false;
                toHexadecimalRB.Enabled = true;
                if (toDecimalRB.Checked)
                {
                    toBinaryRB.Checked = true;
                    toDecimalRB.Checked = false;
                }
            }
            if (fromHexademicalRB.Checked)
            {
                toBinaryRB.Enabled = true;
                toDecimalRB.Enabled = true;
                toHexadecimalRB.Enabled = false;
                if (toHexadecimalRB.Checked)
                {
                    toBinaryRB.Checked = true;
                    toHexadecimalRB.Checked = false;
                }
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (fromTb.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите значение в поле число, которое вы хотите конвертировать.");
                return;
            }
            if (fromBinaryRB.Checked)
            {
                int binary = 0;
                try
                {
                    binary = int.Parse(fromTb.Text);
                }
                catch
                {
                    MessageBox.Show("Введите в поле двоичное число.");
                    return;
                }
                if (!IsBinary(binary.ToString())) {
                    return;
                }
                if (toDecimalRB.Checked)
                {
                    toTB.Text = fromBtoD(binary).ToString();
                } else if (toHexadecimalRB.Checked)
                {
                    toTB.Text = fromBtoHex(binary.ToString());
                }
            } else if (fromDecimalRB.Checked)
            {
                int dec = 0;
                try
                {
                    dec = int.Parse(fromTb.Text);
                }
                catch
                {
                    MessageBox.Show("Введите в поле простое число, без слов, символов и знаков пунктуации.");
                    return;
                }
                if (!isDecimal(dec.ToString()))
                {
                    return;
                }
                if (toBinaryRB.Checked)
                {
                    toTB.Text = fromDtoB(dec);
                }
                else if (toHexadecimalRB.Checked)
                {
                    toTB.Text = fromDtoH(dec);
                }
            } else if (fromHexademicalRB.Checked)
            {
                string hex = fromTb.Text;
                if (!isHex(hex.ToString()))
                {
                    return;
                }
                if (toBinaryRB.Checked)
                {
                    toTB.Text = fromHtoB(hex);
                }
                else if (toDecimalRB.Checked)
                {
                    toTB.Text = fromHtoD(hex);
                }
            } else
            {
                return;
            }
        }

        private int fromBtoD(int binaryNumber)
        {
            int decimalValue = 0;
            int base1 = 1;
            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }

        private string fromBtoHex(string binaryNumber)
        {
            if (string.IsNullOrEmpty(binaryNumber))
                return binaryNumber;

            StringBuilder result = new StringBuilder(binaryNumber.Length / 8 + 1);

            int mod4Len = binaryNumber.Length % 8;
            if (mod4Len != 0)
            {
                binaryNumber = binaryNumber.PadLeft(((binaryNumber.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binaryNumber.Length; i += 8)
            {
                string eightBits = binaryNumber.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }

        private string fromDtoB(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        private string fromDtoH(int decimalNumber)
        {
            return string.Format("{0:x}", decimalNumber);
        }

        private string fromHtoB(string hex)
        {
            string binarystring = String.Join(String.Empty,
                hex.Select(
                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                )
            );
            return binarystring;
        }

        private string fromHtoD(string hex)
        {
            int int_value = Convert.ToInt32(hex, 16);
            return int_value.ToString();
        }

        private bool IsBinary(string binaryNumber)
        {
            Regex rgx = new Regex(@"^[01]+$");
            if (!rgx.IsMatch(binaryNumber))
            {
                MessageBox.Show("Введите в поле двоичное число.");
                return false;
            }
            return true;
        }

        private bool isDecimal(string decimalNumber)
        {
            Regex rgx = new Regex("^[0-9]+$");
            if (!rgx.IsMatch(decimalNumber))
            {
                MessageBox.Show("Введите в поле обычное число.");
                return false;
            }
            return true;
        }

        private bool isHex(string hexNumber)
        {
            Regex rgx = new Regex("^[A-Fa-f0-9]*$");
            if (!rgx.IsMatch(hexNumber))
            {
                MessageBox.Show("Введите в поле шеснадцатеричное число.");
                return false;
            }
            return true;
        }
    }
}
