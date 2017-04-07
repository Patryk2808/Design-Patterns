using MultiPlatform.Interfaces;
using System;

namespace MultiPlatform
{
    public class iOSButton : IButton
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = value;
            }
        }

        public void ButtonPressed()
        {
            Console.WriteLine($"IOS Button pressed, content: {content}");
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
