using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    class WP8Factory : IGuiFactory
    {
        public IGrid GenerateGrid()
        {
            return new WP8Grid();
        }

        public ITextBox GenerateTextBox()
        {
            return new WP8TextBox();
        }

        public IButton GenerateButton()
        {
            return new WP8Button();
        }
    }
}