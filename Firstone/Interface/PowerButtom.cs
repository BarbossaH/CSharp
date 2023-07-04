using System;
namespace Firstone
{
	 class PowerButtom: ICommand
	{
        IElectrionicDevice device;
		public PowerButtom(IElectrionicDevice device)
		{
            this.device = device;
		}

       public void Execute()
        {
           device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}

