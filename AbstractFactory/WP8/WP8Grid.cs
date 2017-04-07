using System.Collections.Generic;
using MultiPlatform.Interfaces;

namespace MultiPlatform
{
    public class WP8Grid : IGrid
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
            for (int i = buttons.Count - 1; i >= 0; i--)
            {
                yield return buttons[i];
            }
        }

        public IEnumerable<ITextBox> GetTextBoxes()
        {
            for (int i = 0; i < textboxes.Count; i+=2)
            {
                yield return textboxes[i];
            }

            for (int i = 1; i < textboxes.Count; i += 2)
            {
                yield return textboxes[i];
            }
        }
    }
}