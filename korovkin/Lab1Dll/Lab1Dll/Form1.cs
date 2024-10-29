using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTech;

namespace Lab1Dll
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        bool init = false;
        Client currentClient;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal creditAmount = Convert.ToDecimal(textBoxCreditAmount.Text);
            double creditDuration = Convert.ToDouble(textBoxCreditDuration.Text);
            decimal monthPayment = Convert.ToDecimal(textBoxMonthPayment.Text);
            List<decimal> accountList = new List<decimal>();
            string s ="";
            int i = 0;
            bool error = false;
            if (textBoxAccountList.Lines.Length > 0)
            {
                do
                {
                    s = textBoxAccountList.Lines[i];
                    if (s != string.Empty)
                    {
                     s= s.Replace('.', ',');
                        try
                        {
                            accountList.Add(Convert.ToDecimal(s));
                        }
                        catch
                        {
                            error = true;
                            MessageBox.Show("Ошибка");
                            break;
                        }
                    }
                    i++;
                }
                while (i<textBoxAccountList.Lines.Length&&s!=string.Empty);
            }
            if (!error)
            {
                currentClient = new Client(name, creditAmount, creditDuration, monthPayment, accountList);
                init = true;
                UpdateOutput(textBoxOutput, currentClient.GetClientDataText());
            } 
        }
        void UpdateOutput(TextBox tb,string s)
        {
            tb.Clear();
            tb.Text = s;
        }
        private void textBoxAccountList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.')&&(e.KeyChar!='-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCreditDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxMonthPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonReplenish_Click(object sender, EventArgs e)
        {
            if (init)
            {
                currentClient.ReplenishAccount(Convert.ToInt32(numericUpDownAmount.Value), Convert.ToDecimal(textBoxUpDown.Text));
                UpdateOutput(textBoxOutput, currentClient.GetClientDataText());
            }
        }

        private void textBoxUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonDeduce_Click(object sender, EventArgs e)
        {
            if (init)
            {
                currentClient.DeductAccount(Convert.ToInt32(numericUpDownAmount.Value), Convert.ToDecimal(textBoxUpDown.Text));
                UpdateOutput(textBoxOutput, currentClient.GetClientDataText());
            }
        }

        private void buttonMonthPayment_Click(object sender, EventArgs e)
        {
            if (init)
            {
                currentClient.DeduceMonthCreditPayment();
                UpdateOutput(textBoxOutput, currentClient.GetClientDataText());
            }
        }
    }
}
