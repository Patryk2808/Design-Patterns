using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class GraphicManager
    {
        private static GraphicManager _instance;
        private static object lockObject = new object();

        public int Id { get; }
        public ConsoleColor Color { get; set; }
        public static GraphicManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        if(_instance == null)
                            _instance = new GraphicManager();
                    }
                }

                return _instance;
            }
        }

        private GraphicManager()
        {
            Random rnd = new Random();
            Id = rnd.Next(1_000_000);
        }

        public void Render(string msg)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"[GRAPHIC ID: {Id}] RENDERS: {msg}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
