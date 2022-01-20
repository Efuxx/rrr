using System;
using System.Text.RegularExpressions;
public class reg
{
    public static void Main()
    {
        string pattern = @"^(?![_\.\-\0-9])[0-9a-zA-Z-._]{2,}(?<![_\.\-])@([a-z]{1,9})\.([a-z]{1,9})$";
        {
            var data = new string[]
            {
  "artur.x.xлроитл@yandex.ru",
  "artur.x.x-z505-@gmail.com",
  "artur.x.x.z505@yandex=ru",
  "artur.x.x.z505###@@yandex.ru",
  "artur.x.x.z505+@yandex.ru",
  "Ar-Tur@yandex.ru",
  "arturartur@yandex.",
  "art_ur.x@yandex.ru",
  "artu5+@yandex.ru",
  "artur}}}}}}@yandex.ru",
  "artur@yandex.ru3",
  "0@yandex.ru",
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