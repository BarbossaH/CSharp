using System;
namespace Firstone
{
	interface ICommand
	{
		void Execute();
		void Undo();
	}
}

