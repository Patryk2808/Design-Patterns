using MultiPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("<---------------------FIRST PLATFORM--------------------->");
            BuildInterface(new iOSFactory());
			

			Console.WriteLine("<---------------------SECOND PLATFORM--------------------->");
            BuildInterface(new WP8Factory());


            Console.WriteLine("<---------------------THIRD PLATFORM--------------------->");
            BuildInterface(new AndroidFactory());


        }

        private static void BuildInterface(IGuiFactory factory)
        {
            IGrid grid = factory.GenerateGrid();

            for(int i=0; i<3; i++)
            {
                IButton btn = factory.GenerateButton();
                btn.Content = $"Button{i+1}";
                grid.AddButton(btn);

                ITextBox txtBox = factory.GenerateTextBox();
                txtBox.Content = $"TextBox{i + 1}";
                grid.AddTextBox(txtBox);
            }

            grid.GetButtons().First().ButtonPressed();

            foreach(var elem in grid.GetButtons())
            {
                elem.ButtonPressed();
                elem.DrawContent();
            }

            foreach (var elem in grid.GetTextBoxes())
            {
                elem.DrawContent();
            }
        }
    }
}
