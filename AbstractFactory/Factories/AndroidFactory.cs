using MultiPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform
{
    class AndroidFactory : IGuiFactory
    { 
        public IGrid GenerateGrid()
        {
            return new AndroidGrid();
        }

        public ITextBox GenerateTextBox()
        {
            return new AndroidTextBox();
        }

        public IButton GenerateButton()
        {
            return new AndroidButton();
        }
    }
}
