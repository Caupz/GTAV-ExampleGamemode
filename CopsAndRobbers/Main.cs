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
        Base core = new Base();
        public Main()
        {
            Debug.WriteLine("MAIN SUBSCRIBING TO EVENTS");
            core.OnPlayerTryingToEnterVehicle += OnPlayerTryingToEnterVehicle;
            core.OnPlayerEnteredVehicle += OnPlayerEnteredVehicle;
            core.OnPlayerLeaveVehicle += OnPlayerLeaveVehicle;
            core.OnPlayerSeatChange += OnPlayerSeatChange;
            core.OnPlayerSpawnIntoVehicle += OnPlayerSpawnIntoVehicle;
            Debug.WriteLine("MAIN SUBSCRIBED TO EVENTS");
            core.enableRealtimeGametime = true;
            // TODO eventid teha ja listenida.
            // TODO testida nii palju evente kui saab.
        }

        public void OnPlayerTryingToEnterVehicle(int vehicleHandle, int vehicleSeat)
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

        public void OnPlayerSeatChange(int vehicleHandle, int newVehicleSeat)
        {
            Debug.WriteLine("CNR: OnPlayerSeatChange");
        }

        public void OnPlayerSpawnIntoVehicle(int vehicleHandle)
        {
            Debug.WriteLine("CNR: OnPlayerSpawnIntoVehicle");
        }

        [Tick]
        async Task OnTickMain()
        {
            core.Process();
        }
    }
}
