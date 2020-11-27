namespace EntityProje
{
    partial class frmAnaForm
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
            this.btnKategoriIslemleri = new System.Windows.Forms.Button();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategoriIslemleri
            // 
            this.btnKategoriIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriIslemleri.Location = new System.Drawing.Point(12, 12);
            this.btnKategoriIslemleri.Name = "btnKategoriIslemleri";
            this.btnKategoriIslemleri.Size = new System.Drawing.Size(213, 172);
            this.btnKategoriIslemleri.TabIndex = 0;
            this.btnKategoriIslemleri.Text = "Kategori İşlemleri";
            this.btnKategoriIslemleri.UseVisualStyleBackColor = true;
            this.btnKategoriIslemleri.Click += new System.EventHandler(this.btnKategoriIslemleri_Click);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunIslemleri.Location = new System.Drawing.Point(231, 13);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(213, 172);
            this.btnUrunIslemleri.TabIndex = 1;
            this.btnUrunIslemleri.Text = "Ürün İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = true;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatistikler.Location = new System.Drawing.Point(450, 12);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(213, 172);
            this.btnIstatistikler.TabIndex = 2;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = true;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 197);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.btnUrunIslemleri);
            this.Controls.Add(this.btnKategoriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
        private System.Windows.Forms.Button btnIstatistikler;
    }
}