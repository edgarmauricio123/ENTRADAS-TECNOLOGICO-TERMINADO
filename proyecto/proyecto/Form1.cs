using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int hparam);
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.Show(this);
            //mostrar.BringToFront(); // Asegurar que la ventana de Profesores esté en primer plano
        }

    

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // centrar el frma en medio de la pantalla al moemento de abrirla
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height-this.Height)/2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width)/2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ESTUDIANTES_Click(object sender, EventArgs e)
        {

            proyecto.Estudiantes mostrar = new proyecto.Estudiantes();
            mostrar.ShowDialog(this); // Pasar la ventana actual como propietario

        }
        private void AbrirformInPanel(object Formhijo)
        {
          /*  if (this.panelcontenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();*/
        }
       
        private void INICIO_Click(object sender, EventArgs e)
        {
            AbrirformInPanel(new Estudiantes());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
