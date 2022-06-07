
namespace test_DB
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.Visible = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Visible
            // 
            this.Visible.Location = new System.Drawing.Point(306, 149);
            this.Visible.Name = "Visible";
            this.Visible.Size = new System.Drawing.Size(25, 21);
            this.Visible.TabIndex = 1;
            this.Visible.Text = "V";
            this.Visible.UseVisualStyleBackColor = true;
           
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(306, 150);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(25, 20);
            this.Hide.TabIndex = 2;
            this.Hide.Text = "H";
            this.Hide.UseVisualStyleBackColor = true;
     
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label1.Location = new System.Drawing.Point(145, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(116, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(99, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 123);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.WordWrap = false;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(200, 149);
            this.textBox2_password.MaxLength = 20;
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(100, 20);
            this.textBox2_password.TabIndex = 7;
            this.textBox2_password.UseSystemPasswordChar = true;
            this.textBox2_password.WordWrap = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 271);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Visible);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Visible;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2_password;
    }
}