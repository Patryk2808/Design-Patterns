using MultiPlatform.Interfaces;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform
{

    public class iOSTextBox : ITextBox
    {
        private string content = "";
        public string Content
        {
            set
            {
                content = value;
            }
        }

        public void DrawContent()
        {
            Console.WriteLine(content);
        }
    }
}
