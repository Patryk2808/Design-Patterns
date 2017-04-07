using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Interfaces
{
	public interface IGrid
	{
		void AddButton(IButton button);

		void AddTextBox(ITextBox textBox);

		IEnumerable<IButton> GetButtons();

		IEnumerable<ITextBox> GetTextBoxes();
	}
}
