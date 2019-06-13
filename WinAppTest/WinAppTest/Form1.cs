using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtNo1.Text);
            int Num2 = int.Parse(txtNo2.Text);
            int Sum = Num + Num2;
            txtOutput.Text = Sum.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtNo1.Text);
            int Num2 = int.Parse(txtNo2.Text);
            int Sum = Num - Num2;
            txtOutput.Text = Sum.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtNo1.Text);
            int Num2 = int.Parse(txtNo2.Text);
            int Sum = Num * Num2;
            txtOutput.Text = Sum.ToString();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(txtNo1.Text);
            int Num2 = int.Parse(txtNo2.Text);
            int Sum = Num % Num2;
            txtOutput.Text = Sum.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
