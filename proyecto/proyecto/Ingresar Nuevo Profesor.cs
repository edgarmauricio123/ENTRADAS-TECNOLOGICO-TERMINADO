using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Ingresar_Nuevo_Profesor : Form
    {
        public Ingresar_Nuevo_Profesor()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proyecto.Estudiantes mostrar = new proyecto.Estudiantes();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void PROFESORES_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306; DATABASE=entradas_tecnologico; UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            String llenar = "select * from profesores";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            string insertar = "INSERT INTO profesores(id_profesor,ced_profesional,nombre,telefono,correo,sexo)values(@id_profesor,@ced_profesional,@nombre,@telefono,@correo,@sexo)";
            //tring insertar = "INSERT INTO alumnos(NUMERO CONTROL, NOMBRE,CARRERA,CORREO,SEMESTRE,GRUPO)values(@numerocontrol,@nombre,@carrera,@correo,@semestre,@grupo)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@id_profesor",idprofesor.Text);
            cmd.Parameters.AddWithValue("@ced_profesional", cedprofesional.Text);
            cmd.Parameters.AddWithValue("@nombre",nombre.Text);
            cmd.Parameters.AddWithValue("@telefono", telefono.Text);
            cmd.Parameters.AddWithValue("@correo", correo.Text);
            cmd.Parameters.AddWithValue("@sexo", sexo.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            dataGridView1.DataSource = llenar_grid();





            // Iniciar un hilo para simular el proceso de guardar
            Thread guardarThread = new Thread(Guardar);//Aca crea un nuevo hilo que lo va inicializar
                                                       //en el metdo guardar
            guardarThread.Start();//Esta linea de codigo hace referencia al inicio del hilo

        }
        private void Guardar()//Aca especifica el nombre del metodo que simulara el proceso de guardar
        {

            for (int i = 0; i <= 100; i++)// Simular un proceso de guardado
            {

                Invoke((MethodInvoker)delegate {// Actualizara la barra de progreso desde el hilo secundario
                    progressBar1.Value = i;
                });


                Thread.Sleep(10);// Simular espera es decir sera el tiempo en que estara activa la barra 
            }


            MessageBox.Show("¡Guardado completado!");// Este es un mensaje que se mostrara al finalizar el
                                                     //proceso la barra de progreso
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            idprofesor.Clear();
            cedprofesional.Clear();
            nombre.Clear();
            telefono.Clear();
            correo.Clear();
            sexo.Clear();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
