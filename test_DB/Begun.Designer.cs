
namespace test_DB
{
    partial class Begun
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Sponsor = new System.Windows.Forms.TextBox();
            this.Inventar = new System.Windows.Forms.TextBox();
            this.FSP = new System.Windows.Forms.TextBox();
            this.Prod = new System.Windows.Forms.TextBox();
            this.Blag_Org = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.D_Nach = new System.Windows.Forms.Label();
            this.Vid_Zch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(623, 41);
            this.info.TabIndex = 15;
            this.info.Text = "Введите информацию о себе";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Инвентарь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Организация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Спонсор";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(410, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 65);
            this.label9.TabIndex = 23;
            this.label9.Text = "При отстутствии напишите \"Отсутствует\"";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sponsor
            // 
            this.Sponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Sponsor.Location = new System.Drawing.Point(199, 140);
            this.Sponsor.Multiline = true;
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.Size = new System.Drawing.Size(205, 25);
            this.Sponsor.TabIndex = 24;
            this.Sponsor.WordWrap = false;
            // 
            // Inventar
            // 
            this.Inventar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Inventar.Location = new System.Drawing.Point(199, 100);
            this.Inventar.Multiline = true;
            this.Inventar.Name = "Inventar";
            this.Inventar.Size = new System.Drawing.Size(205, 25);
            this.Inventar.TabIndex = 25;
            this.Inventar.WordWrap = false;
            // 
            // FSP
            // 
            this.FSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FSP.Location = new System.Drawing.Point(199, 60);
            this.FSP.Multiline = true;
            this.FSP.Name = "FSP";
            this.FSP.Size = new System.Drawing.Size(205, 25);
            this.FSP.TabIndex = 26;
            this.FSP.WordWrap = false;
            // 
            // Prod
            // 
            this.Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Prod.Location = new System.Drawing.Point(199, 260);
            this.Prod.Multiline = true;
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(205, 25);
            this.Prod.TabIndex = 1;
            this.Prod.WordWrap = false;
            // 
            // Blag_Org
            // 
            this.Blag_Org.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Blag_Org.Location = new System.Drawing.Point(199, 180);
            this.Blag_Org.Multiline = true;
            this.Blag_Org.Name = "Blag_Org";
            this.Blag_Org.Size = new System.Drawing.Size(205, 25);
            this.Blag_Org.TabIndex = 27;
            this.Blag_Org.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата начала";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Продолжительность";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Вид зачета";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // D_Nach
            // 
            this.D_Nach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.D_Nach.Location = new System.Drawing.Point(199, 300);
            this.D_Nach.Name = "D_Nach";
            this.D_Nach.Size = new System.Drawing.Size(205, 25);
            this.D_Nach.TabIndex = 30;
            this.D_Nach.Text = "12-05-2022";
            this.D_Nach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vid_Zch
            // 
            this.Vid_Zch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Vid_Zch.FormattingEnabled = true;
            this.Vid_Zch.Location = new System.Drawing.Point(199, 220);
            this.Vid_Zch.Name = "Vid_Zch";
            this.Vid_Zch.Size = new System.Drawing.Size(205, 25);
            this.Vid_Zch.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTime.Location = new System.Drawing.Point(489, 9);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(60, 24);
            this.LTime.TabIndex = 32;
            this.LTime.Text = "label4";
            // 
            // Begun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 341);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.D_Nach);
            this.Controls.Add(this.Vid_Zch);
            this.Controls.Add(this.Blag_Org);
            this.Controls.Add(this.FSP);
            this.Controls.Add(this.Inventar);
            this.Controls.Add(this.Sponsor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Prod);
            this.Controls.Add(this.label1);
            this.Name = "Begun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Begun_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sponsor;
        private System.Windows.Forms.TextBox Inventar;
        private System.Windows.Forms.TextBox FSP;
        private System.Windows.Forms.TextBox Prod;
        private System.Windows.Forms.TextBox Blag_Org;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label D_Nach;
        private System.Windows.Forms.ComboBox Vid_Zch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LTime;
    }
}

