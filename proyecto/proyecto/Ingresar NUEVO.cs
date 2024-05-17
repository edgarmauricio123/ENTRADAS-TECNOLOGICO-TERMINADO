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
    public partial class Ingresar_NUEVO : Form
    {
        public Ingresar_NUEVO()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306; DATABASE=entradas_tecnologico; UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public DataTable llenar_grid()
        {
            cn.Open();
            DataTable dt = new DataTable();
            String llenar = "select * from alumnos";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            string insertar = "INSERT INTO alumnos(Numero_control_alumno,Nombre,carrera,correo,semestre,grupo)values(@numero_control_alumno,@nombre,@carrera,@correo,@semestre,@grupo)";
            //tring insertar = "INSERT INTO alumnos(NUMERO CONTROL, NOMBRE,CARRERA,CORREO,SEMESTRE,GRUPO)values(@numerocontrol,@nombre,@carrera,@correo,@semestre,@grupo)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@numero_control_alumno", NumeroControl.Text);
            cmd.Parameters.AddWithValue("@nombre", Nombre.Text);
            cmd.Parameters.AddWithValue("@carrera", Carrera.Text);
            cmd.Parameters.AddWithValue("@correo", correo.Text);
            cmd.Parameters.AddWithValue("@semestre", Semestre.Text);
            cmd.Parameters.AddWithValue("@grupo", Grupo.Text);
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


                Thread.Sleep(5);// Simular espera es decir sera el tiempo en que estara activa la barra 
            }


            MessageBox.Show("¡Guardado completado!");// Este es un mensaje que se mostrara al finalizar el
                                                     //proceso la barra de progreso
        }


        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proyecto.Estudiantes mostrar = new proyecto.Estudiantes();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        /*  cn.Open();
            string insertar = "INSERT INTO alumnos(Numero_control_alumno,Nombre,carrera,correo,semestre,grupo)values(@numero_control_alumno,@nombre,@carrera,@correo,@semestre,@grupo)";
            //tring insertar = "INSERT INTO alumnos(NUMERO CONTROL, NOMBRE,CARRERA,CORREO,SEMESTRE,GRUPO)values(@numerocontrol,@nombre,@carrera,@correo,@semestre,@grupo)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@numero_control_alumno", NumeroControl.Text);
            cmd.Parameters.AddWithValue("@nombre", Nombre.Text);
            cmd.Parameters.AddWithValue("@carrera", Carrera.Text);
            cmd.Parameters.AddWithValue("@correo", correo.Text);
            cmd.Parameters.AddWithValue("@semestre", Semestre.Text);
            cmd.Parameters.AddWithValue("@grupo", Grupo.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            dataGridView1.DataSource = llenar_grid();*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NumeroControl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Carrera.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                correo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Semestre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Grupo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumeroControl.Clear();
            Nombre.Clear();
            Carrera.Clear();
            correo.Clear();
            Semestre.Clear();
            Grupo.Clear();
        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padres
        }

        private void PROFESORES_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.StartPosition = FormStartPosition.CenterParent; // Establece la posición del formulario hijo
            mostrar.Show(this); // Abre el formulario sin bloquear el formulario padre
        }
    }
    }

