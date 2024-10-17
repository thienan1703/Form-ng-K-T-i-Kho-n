using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdangky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text; 
            string email = textBox2.Text; 
            string password = textBox3.Text; 
            
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và bao gồm ít nhất 1 ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool IsValidEmail(string email)
        {
            
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        
        private bool IsValidPassword(string password)
        {
            
            if (password.Length < 8) return false;


            string specialCharPattern = @"[!@#$%^&*(),.?\:{ }|<>]";
            return Regex.IsMatch(password, specialCharPattern);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
