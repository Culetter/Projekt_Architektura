using System;
using System.Windows.Forms;

namespace Projekt_Architektura
{
    public partial class Symulator : Form
    {
        public Symulator()
        {
            InitializeComponent();
        }

        private void firstNum_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            if (firstNum.Text.Length == 32) convertedFirstNum.Text = Conversion(firstNum.Text).ToString();
        }

        private void secondNum_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            if (secondNum.Text.Length == 32) convertedSecondNum.Text = Conversion(secondNum.Text).ToString();
        }

        private void firstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b') e.Handled = true;
        }
        private void secondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != '\b') e.Handled = true;
        }

        private void ValidateInput()
        {
            convertBtn.Enabled = firstNum.Text.Length == 32 && secondNum.Text.Length == 32;
        }

        private string Multiply(string multiplicand, string multiplier)
        {
            int count = multiplicand.Length;
            
            string A = "";
            char Qmin1 = '0';
            string M = multiplicand;

            char[] minCharM = M.ToCharArray();
            for (int i = 0; i < count; i++)
            {
                A += '0';
                minCharM[i] = minCharM[i] == '1' ? '0' : '1';
            }
            string minM = new string(minCharM);
            minM = Add(minM, "1");

            string Q = multiplier;

            do
            {
                if (Q[Q.Length - 1] == '1' && Qmin1 == '0')
                {
                    A = Add(A, minM);
                }
                else if (Q[Q.Length - 1] == '0' && Qmin1 == '1')
                {
                    A = Add(A, M);
                }

                Qmin1 = Q[Q.Length - 1];

                Q = A[A.Length - 1] + Q;
                Q = Q.Substring(0, Q.Length - 1);

                A = A[0] + A;
                A = A.Substring(0, A.Length - 1);

                count--;
            } while (count > 0);

            return A + Q;
        }

        private string Add(string a, string b)
        {
            int maxLength = Math.Max(a.Length, b.Length);
            string result = "";
            int carry = 0;

            for (int i = 0; i < maxLength; i++)
            {
                int bitA = i < a.Length ? a[a.Length - 1 - i] - '0' : 0;
                int bitB = i < b.Length ? b[b.Length - 1 - i] - '0' : 0;

                int sum = bitA + bitB + carry;
                result = (sum % 2) + result;
                carry = sum / 2;
            }

            return result;
        }

        private bool Comparison(string a)
        {
            string binTwo = "010";

            if (a.Length > binTwo.Length)
            {
                for (int i = 0; i < a.Length - binTwo.Length; i++) binTwo = binTwo[0] + binTwo;
            }
            else if (binTwo.Length > a.Length)
            {
                for (int i = 0; i < binTwo.Length - a.Length; i++) a = a[0] + a;
            }

            if (string.CompareOrdinal(a, binTwo) >= 0) return true;
            
            return false;
        }

        private string Conversion(string bin)
        {
            if(IsZero(bin)) return "0";
            if(IsInfinity(bin)) return (bin[0] == '1' ? "-∞" : "∞");
            if (IsNaN(bin)) return "NaN";
            int sign = bin[0] == '0' ? 1 : -1;

            int exp = Convert.ToInt32(bin.Substring(1, 8), 2);

            double mantissa = 0.0;
            string m = bin.Substring(9);

            for (int i = 0; i < m.Length; i++)
                if (m[i] == '1')
                    mantissa += Math.Pow(2, -(i + 1));

            if (exp == 0)
                return (sign * mantissa * Math.Pow(2, -126)).ToString();

            return (sign * (1.0 + mantissa) * Math.Pow(2, exp - 127)).ToString();
        }
        private bool IsZero(string num) => num.Substring(1, 31) == new string('0', 31);
        private bool IsInfinity(string num) => num.Substring(1, 8) == new string('1', 8) && num.Substring(9) == new string('0', 23);
        private bool IsNaN(string num) => num.Substring(1, 8) == new string('1', 8) && num.Substring(9) != new string('0', 23);
        private void convertBtn_Click(object sender, EventArgs e)
        {
            const string bias = "10000001";

            string num1 = firstNum.Text;
            string num2 = secondNum.Text;

            if (IsZero(num1) || IsZero(num2))
            {
                resultBin.Text = "0" + new string('0', 8) + new string('0', 23);
                resultDeci.Text = "0";
                return;
            }

            if (IsInfinity(num1) || IsInfinity(num2))
            {
                resultBin.Text = (num1[0] == '1' ^ num2[0] == '1' ? "1" : "0") +
                                  new string('1', 8) + new string('0', 23);
                resultDeci.Text = (num1[0] == '1' ^ num2[0] == '1' ? "-∞" : "∞");
                return;
            }

            if (IsNaN(num1) || IsNaN(num2))
            {
                resultBin.Text = "0" + new string('1', 8) + "1" + new string('0', 22);
                resultDeci.Text = "NaN";
                return;
            }

            char signChar = num1[0] == num2[0] ? '0' : '1';

            string exponent1 = num1.Substring(1, 8);
            string exponent2 = num2.Substring(1, 8);

            string mantissa1 = "01" + num1.Substring(9);
            string mantissa2 = "01" + num2.Substring(9);

            string exponent = Add(Add(exponent1, exponent2), bias);

            string multipliedMantissa = Multiply(mantissa1, mantissa2);

            string integerPart = multipliedMantissa.Substring(0, 4);
            string mantissa = multipliedMantissa.Substring(multipliedMantissa.Length - 46, 23);

            while (Comparison(integerPart))
            {
                mantissa = integerPart[integerPart.Length - 1] + mantissa;
                mantissa = mantissa.Substring(0, 23);

                integerPart = integerPart.Substring(0, integerPart.Length - 1);

                exponent = Add(exponent, "1");
            }

            resultBin.Text = signChar + exponent + mantissa;
            resultDeci.Text = Conversion(resultBin.Text);
        }
    }
}