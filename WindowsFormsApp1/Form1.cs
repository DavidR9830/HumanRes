using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] usuario = new string[5];
        string[] contrasena = new string[5];
        int auxiliar =0;
        public Form1(string[] user, string[] contra, int aux) // acá quedaban guardados en usuario y contrasena, los unicos datos que se enviaron desde el formulario de registro
        {
            usuario = user;
            contrasena = contra;
            auxiliar = aux;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 registrar = new Form2(usuario, contrasena, auxiliar); // le vuelve a decir al formualario 2 que lo necesita, para registrar otro usuario (y ahí estaba el error porque como no tenía definido el constructor, no permanecían en algúna variable) y se quedaba en el constructo del formulario 1, con lo único que envío el 2
            MessageBox.Show(auxiliar.ToString());
            registrar.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)

        {
            //Saber posición en donde encontró el texto ingresado en el input, si no se encuentra es -1
            var iuser = Array.IndexOf(usuario, txtuser.Text);
            var ipass = Array.IndexOf(contrasena, txtcontra.Text);

            for (int i = 0; i < 5; i++)
            {
                if (txtuser.Text == usuario[i] && txtcontra.Text == contrasena[i])//Si el usuario y contraseña, coincide en las mismas posiciones
                {
                    MessageBox.Show("¡Credenciales correctas, bienvenido!");
                }else if (iuser ==  -1 || ipass == -1) //Si el usuario o contraseña, no se encuentran en los arrays
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                    break;
                }
                else if (iuser != ipass) //Si el usuario y contraseña están, pero en diferentes posiciones (diferentes usuarios)
                {

                    MessageBox.Show("Usuario o contraseña incorrecto");
                    break;
                }
            }

            //int j = 0;
            //do
            //{

            //    if (!usuario[j].Equals(txtuser))
            //    {
            //        MessageBox.Show("Usuario incorrecto");
            //    }
            //    else if (!contrasena[j].Equals(txtcontra))
            //    {
            //        MessageBox.Show("Contraseña incorrecta");
            //    }
            //    //if (txtuser.Text != usuario[j])
            //    //{
            //    //    MessageBox.Show("Usuario incorrecto");
            //    //}
            //    //else if (txtcontra.Text != contrasena[j])
            //    //{
            //    //    MessageBox.Show("Contraseña incorrecta");
            //    //}
            //    if (j < 5)
            //    {
            //        j++;
            //    }
            //} while (txtuser.Text == usuario[j] && txtcontra.Text == contrasena[j]);




        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
