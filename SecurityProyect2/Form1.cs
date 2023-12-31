﻿using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecurityProyect2
{
    public partial class Form1 : Form
    {
        private MaskedTextBox tb_num_tarjeta = new MaskedTextBox();
        private String tarjeta_numnero;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();


        }

        //Metodo para validar número de tarjeta por medio de una regExp
        private Boolean valida_tarjeta(String numTarjeta) {
            String regex = @"^(\d\s?){15,16}$";
            return Regex.IsMatch(numTarjeta, regex, RegexOptions.None, TimeSpan.FromMilliseconds(100));
        }

        // Método para enmascarar numero de tarjeta, visible solo los ultimos 4 digitos
        private String mask_tarjeta(String numTarjeta) {
            StringBuilder bld = new StringBuilder();

            for (int i = 0; i < numTarjeta.Length -4;i++) {
                bld.Append("*");
            }

            bld.Append(numTarjeta.Substring(numTarjeta.Length - 4).ToString());

            return bld.ToString();
        }
       
        //Metodo para comparar cadenas 
        private Boolean comprarSHA256(String p_cadena1, String p_cadena2)
        {
            Boolean comparacion = false;

            if (p_cadena1.Equals(p_cadena2))
            {
                comparacion = true;
            }

            return comparacion;
        }

        //Metodo para procesar información
        private void button1_Click(object sender, EventArgs e)
        {   
            //Declaramos clase de enpriptación
            Encriptacion encriptacion = new Encriptacion();
            
            //Verificamos si es un numero de tarjeta valido entre 15 y 16 digitos.
            if (valida_tarjeta(this.tb_num_tarjeta.Text.ToString()))
            {   
                //Guardamos numero de tarjeta
                this.tarjeta_numnero = this.tb_num_tarjeta.Text;   
                
                //Enmascaramos número de tarjeta, visible solo los ultimos 4 digitos
                this.tb_enmascarada.Text = this.mask_tarjeta(this.tb_num_tarjeta.Text.ToString());

                //Hash numero de la tarjeta
                var hashingHASH256 = encriptacion.getSHA256(tarjeta_numnero);
                this.tbo_sha256.Text = hashingHASH256.ToString();   

                //Encriptamos AES256
                var encryptedString = encriptacion.getAES256Encript(hashingHASH256);
                this.tb_sha256.Text = encryptedString;
                
                //Desencriptamos AES256
                var decryptedString = encriptacion.getAES256desEncript(encryptedString);
                this.tb_sha256_des.Text = decryptedString.ToString();

                //Comparamos cadenas
                if (comprarSHA256(this.tbo_sha256.Text, this.tb_sha256_des.Text))
                {
                    MessageBox.Show("Las cadenas coinciden\nOrigina : \n" + this.tbo_sha256.Text + "\n\nDesencriptado:\n" + this.tb_sha256_des.Text, "Comparación de cadenas SHA256", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema en la desencriptación las cadenas no coinciden", "Comparación de cadenas SHA256", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Número de tarjeta no valido", "Cerrar ventana",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            throw new NotSupportedException();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotSupportedException();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_num_tarjeta.ForeColor = Color.Black;
            tb_num_tarjeta.Name = "tb_num_tarjeta";
            tb_num_tarjeta.Font = new Font("Microsoft Sans Serif", 12);
            Controls.Add(tb_num_tarjeta);
            tb_num_tarjeta.Location = new Point(126, 32);
            tb_num_tarjeta.Height = 26;
            tb_num_tarjeta.Width = 215;
            tb_num_tarjeta.MaxLength = 16;
            tb_num_tarjeta.Mask = "0000 0000 0000 0000";
            tb_num_tarjeta.TextAlign = HorizontalAlignment.Center;
            tb_num_tarjeta.Text = "4856 3178 4159 0258";
        }
    }
}
