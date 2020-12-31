using System;

namespace UD9_1al10
{
    class Program
    {
        public static void Ejercicio1()
        {
            Alumno A1 = new Alumno();
            A1.Nombre = "Arnau";
            A1.Edad = 33;
            A1.ImprimirAlumno();
            A1.MayorDeEdad();
        }
        public static void Ejercicio2()
        {
            Empleado E1 = new Empleado();
            E1.Nombre = "Arnau";
            E1.Sueldo = 3300;
            E1.ImprimirEmpleado();
            E1.Impuestos();
        }
        public static void Ejercicio3()
        {
            Operaciones Dato = new Operaciones();
            Dato.num1 = 10;
            Dato.num2 = 3;
            Console.WriteLine(Dato.Suma(Dato.num1, Dato.num2));
            Console.WriteLine(Dato.Resta(Dato.num1, Dato.num2));
            Console.WriteLine(Dato.Mult(Dato.num1, Dato.num2));
            Console.WriteLine(Dato.Div(Dato.num1, Dato.num2));
        }
        public static void Ejercicio4PruebaPersona()
        {
            Persona Yo = new Persona();
            Persona Tu = new Persona();
            Yo.SetNombre("Arnau");
            Tu.SetNombre("NoArnau");
            Yo.Saludar();
            Tu.Saludar();
        }
        public static void Ejercicio5()
        {
            Libro L1 = new Libro();
            L1.Nuevo("Arnau Diez", "C Sharp Pro Tips", "Reus");
            L1.Mostrar();
        }
        public static void Ejercicio6()
        {
            Coche C1 = new Coche();
            C1.Nuevo("Peugeot", "307", 110, 1.6);
            C1.Mostrar();
        }
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4PruebaPersona();
            //Ejercicio5();
            Ejercicio6();
            // El ejercicio 7 solo es la clase 'Persona2'
            // El ejercicio 8 solo es la clase 'Password'
            // El ejercicio 9 solo es la clase 'Electrodomestico'
            // El ejercicio 10 solo es la clase 'Serie'



        }
    }
}
