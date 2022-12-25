namespace Hesap_Makinesi_Basit
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCE = new System.Windows.Forms.Button();
            this.EkranLabel = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnArtı = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAltaAlma = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.buttonEsittir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.ForeColor = System.Drawing.Color.Black;
            this.btnCE.Location = new System.Drawing.Point(0, 410);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(90, 100);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // EkranLabel
            // 
            this.EkranLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.EkranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EkranLabel.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkranLabel.Location = new System.Drawing.Point(0, 50);
            this.EkranLabel.Name = "EkranLabel";
            this.EkranLabel.Size = new System.Drawing.Size(360, 49);
            this.EkranLabel.TabIndex = 1;
            this.EkranLabel.Text = "0";
            this.EkranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EkranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Location = new System.Drawing.Point(90, 410);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 100);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnArtı
            // 
            this.btnArtı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnArtı.FlatAppearance.BorderSize = 0;
            this.btnArtı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtı.ForeColor = System.Drawing.Color.Silver;
            this.btnArtı.Location = new System.Drawing.Point(270, 410);
            this.btnArtı.Margin = new System.Windows.Forms.Padding(0);
            this.btnArtı.Name = "btnArtı";
            this.btnArtı.Size = new System.Drawing.Size(90, 100);
            this.btnArtı.TabIndex = 4;
            this.btnArtı.Text = "+";
            this.btnArtı.UseVisualStyleBackColor = false;
            this.btnArtı.Click += new System.EventHandler(this.btnArtı_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEksi.FlatAppearance.BorderSize = 0;
            this.btnEksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksi.ForeColor = System.Drawing.Color.Silver;
            this.btnEksi.Location = new System.Drawing.Point(270, 310);
            this.btnEksi.Margin = new System.Windows.Forms.Padding(0);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(90, 100);
            this.btnEksi.TabIndex = 8;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = false;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(180, 310);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 100);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(90, 310);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 100);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(0, 310);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 100);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCarpma.FlatAppearance.BorderSize = 0;
            this.btnCarpma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarpma.ForeColor = System.Drawing.Color.Silver;
            this.btnCarpma.Location = new System.Drawing.Point(270, 210);
            this.btnCarpma.Margin = new System.Windows.Forms.Padding(0);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(90, 100);
            this.btnCarpma.TabIndex = 12;
            this.btnCarpma.Text = "x";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(180, 210);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 100);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(90, 210);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 100);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(0, 210);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 100);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBolme.FlatAppearance.BorderSize = 0;
            this.btnBolme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBolme.ForeColor = System.Drawing.Color.Silver;
            this.btnBolme.Location = new System.Drawing.Point(270, 110);
            this.btnBolme.Margin = new System.Windows.Forms.Padding(0);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(90, 100);
            this.btnBolme.TabIndex = 16;
            this.btnBolme.Text = "÷";
            this.btnBolme.UseVisualStyleBackColor = false;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(180, 110);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 100);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(90, 110);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 100);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(0, 110);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 100);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAltaAlma);
            this.panel1.Controls.Add(this.btnCıkıs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 50);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "made by Fikoo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAltaAlma
            // 
            this.btnAltaAlma.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAltaAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAlma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAltaAlma.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaAlma.Image")));
            this.btnAltaAlma.Location = new System.Drawing.Point(260, 0);
            this.btnAltaAlma.Margin = new System.Windows.Forms.Padding(0);
            this.btnAltaAlma.Name = "btnAltaAlma";
            this.btnAltaAlma.Size = new System.Drawing.Size(50, 50);
            this.btnAltaAlma.TabIndex = 1;
            this.btnAltaAlma.UseVisualStyleBackColor = true;
            this.btnAltaAlma.Click += new System.EventHandler(this.btnAltaAlma_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCıkıs.Image = ((System.Drawing.Image)(resources.GetObject("btnCıkıs.Image")));
            this.btnCıkıs.Location = new System.Drawing.Point(310, 0);
            this.btnCıkıs.Margin = new System.Windows.Forms.Padding(0);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(50, 50);
            this.btnCıkıs.TabIndex = 0;
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // buttonEsittir
            // 
            this.buttonEsittir.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonEsittir.FlatAppearance.BorderSize = 0;
            this.buttonEsittir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEsittir.ForeColor = System.Drawing.Color.Black;
            this.buttonEsittir.Location = new System.Drawing.Point(180, 410);
            this.buttonEsittir.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEsittir.Name = "buttonEsittir";
            this.buttonEsittir.Size = new System.Drawing.Size(90, 100);
            this.buttonEsittir.TabIndex = 18;
            this.buttonEsittir.Text = "=";
            this.buttonEsittir.UseVisualStyleBackColor = false;
            this.buttonEsittir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(360, 511);
            this.Controls.Add(this.buttonEsittir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnArtı);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.EkranLabel);
            this.Controls.Add(this.btnCE);
            this.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label EkranLabel;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnArtı;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAltaAlma;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button buttonEsittir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

