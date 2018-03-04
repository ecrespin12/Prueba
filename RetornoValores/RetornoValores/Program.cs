using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornoValores
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numeros = new int[5] { 2, 3, 5, 7, 8 };

            MaximoMinimo maxMinResultado = obtenerMaximoMinimo(numeros);

            Console.WriteLine("Val1"+ maxMinResultado.Val1 +  " Val2 " + maxMinResultado.Val2);
            Console.ReadKey();
        }

        public static MaximoMinimo obtenerMaximoMinimo(int[] valores)
        {
            MaximoMinimo maxMin = new MaximoMinimo();
            maxMin.Val1 = 1;
            maxMin.Val2 = valores[1]+1;

            return maxMin;
        }

        public struct MaximoMinimo
        {
            private int val1;
            private int val2;
            public int Val1
            {
                get
                {
                    return val1;
                }
                set
                {
                    val1 = value;
                }
            }

            public int Val2
            {
                get  {
                    return val2;
                }
                set  {
                    val2 = value;
                }
            }
        }
    }


}
