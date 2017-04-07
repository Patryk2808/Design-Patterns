using System;
using System.Linq;
using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    public class AndroidTextBox : ITextBox
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = value.Reverse().ToString();
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}