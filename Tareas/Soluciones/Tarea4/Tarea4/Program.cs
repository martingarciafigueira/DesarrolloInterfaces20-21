using System;
using System.Collections.Generic;

namespace Tarea4
{
    class EmpleadoAsalariado
    {
        string nombre;
        string apellidos;
        string numeroSS;
        double salario;


        //Constructores
        public EmpleadoAsalariado()
        {
            this.nombre = String.Empty;
            this.apellidos = String.Empty;
            this.numeroSS = String.Empty;
            this.salario = 0;
            
        }
        public EmpleadoAsalariado(string _nombre, string _apellidos, string _numeroSS, double _salario)
        {
            this.nombre = _nombre;
            this.apellidos = _apellidos;
            this.numeroSS = _numeroSS;
            this.salario = _salario;
        }


        //Métodos principales
        public string getNombreCompleto()
        {
            return this.nombre + " " + this.apellidos;
        }

        public double getSalarioMes()
        {
            double redondeo = this.salario / 14;

            return Math.Round(redondeo, 2);
        }

        public void incrementarSalario(double porcentaje) //Por ejemplo: 1.5%, 2.5%, 3.5% ...
        {
            this.salario = this.salario * porcentaje;
        }

        public string comparar(EmpleadoAsalariado empleado) //En este caso, la comparación la realicé con el sueldo anual.
        {
            double diferencia = 0;
            int aproximar = 0;

            if (empleado.getSalario() > this.getSalario())
            {
                diferencia = empleado.getSalario() - this.getSalario();
                aproximar = Convert.ToInt32(diferencia);

                return "El empleado " + this.getNombreCompleto() + " cobra al año " + aproximar + " euros menos que " + empleado.getNombreCompleto();
            }

            else if (empleado.getSalario() == this.getSalario())
            {
                return "Ambos empleados cobran el mismo sueldo.";
            }

            else if (this.getSalario() > empleado.getSalario())
            {
                diferencia = this.getSalario() - empleado.getSalario();
                aproximar = Convert.ToInt32(diferencia);

                return "El empleado " + empleado.getNombreCompleto() + " cobra al año " + aproximar + " euros menos que " + this.getNombreCompleto();
            }

            return " ";
        }


        //Métodos get y set.
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public string getApellidos()
        {
            return this.apellidos;
        }
        public void setApellidos(string _apellidos)
        {
            this.apellidos = _apellidos;
        }
            
        public string getNumeroSS()
        {
            return this.numeroSS;
        }
        public void setNumeroSS(string _numeroSS)
        {
            this.numeroSS = _numeroSS; 
        }

        public double getSalario()
        {
            return this.salario;
        }
        public void setSalario(double _salario)
        {
            this.salario = _salario;
        }

    }


    class EmpleadoHoras
    {
        string nombre;
        string apellidos;
        string numeroSS;
        double importeHora;
        double numHoras;


        //Constructores
        public EmpleadoHoras()
        {
            this.nombre = String.Empty;
            this.apellidos = String.Empty;
            this.numeroSS = String.Empty;
            this.importeHora = 0;
            this.numHoras = 25;
        }
        public EmpleadoHoras(string _nombre, string _apellidos, string _numeroSS, double _importeHora, double _numHoras)
        {
            this.nombre = _nombre;
            this.apellidos = _apellidos;
            this.numeroSS = _numeroSS;
            this.importeHora = _importeHora;
            this.numHoras = _numHoras;
        }


        //Métodos principales
        public string getNombreCompleto()
        {
            return this.nombre + " " + this.apellidos;
        }
        public double getSalarioMes()
        {
            double redondeo = this.importeHora * this.numHoras;
            return Math.Round(redondeo, 2);
        }
        public void incrementarSalario(double porcentaje) //Por ejemplo: 1.5%, 2.5%, 3.5% ...
        {
            this.importeHora = this.importeHora * porcentaje;
        }
        public string comparar(EmpleadoHoras empleado)
        {
            double diferencia = 0;
            int aproximar = 0;

            if(empleado.getNumHoras() > this.getNumHoras())
            {
                diferencia = empleado.getNumHoras() - this.getNumHoras();
                aproximar = Convert.ToInt32(diferencia);

                return "El empleado " + this.getNombreCompleto() + " trabajó " + aproximar + " horas menos que " + empleado.getNombreCompleto();
            }

            else if(empleado.getNumHoras() == this.getNumHoras())
            {
                return "Ambos empleados trabajaron las mismas horas.";
            }

            else if(this.getNumHoras() > empleado.getNumHoras()) {
                diferencia = this.getNumHoras() - empleado.getNumHoras();
                aproximar = Convert.ToInt32(diferencia);

                return "El empleado " + empleado.getNombreCompleto() + " trabajó " + aproximar + " horas menos que " + this.getNombreCompleto();
            }

            return " ";   
        }


        //Métodos get y set
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string _nombre)
        {
            this.nombre = _nombre;
        }

        public string getApellidos()
        {
            return this.apellidos;
        }
        public void setApellidos(string _apellidos)
        {
            this.apellidos = _apellidos;
        }

        public string getNumeroSS()
        {
            return this.numeroSS;
        }
        public void setNumeroSS(string _numeroSS)
        {
            this.numeroSS = _numeroSS;
        }
        public double getImporteHora()
        {
            return this.importeHora;
        }
        public void setImporteHora(double _importeHora)
        {
            this.importeHora = _importeHora;
        }

        public double getNumHoras()
        {
            return this.numHoras;
        }
        public void setNumHoras(double _numHoras)
        {
            this.numHoras = _numHoras;
        }
    }

    class Evaluacion
    {
        static void Main(string[] args)
        {
            //Creo dos empleados de cada clase.
            EmpleadoAsalariado empleado1 = new EmpleadoAsalariado("Nahuel", "Perdomo Barrán", "7s4s5wwd", 20000);
            EmpleadoAsalariado empleado2 = new EmpleadoAsalariado("Miguel", "Romero García", "1x5a773d", 15000);
            EmpleadoHoras empleado3 = new EmpleadoHoras("Juan", "Fernández Herrera", "2s3ta5wm", 10, 141);
            EmpleadoHoras empleado4 = new EmpleadoHoras("Sergio", "Domínguez Álvarez", "6ui123tr", 9, 106);

            // Creo dos listas, una para cada clase.
            List<EmpleadoAsalariado> empleadosAsalariados = new List<EmpleadoAsalariado>();
            List<EmpleadoHoras> empleadosHoras = new List<EmpleadoHoras>();

            // Agrego los empleados a sus respectivas listas.
            empleadosAsalariados.Add(empleado1);
            empleadosAsalariados.Add(empleado2);
            empleadosHoras.Add(empleado3);
            empleadosHoras.Add(empleado4);

            //Muestro por consola la información solicitada en la tarea. Por ejemplo, el sueldo de cada empleado:
            foreach(EmpleadoAsalariado x in empleadosAsalariados)
            {
                Console.WriteLine("El empleado " + x.getNombreCompleto() +  " es un empleado asalariado que cobra " + x.getSalarioMes() + " euros al mes.");
            }

            foreach (EmpleadoHoras y in empleadosHoras)
            {
                Console.WriteLine("El empleado " + y.getNombreCompleto() + " es un empleado contratado por horas que cobra " + y.getSalarioMes() + " euros al mes.");
            }

            //Finalmente, comparo todos los empleados entre sí:
            Console.WriteLine(empleado1.comparar(empleado2));
            Console.WriteLine(empleado3.comparar(empleado4));
        }
    }

    class Program
    {

    }
}
