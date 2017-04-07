using System;
using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    public class WP8TextBox : ITextBox
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = value.Substring(content.Length / 2);
            }
        }

        public void DrawContent()
        {
            Console.WriteLine($"{content} by Microsoft");
        }
    }
}