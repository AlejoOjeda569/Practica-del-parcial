namespace Practica_del_parcial
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
           

            double radio = pedirmetodo("Ingrese el valor del Radio=");
            double altura = pedirmetodo("Ingrese el valor de la Altura= ");

            double generatriz = CalcularGeneratriz(radio, altura);
            double area = CalcualrArea(radio, generatriz);
            double volumen = CalcularVolumen(radio, altura, generatriz);
          
            if (radio>0 && altura>0)
            {
                Console.WriteLine($"El Area del cono es {area } ");
                Console.WriteLine($"El Volumen del cono es {volumen}");

            }
            else
            {
                Console.WriteLine("los numeros de Radio o Altura no pueden ser 0");
            }
        }

        private static double CalcularVolumen(double radio, double altura, double generatriz)
        {
            return (Math.PI*Math.Pow(radio,2)*altura)/ 3;
        }

        private static double CalcualrArea(double radio, double generatriz)
        {
            return Math.PI * radio + (radio + generatriz);
        }

        private static double CalcularGeneratriz(double radio, double altura)
        {
            return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        }

        private static double pedirmetodo(string menseje)
        {
            double nro = 0;
            do
            {
                Console.Write(menseje);
                string strconsole = Console.ReadLine();
                if (!double.TryParse(strconsole, out nro))
                {
                    Console.WriteLine("Número mal ingresado");
                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
    }
      
}
