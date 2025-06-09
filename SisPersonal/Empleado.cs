namespace Empresa
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        public string Nombre;
        public string Apellido;

        public DateTime FechaNac;

        public char EstadoCivil;

        public DateTime FechaIngreso;

        public double sueldoBasico;

        public Cargos Cargo;

        public int antiguedad()
        {
            DateTime tiempoActual = DateTime.Now;

            int aniosAntiguedad = tiempoActual.Year - FechaIngreso.Year;

            if (tiempoActual.Month < FechaIngreso.Month || (tiempoActual.Month == FechaIngreso.Month && tiempoActual.Day < FechaIngreso.Day))
            {
                aniosAntiguedad--;

            }
            Console.Write("los anios de antieguedad del empleado en la empresa son: ");
            Console.WriteLine(aniosAntiguedad);
            return aniosAntiguedad;

        }

        public int edadEmpleado()
        {
            DateTime tiempoActual = DateTime.Now;

            int edadEmpleado = tiempoActual.Year - FechaNac.Year;

            if (tiempoActual.Month < FechaNac.Month || (tiempoActual.Month == FechaNac.Month && tiempoActual.Day < FechaNac.Day))
            {
                edadEmpleado--;

            }

            Console.Write("la edad del empleado son: ");
            Console.WriteLine(edadEmpleado);
            return edadEmpleado;

        }

        public void jubilacion(int edadEmpleado)
        {
            int aniosFaltantes = 65 - edadEmpleado;
            if (edadEmpleado <= 0)
            {
                Console.WriteLine("ya se puede jubilar");

            }
            else
            {
                Console.WriteLine("todavia le queda " + aniosFaltantes + " anios para jubilarse");

            }

        }

        public double salario(int aniosAntiguedad)
        {
            double adicional = 0;

            if (aniosAntiguedad < 20)
            {
                for (int i = 0; i < aniosAntiguedad; i++)
                {
                    adicional += sueldoBasico * 0.01;

                }

                if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                {
                    adicional += 0.5 * adicional;

                }
                if (EstadoCivil == 'C' || EstadoCivil == 'C')
                {
                    adicional += 150000;

                }

            }
            else if (aniosAntiguedad == 20)
            {
                if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                {
                    adicional += 0.5 * adicional;
                }
                if (EstadoCivil == 'C' || EstadoCivil == 'C')
                {
                    adicional += 150000;
                }

            }

            double salario = sueldoBasico + adicional;

            Console.Write("El salario de " + Nombre + " " + Apellido + " es:");

            Console.WriteLine(salario);

            return salario;

        }



    }
}