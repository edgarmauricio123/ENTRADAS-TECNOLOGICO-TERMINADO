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
    public partial class Modificar_Profesor_Existente : Form
    {
        public Modificar_Profesor_Existente()
        {
            InitializeComponent();
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

           /* private void button2_Click(object sender, EventArgs e)
        {

            cn.Open();
            string insertar = "UPDATE profesores SET id_profesor=@id_profesor,ced_profesional=@ced_profesional,nombre=@nombre,telefono=@telefono,correo=@correo,sexo=@sexo WHERE id_profesor=@id_profesor";

            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@id_profesor", idprofesor.Text);
            cmd.Parameters.AddWithValue("@ced_profesional", cedprofesional.Text);
            cmd.Parameters.AddWithValue("@nombre", nombre.Text);
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
        }*/
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


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

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

        private void button2_Click_1(object sender, EventArgs e)
        {

            cn.Open();
            string actualizar = "UPDATE profesores SET id_profesor=@id_profesor,ced_profesional=@ced_profesional,nombre=@nombre,telefono=@telefono,correo=@correo,sexo=@sexo WHERE id_profesor=@id_profesor";

            MySqlCommand cmd = new MySqlCommand( actualizar , cn);
            cmd.Parameters.AddWithValue("@id_profesor", idprofesor.Text);
            cmd.Parameters.AddWithValue("@ced_profesional", cedprofesional.Text);
            cmd.Parameters.AddWithValue("@nombre", nombre.Text);
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

        private void button6_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proyecto.Estudiantes mostrar = new proyecto.Estudiantes();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }
    }
}
