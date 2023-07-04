using System;
namespace Firstone
{
	interface IElectrionicDevice
	{
		void On();
		void Off();
		void VolumeUp();
		void VolumeDown();
	}
}

