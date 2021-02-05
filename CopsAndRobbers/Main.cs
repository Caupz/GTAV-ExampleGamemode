using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using MPEventFramework;

namespace CopsAndRobbers
{
    public class Main : BaseScript
    {
        MPEventFramework.Main Events = new MPEventFramework.Main();

        public Main()
        {
            Events.OnTryingToEnterVehicle += OnTryingToEnterVehicle;
            Events.OnPlayerEnteredVehicle += OnPlayerEnteredVehicle;
            Events.OnPlayerLeaveVehicle += OnPlayerLeaveVehicle;
        }

        public void OnTryingToEnterVehicle(int vehicleHandle)
        {
            Debug.WriteLine("CNR: OnTryingToEnterVehicle");
        }

        public void OnPlayerEnteredVehicle(int vehicleHandle, int vehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerEnteredVehicle");
        }

        public void OnPlayerLeaveVehicle(int vehicleHandle, int vehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerLeaveVehicle");
        }
    }
}
