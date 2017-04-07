using MultiPlatform.Interfaces;
using System.Collections.Generic;

namespace MultiPlatform
{
    public class iOSGrid : IGrid
    {
        private List<IButton> buttons = new List<IButton>();
        private List<ITextBox> textboxes = new List<ITextBox>();

        public void AddButton(IButton button)
        {
            buttons.Add(button);
        }

        public void AddTextBox(ITextBox textBox)
        {
            textboxes.Add(textBox);
        }

        public IEnumerable<IButton> GetButtons()
        {
            for(int i=0; i<buttons.Count; i++)
            {
                yield return buttons[i];
            }
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            for (int i = 0; i < textboxes.Count; i++)
            {
                yield return textboxes[i];
            }
        }
    }
}
