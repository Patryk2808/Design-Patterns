using MultiPlatform.Interfaces;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MultiPlatform
{
    public class AndroidButton : IButton
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = Regex.Replace(value, "[eyiou]", "a");
            }
        }

        public void ButtonPressed()
        {
           Console.WriteLine($"Android is the best platform {content}");
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
