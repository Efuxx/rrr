using System;
using System.Text.RegularExpressions;
public class reg
{
    public static void Main()
    {
        string pattern = @"([a-z0-9_-])*[a-z0-9_-]+@[a-z0-9_-]+([a-z0-9_-]+)*\.[a-z]{2,9}$";
        {
            var data = new string[]
            {
  "artur.x.xлроитл@yandex.ru",
  "artur.x.x.z505@gmail.com",
  "artur.x.x.z505@yandex=ru",
  "artur.x.x.z505###@@yandex.ru",
  "artur.x.x.z505+@yandex.ru",
  "artur.x.x.z505@yandex.ru",
  "arturartur@yandex.",
  "artur.x@.ru",
  "artu5@yandex.ru",
  "artur}}}}}}@yandex.ru",
  "artur@yandex.ru3",
            };

            for (int i = 0; i < data.Length; i++)
            {
                if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(data[i]);
                   
                }
            }
        }
    }
}