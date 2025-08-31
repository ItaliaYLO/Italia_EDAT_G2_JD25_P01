using static System.Runtime.InteropServices.JavaScript.JSType;

namespace frmDatosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] nombres = { "Deigo", "Laura", "Angel", "Lucia", "Pablo", "Leticia", "Emiliano", "Estefania", "Antonio", "Italia" };
            string[] grupos = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };

            Empleado emp = new Empleado
            {
                Nombre = nombres[rnd.Next(nombres.Length)],
                NumeroEmpleado = rnd.Next(1000, 9999),
                FechaNacimiento= DateTime.Now.AddYears(-rnd.Next(18, 60)).AddDays(rnd.Next(0, 365)),
                Genero = rnd.Next(2) == 0 ? "Masculino" : "Femenino",
                Grupo = grupos[rnd.Next(grupos.Length)],
                Sueldo = rnd.Next(6000, 25000),
                TieneSeguro = rnd.Next(2) == 0
            };

            nombre.Text = emp.Nombre;
            numero.Text = emp.NumeroEmpleado.ToString();
            fecha.Value = emp.FechaNacimiento;

            if (emp.Genero == "Masculino")
                masculino.Checked = true;
            else
                femenino.Checked = true;

            grupo.Text = emp.Grupo;
            sueldo.Text = emp.Sueldo.ToString("C");
            seguro.Checked = emp.TieneSeguro;
        }
    }
}
