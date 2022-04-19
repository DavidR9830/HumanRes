using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string[] usuario = new string[5];
        string[] contrasena = new string[5];
        int auxiliar = 0 ; 
        public Form2(string[] user, string[] contra, int aux) // esto se pone para poder que guarde los datos del vector y los vuelva a llamar, y no cree unos arrays desde 0 vacíos, eso genraba que a la primer ventana solo llegaran datos una vez.
        {

            usuario = user;
            contrasena = contra;
            auxiliar = aux;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show (auxiliar.ToString()); 
            if (auxiliar <5) 
            {
                
                
                    //if (usuario[i]  && contrasena[i] == null)//Si en la posición no hay nada, lo inserta, 
                                                                    // sin esto cada que se inserta un usuario lo pie
                   // {
                        usuario[auxiliar] = txtuser.Text;
                        contrasena[auxiliar] = txtcontra.Text;
                        auxiliar++;
                        MessageBox.Show(auxiliar.ToString());
                         // para que una vez inserte uno se detenga, porque sino lo inserta repetidas veces
                   // }
                    
                
            }
            else
            {
                MessageBox.Show("el sistema alcanzó la capaciad máxima");
            }

            Form1 login = new Form1(usuario,contrasena,auxiliar); // para que envíe a la ventana 1 lo que esta guardado en los arrays, como antes no estaba definidod el constructo como esta arriba,en esta ventana no se guardaban los datos que habían en los arrays y los volvía a iniciar vacíos
            login.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
