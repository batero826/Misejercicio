using System;

    class Program
    {
        static void Main(string[] args)
        {
            Aprendiz apSena = new Aprendiz();
            apSena.Nombres = "Maria del Rosario";
            apSena.Apellidos = " Zuñiga Sampablo";
            apSena.Direccion = "Carrera 19 sur";
            Saludo(apSena);
        }
        private static void Saludo(Aprendiz apSena)
        {
            Console.WriteLine("Bienvendo, sr(a) " + apSena.Nombres);
            Console.WriteLine("Su Direccion es " + apSena.Direccion);
            Console.ReadLine();
        }
    }

