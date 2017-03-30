using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicManager.Instance.Color = ConsoleColor.Cyan;
            GraphicManager.Instance.Render("Hello World in Cyan");

            GraphicManager.Instance.Color = ConsoleColor.Yellow;
            GraphicManager.Instance.Render("Second message");
        }

    }
}
