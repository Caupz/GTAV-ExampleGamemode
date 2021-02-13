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
            EventHandlers["onClientResourceStart"] += new Action<string>(OnClientResourceStart);
            Debug.WriteLine("MAIN SUBSCRIBING TO EVENTS");
            core.OnPlayerTryingToEnterVehicle += OnPlayerTryingToEnterVehicle;
            core.OnPlayerEnteredVehicle += OnPlayerEnteredVehicle;
            core.OnPlayerLeaveVehicle += OnPlayerLeaveVehicle;
            core.OnPlayerSeatChange += OnPlayerSeatChange;
            core.OnPlayerSpawnIntoVehicle += OnPlayerSpawnIntoVehicle;
            core.OnPlayerSpawned += OnPlayerSpawned;

            Debug.WriteLine("MAIN SUBSCRIBED TO EVENTS");
            // TODO eventid teha ja listenida.
            // TODO testida nii palju evente kui saab.
        }

        public void OnPlayerSpawned()
        {
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
            Debug.WriteLine("CNR: OnPlayerSpawned NEW PED " + Base.PedHandle);
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
                Debug.WriteLine("cuffs1");
                if (IsPedCuffed(Base.PedHandle))
                {
                    Debug.WriteLine("cuffs2");
                    SetEnableHandcuffs(Base.PedHandle, false);
                }
                else
                {
                    Debug.WriteLine("cuffs3");
                    SetEnableHandcuffs(Base.PedHandle, true);
                }
            }), false);

            RegisterCommand("weapon", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int weapon = 0;

                if (Int32.TryParse(args[0].ToString(), out weapon))
                {
                    Debug.WriteLine("weapon " + weapon + " MPEventFramework.Weapon.weaponNames.Count:" + MPEventFramework.Weapon.weaponNames.Count);

                    if (weapon < MPEventFramework.Weapon.weaponNames.Count)
                    {
                        Debug.WriteLine("giving");
                        GiveWeaponToPed(Base.PedHandle, (uint)GetHashKey(MPEventFramework.Weapon.weaponNames[weapon]), 1000, false, true);
                    }
                }
            }), false);

            RegisterCommand("weaponstr", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                string weapon = args[0].ToString();

                Debug.WriteLine("giving");
                uint wep = (uint)GetHashKey(weapon);
                GiveWeaponToPed(Base.PedHandle, wep, 1, false, true);
                SetPedWeaponTintIndex(Base.PedHandle, wep, 1);
                SetPedInfiniteAmmo(Base.PedHandle, true, wep);
            }), false);

            RegisterCommand("hp", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int hp = 0;

                Debug.WriteLine("hp");
                if (Int32.TryParse(args[0].ToString(), out hp))
                {
                    Debug.WriteLine("hp:"+hp);
                    SetEntityHealth(Base.PedHandle, hp);
                }
            }), false);

            RegisterCommand("armour", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                int arm = 0;

                Debug.WriteLine("arm");
                if (Int32.TryParse(args[0].ToString(), out arm))
                {
                    Debug.WriteLine("arm:" + arm);
                    SetPedArmour(Base.PedHandle, arm);
                }
            }), false);

            RegisterCommand("helm", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                helmState = !helmState;
                Debug.WriteLine("helmState:" + helmState);
                SetPedConfigFlag(Base.PedHandle, 35, helmState);
                GivePedHelmet(Base.PedHandle, false, helmState ? 1 : 0, 4096);
            }), false);

            RegisterCommand("para", new Action<int, List<object>, string>(async (source, args, raw) =>
            {
                SetPedGadget(Base.PedHandle, (uint)GetHashKey(("GADGET_PARACHUTE")), true);
            }), false);
        }
    }
}
