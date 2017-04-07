using MultiPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform
{
    interface IGuiFactory
    {
        IGrid GenerateGrid();
        IButton GenerateButton();
        ITextBox GenerateTextBox();
    }
}
