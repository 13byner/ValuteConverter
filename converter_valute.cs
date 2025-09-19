using System;

namespace ConvertValute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать на конвертер валют!");
            while (true)
            {
                Console.Write("Введите валюту из которой будете переводить(rub): ");
                string val = Console.ReadLine();
                Console.Write("Введите валюту в которую будете переводить(usd, eur, rub): ");
                string val2 = Console.ReadLine();
                double result = 0;
                if (proverka(val) && proverka(val2))
                {
                    Console.Write("Введите число валюты: ");
                    double chisl = Convert.ToDouble(Console.ReadLine());
                    if (val.Equals("rub"))
                    {
                        switch (val2)
                        {
                            case "usd":
                                result = chisl / 83;
                                break;
                            case "eur":
                                result = chisl / 97;
                                break;
                            case "rub":
                                result = chisl * 1;
                                break;
                        }

                    }
                    Console.WriteLine("Результат конвертации: " + result);
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите валюту корректно.");
                }
            }
        }
        private static bool proverka(string val)
        {
            string newval = val.Trim().ToLower();
            if (newval.Equals("usd") || newval.Equals("eur") || newval.Equals("rub"))
            {
                return true;
            }
            return false;
        }
    }
}
