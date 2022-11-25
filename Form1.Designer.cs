
namespace Rezervacija_stola_u_restoranu
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
            this.tbimeprezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnodjavi = new System.Windows.Forms.Button();
            this.btnpogledajrez = new System.Windows.Forms.Button();
            this.btnrezervisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnponisti = new System.Windows.Forms.Button();
            this.tbvreme = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbimeprezime
            // 
            this.tbimeprezime.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbimeprezime.Location = new System.Drawing.Point(16, 48);
            this.tbimeprezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbimeprezime.Name = "tbimeprezime";
            this.tbimeprezime.Size = new System.Drawing.Size(339, 32);
            this.tbimeprezime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezervacija na ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj osoba";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 178);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.Value = new System.DateTime(2022, 9, 19, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rezerviši za:";
            // 
            // btnodjavi
            // 
            this.btnodjavi.BackColor = System.Drawing.Color.LightBlue;
            this.btnodjavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnodjavi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnodjavi.Location = new System.Drawing.Point(16, 450);
            this.btnodjavi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnodjavi.Name = "btnodjavi";
            this.btnodjavi.Size = new System.Drawing.Size(231, 46);
            this.btnodjavi.TabIndex = 17;
            this.btnodjavi.Text = "Odjavi registraciju";
            this.btnodjavi.UseVisualStyleBackColor = false;
            this.btnodjavi.Click += new System.EventHandler(this.btnodjavi_Click);
            // 
            // btnpogledajrez
            // 
            this.btnpogledajrez.BackColor = System.Drawing.Color.LightBlue;
            this.btnpogledajrez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpogledajrez.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpogledajrez.Location = new System.Drawing.Point(725, 450);
            this.btnpogledajrez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpogledajrez.Name = "btnpogledajrez";
            this.btnpogledajrez.Size = new System.Drawing.Size(244, 46);
            this.btnpogledajrez.TabIndex = 18;
            this.btnpogledajrez.Text = "Pogledaj rezervacije";
            this.btnpogledajrez.UseVisualStyleBackColor = false;
            this.btnpogledajrez.Click += new System.EventHandler(this.btnpogledajrez_Click);
            // 
            // btnrezervisi
            // 
            this.btnrezervisi.BackColor = System.Drawing.Color.LightBlue;
            this.btnrezervisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrezervisi.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrezervisi.Location = new System.Drawing.Point(579, 233);
            this.btnrezervisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrezervisi.Name = "btnrezervisi";
            this.btnrezervisi.Size = new System.Drawing.Size(171, 44);
            this.btnrezervisi.TabIndex = 19;
            this.btnrezervisi.Text = "Rezerviši";
            this.btnrezervisi.UseVisualStyleBackColor = false;
            this.btnrezervisi.Click += new System.EventHandler(this.btnrezervisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Unesite vreme";
            // 
            // btnponisti
            // 
            this.btnponisti.BackColor = System.Drawing.Color.LightBlue;
            this.btnponisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnponisti.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnponisti.Location = new System.Drawing.Point(579, 316);
            this.btnponisti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnponisti.Name = "btnponisti";
            this.btnponisti.Size = new System.Drawing.Size(171, 36);
            this.btnponisti.TabIndex = 21;
            this.btnponisti.Text = "Poništi";
            this.btnponisti.UseVisualStyleBackColor = false;
            this.btnponisti.Click += new System.EventHandler(this.btnponisti_Click);
            // 
            // tbvreme
            // 
            this.tbvreme.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvreme.Location = new System.Drawing.Point(16, 273);
            this.tbvreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbvreme.Name = "tbvreme";
            this.tbvreme.Size = new System.Drawing.Size(197, 29);
            this.tbvreme.TabIndex = 31;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.PowderBlue;
            this.rb1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(432, 48);
            this.rb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(108, 24);
            this.rb1.TabIndex = 32;
            this.rb1.TabStop = true;
            this.rb1.Text = "za 1 osobu";
            this.rb1.UseVisualStyleBackColor = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.BackColor = System.Drawing.Color.PowderBlue;
            this.rb2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(601, 48);
            this.rb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(108, 24);
            this.rb2.TabIndex = 33;
            this.rb2.TabStop = true;
            this.rb2.Text = "za 2 osobe";
            this.rb2.UseVisualStyleBackColor = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.PowderBlue;
            this.rb3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(768, 48);
            this.rb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(108, 24);
            this.rb3.TabIndex = 34;
            this.rb3.TabStop = true;
            this.rb3.Text = "za 3 osobe";
            this.rb3.UseVisualStyleBackColor = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.BackColor = System.Drawing.Color.PowderBlue;
            this.rb4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(432, 94);
            this.rb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(108, 24);
            this.rb4.TabIndex = 35;
            this.rb4.TabStop = true;
            this.rb4.Text = "za 4 osobe";
            this.rb4.UseVisualStyleBackColor = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.BackColor = System.Drawing.Color.PowderBlue;
            this.rb5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(601, 94);
            this.rb5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(107, 24);
            this.rb5.TabIndex = 36;
            this.rb5.TabStop = true;
            this.rb5.Text = "za 5 osoba";
            this.rb5.UseVisualStyleBackColor = false;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.BackColor = System.Drawing.Color.PowderBlue;
            this.rb6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb6.Location = new System.Drawing.Point(768, 94);
            this.rb6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(107, 24);
            this.rb6.TabIndex = 37;
            this.rb6.TabStop = true;
            this.rb6.Text = "za 6 osoba";
            this.rb6.UseVisualStyleBackColor = false;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.BackColor = System.Drawing.Color.PowderBlue;
            this.rb7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7.Location = new System.Drawing.Point(432, 137);
            this.rb7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(107, 24);
            this.rb7.TabIndex = 38;
            this.rb7.TabStop = true;
            this.rb7.Text = "za 7 osoba";
            this.rb7.UseVisualStyleBackColor = false;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.BackColor = System.Drawing.Color.PowderBlue;
            this.rb8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb8.Location = new System.Drawing.Point(601, 137);
            this.rb8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(107, 24);
            this.rb8.TabIndex = 39;
            this.rb8.TabStop = true;
            this.rb8.Text = "za 8 osoba";
            this.rb8.UseVisualStyleBackColor = false;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.BackColor = System.Drawing.Color.PowderBlue;
            this.rb9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb9.Location = new System.Drawing.Point(768, 137);
            this.rb9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(147, 24);
            this.rb9.TabIndex = 40;
            this.rb9.TabStop = true;
            this.rb9.Text = "za 9 i više osoba";
            this.rb9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rezervacija_stola_u_restoranu.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 511);
            this.Controls.Add(this.rb9);
            this.Controls.Add(this.rb8);
            this.Controls.Add(this.rb7);
            this.Controls.Add(this.rb6);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb4);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.tbvreme);
            this.Controls.Add(this.btnponisti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnrezervisi);
            this.Controls.Add(this.btnpogledajrez);
            this.Controls.Add(this.btnodjavi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbimeprezime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbimeprezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnodjavi;
        private System.Windows.Forms.Button btnpogledajrez;
        private System.Windows.Forms.Button btnrezervisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnponisti;
        private System.Windows.Forms.TextBox tbvreme;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb9;
    }
}

