using System;
using System.Windows.Forms;
using System.IO;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        string pass = "123456";
        string path = @"C:\Users\DELL\Desktop\test\Security Panel\Security Panel\Assets\Login_Log.txt";
        public Form1()
        {
            InitializeComponent();
            ShowLog();
        }
        private void getNumber(object o, EventArgs e)
        {
            if (Screen.TextLength < 6)
            Screen.Text += ((Button)o).Text;
        }
        private void getPressNumber(object o, KeyPressEventArgs e)
        {
            if(Screen.TextLength < 6 && e.KeyChar >= '0' && e.KeyChar <= '9')
            Screen.Text += e.KeyChar.ToString();
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) EnterPress();
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            EnterPress();
        }
        private void EnterPress()
        {
            if (Screen.Text == pass)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Login Success");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thành công", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Login Fail");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thất bại", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowLog();
            Screen.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }
        private void ShowLog()
        {
            listBox1.Items.Clear();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
