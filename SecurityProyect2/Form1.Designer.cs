namespace SecurityProyect2
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_valida_tarjeta = new System.Windows.Forms.Button();
            this.tb_enmascarada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sha256 = new System.Windows.Forms.TextBox();
            this.tb_sha256_des = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SHA256 = new System.Windows.Forms.Label();
            this.tbo_sha256 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de tarjeta";
            // 
            // bt_valida_tarjeta
            // 
            this.bt_valida_tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_valida_tarjeta.Location = new System.Drawing.Point(126, 64);
            this.bt_valida_tarjeta.Name = "bt_valida_tarjeta";
            this.bt_valida_tarjeta.Size = new System.Drawing.Size(215, 60);
            this.bt_valida_tarjeta.TabIndex = 2;
            this.bt_valida_tarjeta.Text = "Validar número de tarjeta";
            this.bt_valida_tarjeta.UseVisualStyleBackColor = true;
            this.bt_valida_tarjeta.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_enmascarada
            // 
            this.tb_enmascarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_enmascarada.Location = new System.Drawing.Point(126, 154);
            this.tb_enmascarada.Name = "tb_enmascarada";
            this.tb_enmascarada.ReadOnly = true;
            this.tb_enmascarada.Size = new System.Drawing.Size(215, 26);
            this.tb_enmascarada.TabIndex = 3;
            this.tb_enmascarada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enmascarada";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tb_sha256
            // 
            this.tb_sha256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sha256.Location = new System.Drawing.Point(12, 342);
            this.tb_sha256.Multiline = true;
            this.tb_sha256.Name = "tb_sha256";
            this.tb_sha256.ReadOnly = true;
            this.tb_sha256.Size = new System.Drawing.Size(215, 89);
            this.tb_sha256.TabIndex = 6;
            this.tb_sha256.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sha256_des
            // 
            this.tb_sha256_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sha256_des.Location = new System.Drawing.Point(256, 342);
            this.tb_sha256_des.Multiline = true;
            this.tb_sha256_des.Name = "tb_sha256_des";
            this.tb_sha256_des.ReadOnly = true;
            this.tb_sha256_des.Size = new System.Drawing.Size(215, 89);
            this.tb_sha256_des.TabIndex = 7;
            this.tb_sha256_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "AES256";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "AES256 - Desencriptado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SHA256
            // 
            this.SHA256.AutoSize = true;
            this.SHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256.Location = new System.Drawing.Point(198, 189);
            this.SHA256.Name = "SHA256";
            this.SHA256.Size = new System.Drawing.Size(76, 20);
            this.SHA256.TabIndex = 9;
            this.SHA256.Text = "SHA256";
            // 
            // tbo_sha256
            // 
            this.tbo_sha256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbo_sha256.Location = new System.Drawing.Point(126, 217);
            this.tbo_sha256.Multiline = true;
            this.tbo_sha256.Name = "tbo_sha256";
            this.tbo_sha256.ReadOnly = true;
            this.tbo_sha256.Size = new System.Drawing.Size(215, 89);
            this.tbo_sha256.TabIndex = 10;
            this.tbo_sha256.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 440);
            this.Controls.Add(this.tbo_sha256);
            this.Controls.Add(this.SHA256);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_sha256_des);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_sha256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_enmascarada);
            this.Controls.Add(this.bt_valida_tarjeta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security proyect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_valida_tarjeta;
        private System.Windows.Forms.TextBox tb_enmascarada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sha256;
        private System.Windows.Forms.TextBox tb_sha256_des;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SHA256;
        private System.Windows.Forms.TextBox tbo_sha256;
    }
}

