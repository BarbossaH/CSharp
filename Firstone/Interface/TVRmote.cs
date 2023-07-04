using System;
namespace Firstone
{
	class TVRmote
	{
		public static IElectrionicDevice GetDevice() {
			return new Televsion();
		}
	}
}

