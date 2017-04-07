using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Interfaces
{
	public interface IButton
	{
		string Content { set; }
		void DrawContent();
		void ButtonPressed();
	}
}
