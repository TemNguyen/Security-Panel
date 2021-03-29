namespace Security_Panel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Screen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Cursor = System.Windows.Forms.Cursors.No;
            this.Screen.Enabled = false;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(23, 27);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.PasswordChar = '*';
            this.Screen.Size = new System.Drawing.Size(329, 58);
            this.Screen.TabIndex = 0;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(45, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.getNumber);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(146, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.getNumber);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(252, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 69);
            this.button3.TabIndex = 1;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.getNumber);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(45, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 69);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.getNumber);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(146, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 69);
            this.button5.TabIndex = 1;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.getNumber);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(252, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 69);
            this.button6.TabIndex = 1;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.getNumber);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(45, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 69);
            this.button7.TabIndex = 1;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.getNumber);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(146, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 69);
            this.button8.TabIndex = 1;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.getNumber);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(252, 303);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 69);
            this.button9.TabIndex = 1;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.getNumber);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.Red;
            this.Cancel.Location = new System.Drawing.Point(45, 388);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(79, 69);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "C";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Cancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(146, 388);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(79, 69);
            this.button11.TabIndex = 1;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.getNumber);
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.White;
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok.ForeColor = System.Drawing.Color.Red;
            this.Ok.Location = new System.Drawing.Point(252, 388);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(79, 69);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            this.Ok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(45, 503);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 132);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(230, 470);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 30);
            this.button10.TabIndex = 4;
            this.button10.Text = "Clear Log";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getPressNumber);
            // 
            // Form1
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(394, 640);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Screen);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button10;
    }
}

