using MultiPlatform.Interfaces;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform
{
    public class WP8Button : IButton
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = value.ToUpper();
            }
        }

        public void ButtonPressed()
        {
            Console.WriteLine("WP8 button pressed");
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
