using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailRegularExpression = @"[a-zA-Z0-9]\S*@\w+\.\w*[a-zA-Z]";
            Regex myReg = new Regex(emailRegularExpression);
            Console.WriteLine("Введите полный путь к указанному файлу: ");
	    try
	    {
            	string directory = Console.ReadLine();
            	string file = File.ReadAllText(@directory);
            	Console.WriteLine("Все адреса электронных почт в указанном файле: ");
            	foreach (Match match in myReg.Matches(file))
            	{
            		Console.WriteLine(match);
            	}	
	    }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Не существует файла или директории с введённым Вами названием!!!");
            }
            catch
            {
                Console.WriteLine("Непредусмотренная ошибка!!!");
            }
            Console.ReadKey();
        }
    }
}
