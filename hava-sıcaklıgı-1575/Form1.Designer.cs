namespace hava_sıcaklıgı_1575
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDeger = new Label();
            txtSıcaklık = new TextBox();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // lblDeger
            // 
            lblDeger.AutoSize = true;
            lblDeger.BackColor = Color.DarkCyan;
            lblDeger.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeger.Location = new Point(-1, 53);
            lblDeger.Name = "lblDeger";
            lblDeger.Size = new Size(215, 20);
            lblDeger.TabIndex = 0;
            lblDeger.Text = "Sıcaklık Değerini Giriniz :";
            // 
            // txtSıcaklık
            // 
            txtSıcaklık.Location = new Point(220, 50);
            txtSıcaklık.Name = "txtSıcaklık";
            txtSıcaklık.Size = new Size(125, 27);
            txtSıcaklık.TabIndex = 1;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.DarkGray;
            btnHesapla.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.Location = new Point(370, 48);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(110, 29);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(524, 136);
            Controls.Add(btnHesapla);
            Controls.Add(txtSıcaklık);
            Controls.Add(lblDeger);
            Name = "Form1";
            Text = "HAVA DURUMU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeger;
        private TextBox txtSıcaklık;
        private Button btnHesapla;
    }
}