namespace prEstructuraIterativaDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btningresar_Click(object sender, EventArgs e)
        {
            //Declaracion De Variables
            int CantAlumnos, nota;
            double promedio = 0;
            //entrada de datos

            CantAlumnos = Convert.ToInt32(txtalumnos.Text);
            //Processo
            //Implementar un bucle for para pedir las notas de los alumnos

            for (int i = 1; i <= CantAlumnos; i++)
            {
                //Leer la nota del alumno n

                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno" + i, "Registro De Notas"));

                } while (nota < 0 || nota > 20);

                promedio = promedio + nota;

            }
            //Salida De Informacion
            txtpromedio.Text = Convert.ToString(promedio / CantAlumnos);



        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtalumnos.Clear();
            txtpromedio.Clear();    
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}