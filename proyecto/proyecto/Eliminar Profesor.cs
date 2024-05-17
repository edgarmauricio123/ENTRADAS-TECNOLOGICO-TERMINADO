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
    public partial class Eliminar_Profesor : Form
    {
        public Eliminar_Profesor()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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


                Thread.Sleep(50);// Simular espera es decir sera el tiempo en que estara activa la barra 
            }


            MessageBox.Show("¡Guardado completado!");// Este es un mensaje que se mostrara al finalizar el
                                                     //proceso la barra de progreso
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void button2_Click_1(object sender, EventArgs e)
        {


            cn.Open();


            string eliminar = "DELETE FROM profesores WHERE id_profesor=@id_profesor";
            MySqlCommand cmd = new MySqlCommand(eliminar, cn);
            cmd.Parameters.AddWithValue("@id_profesor", idprofesor.Text );
            cmd.ExecuteNonQuery();
            cn.Close();
            dataGridView1.DataSource = llenar_grid();


            // Iniciar un hilo para simular el proceso de guardar
            Thread guardarThread = new Thread(Guardar);//Aca crea un nuevo hilo que lo va inicializar
                                                       //en el metdo guardar
            guardarThread.Start();//Esta linea de codigo hace referencia al inicio del hilo
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idprofesor.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cedprofesional.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                nombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                telefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                correo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                sexo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
