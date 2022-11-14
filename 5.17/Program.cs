namespace 5_17
{
    class program
    {
        static void Main(string[] args)
        {
            //realizado por DAE
            int n = 0;
            string resultado = "";
            bool v = true;

            Console.WriteLine("Escriba un número menor a 4000 y mayor a 0 por favor: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (true)
            {
                if (n < 4000 && n > 999)
                {
                    switch (n / 1000)
                    {
                        case 1: resultado += "M"; break;
                        case 2: resultado += "MM"; break;
                        case 3: resultado += "MMM"; break;
                    }
                    n -= 1000 * (n / 1000);
                }
                else if (n < 1000 && n > 99)
                {
                    switch (n / 100)
                    {
                        case 1: resultado += "C"; break;
                        case 2: resultado += "CC"; break;
                        case 3: resultado += "CCC"; break;
                        case 4: resultado += "CD"; break;
                        case 5: resultado += "D"; break;
                        case 6: resultado += "DC"; break;
                        case 7: resultado += "DCC"; break;
                        case 8: resultado += "DCCC"; break;
                        case 9: resultado += "CM"; break;
                    }
                    n -= 100 * (n / 100);
                }
                else if (n < 100 && n > 9)
                {
                    switch (n / 10)
                    {
                        case 1: resultado += "X"; break;
                        case 2: resultado += "XX"; break;
                        case 3: resultado += "XXX"; break;
                        case 4: resultado += "XL"; break;
                        case 5: resultado += "L"; break;
                        case 6: resultado += "LX"; break;
                        case 7: resultado += "LXX"; break;
                        case 8: resultado += "LXXX"; break;
                        case 9: resultado += "XC"; break;
                    }
                    n -= 10 * (n / 10);
                }
                else if (n < 10 && n > 0)
                {
                    switch (n)
                    {
                        case 1: resultado += "I"; break;
                        case 2: resultado += "II"; break;
                        case 3: resultado += "III"; break;
                        case 4: resultado += "IV"; break;
                        case 5: resultado += "V"; break;
                        case 6: resultado += "VI"; break;
                        case 7: resultado += "VII"; break;
                        case 8: resultado += "VIII"; break;
                        case 9: resultado += "IX"; break;
                    }
                    n -= n;
                }
                else
                {
                    Console.WriteLine("El número digitado no cumple con las condiciones");
                    v = false;
                    break;
                }
                if (n == 0)
                    break;
            }
            if (v)
                Console.WriteLine("");
            Console.WriteLine("El número en romano es: " + resultado);

        }
    }
}
