namespace Alapmuveletek
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
            this.btnOsszeadas = new System.Windows.Forms.Button();
            this.btnKivonas = new System.Windows.Forms.Button();
            this.btnSzorzas = new System.Windows.Forms.Button();
            this.btnOsztas = new System.Windows.Forms.Button();
            this.textEredmenyBeir = new System.Windows.Forms.TextBox();
            this.lblFeladatKiir = new System.Windows.Forms.Label();
            this.btnEredmenyBekuld = new System.Windows.Forms.Button();
            this.btnUjFeladat = new System.Windows.Forms.Button();
            this.btnMegoldas = new System.Windows.Forms.Button();
            this.gbStatisztika = new System.Windows.Forms.GroupBox();
            this.lblStatSzorzas = new System.Windows.Forms.Label();
            this.lblStatOsztas = new System.Windows.Forms.Label();
            this.lblStatKivonas = new System.Windows.Forms.Label();
            this.lblStatOsszeadas = new System.Windows.Forms.Label();
            this.gbFeladatmezo = new System.Windows.Forms.GroupBox();
            this.gbStatisztika.SuspendLayout();
            this.gbFeladatmezo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOsszeadas
            // 
            this.btnOsszeadas.Location = new System.Drawing.Point(25, 18);
            this.btnOsszeadas.Name = "btnOsszeadas";
            this.btnOsszeadas.Size = new System.Drawing.Size(155, 51);
            this.btnOsszeadas.TabIndex = 0;
            this.btnOsszeadas.Text = "Összeadás";
            this.btnOsszeadas.UseVisualStyleBackColor = true;
            this.btnOsszeadas.Click += new System.EventHandler(this.Osszeadas_Click);
            // 
            // btnKivonas
            // 
            this.btnKivonas.Location = new System.Drawing.Point(25, 82);
            this.btnKivonas.Name = "btnKivonas";
            this.btnKivonas.Size = new System.Drawing.Size(155, 51);
            this.btnKivonas.TabIndex = 1;
            this.btnKivonas.Text = "Kivonás";
            this.btnKivonas.UseVisualStyleBackColor = true;
            this.btnKivonas.Click += new System.EventHandler(this.Kivonas_Click);
            // 
            // btnSzorzas
            // 
            this.btnSzorzas.Location = new System.Drawing.Point(25, 146);
            this.btnSzorzas.Name = "btnSzorzas";
            this.btnSzorzas.Size = new System.Drawing.Size(155, 51);
            this.btnSzorzas.TabIndex = 2;
            this.btnSzorzas.Text = "Szorzás";
            this.btnSzorzas.UseVisualStyleBackColor = true;
            this.btnSzorzas.Click += new System.EventHandler(this.Szorzas_Click);
            // 
            // btnOsztas
            // 
            this.btnOsztas.Location = new System.Drawing.Point(25, 210);
            this.btnOsztas.Name = "btnOsztas";
            this.btnOsztas.Size = new System.Drawing.Size(155, 51);
            this.btnOsztas.TabIndex = 3;
            this.btnOsztas.Text = "Osztás";
            this.btnOsztas.UseVisualStyleBackColor = true;
            this.btnOsztas.Click += new System.EventHandler(this.Osztas_Click);
            // 
            // textEredmenyBeir
            // 
            this.textEredmenyBeir.Location = new System.Drawing.Point(180, 71);
            this.textEredmenyBeir.Name = "textEredmenyBeir";
            this.textEredmenyBeir.Size = new System.Drawing.Size(156, 26);
            this.textEredmenyBeir.TabIndex = 4;
            this.textEredmenyBeir.TextChanged += new System.EventHandler(this.BeirtEredmeny_TextChanged);
            // 
            // lblFeladatKiir
            // 
            this.lblFeladatKiir.AutoSize = true;
            this.lblFeladatKiir.Location = new System.Drawing.Point(176, 28);
            this.lblFeladatKiir.Name = "lblFeladatKiir";
            this.lblFeladatKiir.Size = new System.Drawing.Size(178, 20);
            this.lblFeladatKiir.TabIndex = 5;
            this.lblFeladatKiir.Text = "Mi az eredménye? 5+3=";
            this.lblFeladatKiir.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEredmenyBekuld
            // 
            this.btnEredmenyBekuld.Location = new System.Drawing.Point(350, 133);
            this.btnEredmenyBekuld.Name = "btnEredmenyBekuld";
            this.btnEredmenyBekuld.Size = new System.Drawing.Size(128, 64);
            this.btnEredmenyBekuld.TabIndex = 6;
            this.btnEredmenyBekuld.Text = "Eredmény beküldése";
            this.btnEredmenyBekuld.UseVisualStyleBackColor = true;
            this.btnEredmenyBekuld.Click += new System.EventHandler(this.EredmenyBekuld_Click);
            // 
            // btnUjFeladat
            // 
            this.btnUjFeladat.Location = new System.Drawing.Point(26, 133);
            this.btnUjFeladat.Name = "btnUjFeladat";
            this.btnUjFeladat.Size = new System.Drawing.Size(128, 64);
            this.btnUjFeladat.TabIndex = 7;
            this.btnUjFeladat.Text = "Új feladat";
            this.btnUjFeladat.UseVisualStyleBackColor = true;
            this.btnUjFeladat.Click += new System.EventHandler(this.UjFeladat_Click);
            // 
            // btnMegoldas
            // 
            this.btnMegoldas.Location = new System.Drawing.Point(195, 133);
            this.btnMegoldas.Name = "btnMegoldas";
            this.btnMegoldas.Size = new System.Drawing.Size(128, 64);
            this.btnMegoldas.TabIndex = 8;
            this.btnMegoldas.Text = "Megoldás";
            this.btnMegoldas.UseVisualStyleBackColor = true;
            this.btnMegoldas.Click += new System.EventHandler(this.Megoldas_Click);
            // 
            // gbStatisztika
            // 
            this.gbStatisztika.Controls.Add(this.lblStatSzorzas);
            this.gbStatisztika.Controls.Add(this.lblStatOsztas);
            this.gbStatisztika.Controls.Add(this.lblStatKivonas);
            this.gbStatisztika.Controls.Add(this.lblStatOsszeadas);
            this.gbStatisztika.Location = new System.Drawing.Point(255, 283);
            this.gbStatisztika.Name = "gbStatisztika";
            this.gbStatisztika.Size = new System.Drawing.Size(452, 155);
            this.gbStatisztika.TabIndex = 9;
            this.gbStatisztika.TabStop = false;
            this.gbStatisztika.Text = "Statisztika";
            this.gbStatisztika.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStatSzorzas
            // 
            this.lblStatSzorzas.AutoSize = true;
            this.lblStatSzorzas.Location = new System.Drawing.Point(72, 87);
            this.lblStatSzorzas.Name = "lblStatSzorzas";
            this.lblStatSzorzas.Size = new System.Drawing.Size(288, 20);
            this.lblStatSzorzas.TabIndex = 3;
            this.lblStatSzorzas.Text = "Szorzás: 10 feladatból 4 helyes --> 40%";
            this.lblStatSzorzas.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblStatOsztas
            // 
            this.lblStatOsztas.AutoSize = true;
            this.lblStatOsztas.Location = new System.Drawing.Point(72, 116);
            this.lblStatOsztas.Name = "lblStatOsztas";
            this.lblStatOsztas.Size = new System.Drawing.Size(280, 20);
            this.lblStatOsztas.TabIndex = 2;
            this.lblStatOsztas.Text = "Osztás: 10 feladatból 4 helyes --> 40%";
            this.lblStatOsztas.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStatKivonas
            // 
            this.lblStatKivonas.AutoSize = true;
            this.lblStatKivonas.Location = new System.Drawing.Point(72, 59);
            this.lblStatKivonas.Name = "lblStatKivonas";
            this.lblStatKivonas.Size = new System.Drawing.Size(285, 20);
            this.lblStatKivonas.TabIndex = 1;
            this.lblStatKivonas.Text = "Kivonás: 10 feladatból 4 helyes --> 40%";
            this.lblStatKivonas.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStatOsszeadas
            // 
            this.lblStatOsszeadas.AutoSize = true;
            this.lblStatOsszeadas.Location = new System.Drawing.Point(72, 33);
            this.lblStatOsszeadas.Name = "lblStatOsszeadas";
            this.lblStatOsszeadas.Size = new System.Drawing.Size(310, 20);
            this.lblStatOsszeadas.TabIndex = 0;
            this.lblStatOsszeadas.Text = "Összeadás: 10 feladatból 4 helyes --> 40%";
            // 
            // gbFeladatmezo
            // 
            this.gbFeladatmezo.Controls.Add(this.btnMegoldas);
            this.gbFeladatmezo.Controls.Add(this.btnUjFeladat);
            this.gbFeladatmezo.Controls.Add(this.btnEredmenyBekuld);
            this.gbFeladatmezo.Controls.Add(this.lblFeladatKiir);
            this.gbFeladatmezo.Controls.Add(this.textEredmenyBeir);
            this.gbFeladatmezo.Location = new System.Drawing.Point(224, 18);
            this.gbFeladatmezo.Name = "gbFeladatmezo";
            this.gbFeladatmezo.Size = new System.Drawing.Size(516, 238);
            this.gbFeladatmezo.TabIndex = 10;
            this.gbFeladatmezo.TabStop = false;
            this.gbFeladatmezo.Text = "Feladat";
            this.gbFeladatmezo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFeladatmezo);
            this.Controls.Add(this.gbStatisztika);
            this.Controls.Add(this.btnOsztas);
            this.Controls.Add(this.btnSzorzas);
            this.Controls.Add(this.btnKivonas);
            this.Controls.Add(this.btnOsszeadas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStatisztika.ResumeLayout(false);
            this.gbStatisztika.PerformLayout();
            this.gbFeladatmezo.ResumeLayout(false);
            this.gbFeladatmezo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOsszeadas;
        private System.Windows.Forms.Button btnKivonas;
        private System.Windows.Forms.Button btnSzorzas;
        private System.Windows.Forms.Button btnOsztas;
        private System.Windows.Forms.TextBox textEredmenyBeir;
        private System.Windows.Forms.Label lblFeladatKiir;
        private System.Windows.Forms.Button btnEredmenyBekuld;
        private System.Windows.Forms.Button btnUjFeladat;
        private System.Windows.Forms.Button btnMegoldas;
        private System.Windows.Forms.GroupBox gbStatisztika;
        private System.Windows.Forms.Label lblStatSzorzas;
        private System.Windows.Forms.Label lblStatOsztas;
        private System.Windows.Forms.Label lblStatKivonas;
        private System.Windows.Forms.Label lblStatOsszeadas;
        private System.Windows.Forms.GroupBox gbFeladatmezo;
    }
}

