using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
  
namespace prjLeerEscribirArchivo
{
    public partial class Form1 : Form
    {
        string fileName = @"c:\files\Estudiantes2.txt";
           
        public Form1()
        {
            InitializeComponent();
        }



        private void cmdLeerArchivoRutaFija_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    String line = sr.ReadToEnd();
                    txtContenidoArchivo.Text = line;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void cmdLeerArchivoConDialogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            //openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            openFileDialog1.ShowDialog();

            string archivo = openFileDialog1.FileName;

            if (archivo.Trim().Length > 0)
                // Open the selected file to read.

                using (StreamReader sr = new StreamReader(archivo))
                {
                    String line = sr.ReadToEnd();
                    txtContenidoArchivo.Text = line;
                }
        }

        private void cmdLlenarGrid_Click(object sender, EventArgs e)
        {
            string line;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Matricula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Carrera");
                       
            // lee linea a linea 
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\files\Estudiantes2.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] registro = line.Split(',');
                DataRow fila = dt.NewRow();
                fila["Matricula"] = registro[0];
                fila["Nombre"] = registro[1];
                fila["Carrera"] = registro[2];
                dt.Rows.Add(fila);
            }

            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(fileName))
            {
                w.WriteLine(pLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeFileLine("2001-0514,Hector Perez,ISO");
            writeFileLine("2001-0517,Ana Mendez,ISC");
            MessageBox.Show("Archivo generado con exito");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
