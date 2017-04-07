using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    class iOSFactory : IGuiFactory
    {
        public IGrid GenerateGrid()
        {
            return new iOSGrid();
        }

        public ITextBox GenerateTextBox()
        {
            return new iOSTextBox();
        }

        public IButton GenerateButton()
        {
            return new iOSButton();
        }
    }
}