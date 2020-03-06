using System;

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
        }
        public static void Calculadora()
        {
            int Operacion = 0;
            Console.WriteLine(" Ingrese una operación: ");
            Console.WriteLine(" 1. Suma ");
            Console.WriteLine(" 2. Resta ");
            Console.WriteLine(" 3. Multiplicación ");
            Console.WriteLine(" 4. Division ");
            Int32.TryParse(Console.ReadLine(), out Operacion);
            
            switch (Operacion) 
            {

                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Mutiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    FinEjercicio();
                    break;
            }
            FinEjercicio();
        }
        public static void Suma() 
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 + num2;
            Console.WriteLine(" El resultado es= "+resultado);
            Console.ReadLine();
            


        }
        public static void Resta()
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 - num2;
            Console.WriteLine(" El resultado es= " + resultado);
            Console.ReadLine();
            
        }

        public static void Mutiplicacion()
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine(" Ingrese el segundo numero ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 * num2;
            Console.WriteLine(" El resultado es= " + resultado);
            Console.ReadLine();
           
        }

        public static void Division()
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine(" Ingrese el primer numero ");
            Int32.TryParse(Console.ReadLine(), out num2);
            resultado = num1 / num2;
            Console.WriteLine(" El resultado es= " + resultado);
            Console.ReadLine();
           
        }
        //Funion Sin parametros, sin retorno
        public static void FinEjercicio()
        {

           string respuesta = "";

            Console.WriteLine(" Desea realizar una nueva operación (Y/N) ");
            respuesta = Console.ReadLine();
            if (respuesta == "Y")
            {
                Calculadora();
            }
            else 
            {
                Console.WriteLine(" Fin del Programa");
                Console.ReadLine();
            }           
        }
    }

