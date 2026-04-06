using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // ── 輸入驗證 ──
            if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            { MessageBox.Show("請輸入有效的房屋總價", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!double.TryParse(txtDown.Text, out double downVal) || downVal <= 0)
            { MessageBox.Show("請輸入有效的自備款", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!double.TryParse(txtRate.Text, out double annualRate) || annualRate <= 0)
            { MessageBox.Show("請輸入有效的貸款利率", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!int.TryParse(txtTerm.Text, out int termYears) || termYears <= 0)
            { MessageBox.Show("請輸入有效的貸款年限", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int graceYears = 0;
            if (!string.IsNullOrWhiteSpace(txtGrace.Text))
                if (!int.TryParse(txtGrace.Text, out graceYears) || graceYears < 0)
                { MessageBox.Show("寬限期請輸入正整數或留空", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // ── 計算自備款金額 ──
            double downAmt = rbPercent.Checked ? price * downVal / 100.0 : downVal;
            double loan = price - downAmt;

            if (loan <= 0)
            { MessageBox.Show("自備款不可超過房屋總價", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // ── 房貸公式 ──
            double r = annualRate / 100.0 / 12.0;
            int n = termYears * 12;
            int graceN = graceYears * 12;

            double monthly, totalPay, totalInt, int1, pri1;

            if (r == 0)
            {
                monthly = loan / n;
                int1 = 0;
                pri1 = monthly;
                totalPay = monthly * n;
                totalInt = 0;
            }
            else
            {
                int1 = loan * r;
                double fullMonthly = loan * r * Math.Pow(1 + r, n) / (Math.Pow(1 + r, n) - 1);

                if (graceN > 0)
                {
                    int remainN = n - graceN;
                    double postMo = loan * r * Math.Pow(1 + r, remainN) / (Math.Pow(1 + r, remainN) - 1);
                    monthly = int1;
                    pri1 = 0;
                    totalPay = int1 * graceN + postMo * remainN;
                    totalInt = totalPay - loan;
                }
                else
                {
                    monthly = fullMonthly;
                    pri1 = monthly - int1;
                    totalPay = monthly * n;
                    totalInt = totalPay - loan;
                }
            }

            // ── 顯示結果（使用 txtOut... 寫入，對應你的 Label 控件）──
            txtOutLoan.Text = FormatNT(loan);
            txtOutMonthly.Text = FormatNT(monthly) + (graceYears > 0 ? "（寬限期）" : "");
            txtOutInt1.Text = FormatNT(int1);
            txtOutPri1.Text = FormatNT(pri1);
            txtOutTotalInt.Text = FormatNT(totalInt);
            txtOutTotal.Text = FormatNT(totalPay);
        }

        private static string FormatNT(double v) =>"NT$ " + v.ToString("N2");
    }
}
