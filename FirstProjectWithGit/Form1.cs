using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstProjectWithGit
{
    public partial class Form1 : Form
    {
        Operation operation = new Operation();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxResult.Text = operation.Add(Convert.ToDouble(txtBoxForFirstNumber.Text), Convert.ToDouble(txtBoxForSecondNumber.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод!");
                CLear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CLear();
        }

        private void CLear()
        {
            txtBoxForFirstNumber.Clear();
            txtBoxForSecondNumber.Clear();
            txtBoxResult.Clear();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxResult.Text = operation.Del(Convert.ToDouble(txtBoxForFirstNumber.Text), Convert.ToDouble(txtBoxForSecondNumber.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод!");
                CLear();
            }
        }

        private void btn_umn_Click(object sender, EventArgs e)
        {
            try
            {
                txtBoxResult.Text = operation.Umn(Convert.ToDouble(txtBoxForFirstNumber.Text), Convert.ToDouble(txtBoxForSecondNumber.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный ввод!");
                CLear();
            }
        }
    }
}
