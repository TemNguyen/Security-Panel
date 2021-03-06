using System;
using System.Windows.Forms;
using System.IO;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        //string pass = File.ReadAllText(@"C:\Users\DELL\Desktop\test\Security Panel\Security Panel\Assets\Pass_word.txt");
        string pass = "1234";
        string path = @"C:\Users\DELL\Desktop\test\Security Panel\Security Panel\Assets\Login_Log.txt";
        int attemps = 3;
        int clockCycle = 10;
        public Form1()
        {
            InitializeComponent();
            ShowLog();
        }
        private void getNumber(object o, EventArgs e)
        {
            if (Screen.TextLength < 4)
                Screen.Text += ((Button)o).Text;
            Ok.Focus();
        }
        private void getPressNumber(object o, KeyPressEventArgs e)
        {
            if (Screen.TextLength < 4 && e.KeyChar >= '0' && e.KeyChar <= '9' && e.KeyChar != Convert.ToChar(Keys.Enter))
                Screen.Text += e.KeyChar.ToString();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (attemps == 0) MessageBox.Show("Vui lòng đợi trong " + clockCycle + " (s)", "Waiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnterPress();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                Screen.Text = "";
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            EnterPress();
        }
        private void EnterPress()
        {
            if (Screen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Screen.TextLength == 1)
            {
                DateTime d = DateTime.Now;
                MessageBox.Show(d + " Restricted Access!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attemps--;
                MessageBox.Show("Bạn còn " + attemps + " lần thử!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            if (attemps == 0)
            {
                Ok.Enabled = false;
                MessageBox.Show("Bạn đã hết số lần thử!", "Banned Time!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Vui lòng đợi trong " + clockCycle + " (s)", "Waiting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Screen.Text = "";
                return;
            }
            if (Screen.TextLength == 1)
            {
                Screen.Text = "";
                return;
            }    
            if (Screen.Text == pass)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Access Granted!");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thành công", "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                attemps = 3;
            }
            else
            {
                attemps--;
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Access Denied!");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thất bại", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Bạn còn " + attemps + " lần thử!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }    
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        //time tick = 1s.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (attemps == 0)
                clockCycle--;
            if (clockCycle < 0)
            {
                attemps = 3;
                Ok.Enabled = true;
                clockCycle = 10;
            }
        }


        //clear log event.
        private void button10_Click(object sender, EventArgs e)
        {
            Ok.Focus();
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa file Login Log?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (d)
                {
                    case DialogResult.Yes:
                        File.Delete(path);
                        MessageBox.Show("Xóa thành công", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var myFile = File.Create(path);
                        listBox1.Items.Clear();
                        myFile.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Screen.PasswordChar = '\0';
            else Screen.PasswordChar = '*';
        }
    }
}
