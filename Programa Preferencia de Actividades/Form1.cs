namespace Programa_Preferencia_de_Actividades
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radHibrida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ========================
            // 1.- VALIDAR EL NOMBRE
            // ========================
            if (string.IsNullOrWhiteSpace(boxNombre.Text))
            {
                MessageBox.Show
                    (
                    "Por favor, escribe tu nombre.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                boxNombre.Focus();
            }
            // ===========================================
            // 2.- OBTENER LAS ACTIVIDADES SELECCIONADAS
            // ===========================================

            List<string> actividades = new List<string>();

            if (chkDeportes.Checked)
            {
                actividades.Add("Deportes");
            }
            if (chkMusica.Checked)
            {
                actividades.Add("Música");
            }
            if (chkArte.Checked)
            {
                actividades.Add("Arte");
            }
            if (chkProgra.Checked)
            {
                actividades.Add("Programación");
            }
            if (chkLectura.Checked)
            {
                actividades.Add("Lectura");
            }

            // ===========================================
            // 3.- COMPROBAR QUE SE SELECCIONO
            // AL MENOS UNA ACTIVIDAD
            // ===========================================

            if (actividades.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, selecciona al menos una actividad.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            // ===========================================
            // 4.- OBTENER LA MODALIDAD SELECCIONADA
            // ===========================================
            string modalidad = "";
            if (radPresencial.Checked)
            {
                modalidad = "Presencial";
            }
            else if (radHibrida.Checked)
            {
                modalidad = "Híbrida";
            }
            else if (radLinea.Checked)
            {
                modalidad = "En Línea";
            }

            else if (string.IsNullOrWhiteSpace(modalidad))
            {
                MessageBox.Show(
                    "Selecciona una modalidad",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            // =============================================
            // 5.- MOSTRAR LOS DATOS EN EL TEXTBOX
            // =============================================
            string resumen =
                "Resumen de Prefeencias\r\n" +
                "--------------------------------\r\n" +
                "Nombre:" + txtNombre.Text + "\r\n" +
                "Actividades: " + string.Join(", ", actividades) + "\r\n" +
                "Modalidad: " + modalidad;
            txtResu.Text = resumen;
        }

        private void Programa_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar el nombre
            boxNombre.Clear(); //txtNombre="";
            //Desmarcamos el CheckBox
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkProgra.Checked = false;
            chkLectura.Checked = false;
            //Desmarcar Radiobutton
            radLinea.Checked = false;
            radHibrida.Checked = false;
            radPresencial.Checked = false;
            //Limpiar Resumen
            txtResu.Clear();
            //Refresamos el cursor al nombre
            boxNombre.Focus();
        }
    }
}
