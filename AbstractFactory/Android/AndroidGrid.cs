using System.Collections.Generic;
using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    public class AndroidGrid : IGrid
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
            yield break;
        }
    }
}