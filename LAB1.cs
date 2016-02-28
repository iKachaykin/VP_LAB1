using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailRegularExpression = @"[a-zA-Z0-9]\S*@\w+\.\w*[a-zA-Z]";
            Regex myReg = new Regex(emailRegularExpression);
            
        }
    }
}
