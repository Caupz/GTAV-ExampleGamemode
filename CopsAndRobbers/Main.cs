using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using MPEventFramework;
using static CitizenFX.Core.Native.API;

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

        bool helmState = false;

        private void OnClientResourceStart(string resourceName)
        {
            RegisterCommand("cuffs", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                if(IsPedCuffed(core.pedHandle))
                {
                    SetEnableHandcuffs(core.pedHandle, false);
                }
                else
                {
                    SetEnableHandcuffs(core.pedHandle, true);
                }
            }), false);

            RegisterCommand("weapon", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int weapon = 0;

                if (Int32.TryParse(args[0].ToString(), out weapon))
                {
                    SetEntityHealth(core.pedHandle, weapon);
                }

                if(weapon < MPEventFramework.Weapon.weaponNames.Count)
                {
                    GiveWeaponToPed(core.pedHandle, (uint)GetHashKey(MPEventFramework.Weapon.weaponNames[weapon]), 1000, false, true);
                }
            }), false);

            RegisterCommand("hp", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int hp = 0;

                if(Int32.TryParse(args[0].ToString(), out hp))
                {
                    SetEntityHealth(core.pedHandle, hp);
                }
            }), false);

            RegisterCommand("armour", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int arm = 0;

                if (Int32.TryParse(args[0].ToString(), out arm))
                {
                    SetPedArmour(core.pedHandle, arm);
                }
            }), false);

            RegisterCommand("helm", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                helmState = !helmState;
                SetPedConfigFlag(core.pedHandle, 35, helmState);
            }), false);
        }
    }
}
