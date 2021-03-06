using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using MPFrameworkServer;

namespace CopsAndRobbersServer
{
    public class Main : BaseScript
    {
        public Main()
        {
            Utils.Log("======== CopsAndRobbersServer Main ========");
            ServerCore.debug = true;
            ServerCore.OnPlayerSpawned += OnPlayerSpawned;
            ServerCore.OnPlayerStartedWalking += OnPlayerStartedWalking;
            ServerCore.OnPlayerStoppedWalking += OnPlayerStoppedWalking;
            ServerCore.OnPlayerStartedRunning += OnPlayerStartedRunning;
            ServerCore.OnPlayerStoppedRunning += OnPlayerStoppedRunning;
            ServerCore.OnPlayerStartedSprinting += OnPlayerStartedSprinting;
            ServerCore.OnPlayerStoppedSprinting += OnPlayerStoppedSprinting;
            ServerCore.OnPlayerStartedJumping += OnPlayerStartedJumping;
            ServerCore.OnPlayerStoppedJumping += OnPlayerStoppedJumping;
            ServerCore.OnPlayerCuffed += OnPlayerCuffed;
            ServerCore.OnPlayerUnCuffed += OnPlayerUnCuffed;
            ServerCore.OnPlayerStartedToGetUp += OnPlayerStartedToGetUp;
            ServerCore.OnPlayerStoppedToGetUp += OnPlayerStoppedToGetUp;
            ServerCore.OnPlayerStartedToAimFromCover += OnPlayerStartedToAimFromCover;
            ServerCore.OnPlayerStoppedToAimFromCover += OnPlayerStoppedToAimFromCover;
            ServerCore.OnPlayerStartedGettingJacked += OnPlayerStartedGettingJacked;
            ServerCore.OnPlayerStoppedGettingJacked += OnPlayerStoppedGettingJacked;
            ServerCore.OnPlayerStartedJacking += OnPlayerStartedJacking;
            ServerCore.OnPlayerStoppedJacking += OnPlayerStoppedJacking;
            ServerCore.OnPlayerStartedGettingStunned += OnPlayerStartedGettingStunned;
            ServerCore.OnPlayerStoppedGettingStunned += OnPlayerStoppedGettingStunned;
            ServerCore.OnPlayerStartedClimbing += OnPlayerStartedClimbing;
            ServerCore.OnPlayerStoppedClimbing += OnPlayerStoppedClimbing;
            ServerCore.OnPlayerDied += OnPlayerDied;
            ServerCore.OnPlayerRevived += OnPlayerRevived;
            ServerCore.OnPlayerStartedDiving += OnPlayerStartedDiving;
            ServerCore.OnPlayerStoppedDiving += OnPlayerStoppedDiving;
            ServerCore.OnPlayerStartedDriveBy += OnPlayerStartedDriveBy;
            ServerCore.OnPlayerStoppedDriveBy += OnPlayerStoppedDriveBy;
            ServerCore.OnPlayerStartedFalling += OnPlayerStartedFalling;
            ServerCore.OnPlayerStoppedFalling += OnPlayerStoppedFalling;
            ServerCore.OnPlayerStartedOnFoot += OnPlayerStartedOnFoot;
            ServerCore.OnPlayerStoppedOnFoot += OnPlayerStoppedOnFoot;
            ServerCore.OnPlayerEnteredMeleeCombat += OnPlayerEnteredMeleeCombat;
            ServerCore.OnPlayerLeftMeleeCombat += OnPlayerLeftMeleeCombat;
            ServerCore.OnPlayerEnteredCover += OnPlayerEnteredCover;
            ServerCore.OnPlayerLeftCover += OnPlayerLeftCover;
            ServerCore.OnPlayerEnteredParachuteFreefall += OnPlayerEnteredParachuteFreefall;
            ServerCore.OnPlayerLeftParachuteFreefall += OnPlayerLeftParachuteFreefall;
            ServerCore.OnPlayerStartedReloading += OnPlayerStartedReloading;
            ServerCore.OnPlayerStoppedReloading += OnPlayerStoppedReloading;
            ServerCore.OnPlayerStartedShooting += OnPlayerStartedShooting;
            ServerCore.OnPlayerStoppedShooting += OnPlayerStoppedShooting;
            ServerCore.OnPlayerStartedSwimming += OnPlayerStartedSwimming;
            ServerCore.OnPlayerStoppedSwimming += OnPlayerStoppedSwimming;
            ServerCore.OnPlayerStartedSwimmingUnderwater += OnPlayerStartedSwimmingUnderwater;
            ServerCore.OnPlayerStoppedSwimmingUnderwater += OnPlayerStoppedSwimmingUnderwater;
            ServerCore.OnPlayerStartedStealthKill += OnPlayerStartedStealthKill;
            ServerCore.OnPlayerStoppedStealthKill += OnPlayerStoppedStealthKill;
            ServerCore.OnPlayerStartedVaulting += OnPlayerStartedVaulting;
            ServerCore.OnPlayerStoppedVaulting += OnPlayerStoppedVaulting;
            ServerCore.OnPlayerStartedWearingHelmet += OnPlayerStartedWearingHelmet;
            ServerCore.OnPlayerStoppedWearingHelmet += OnPlayerStoppedWearingHelmet;
            ServerCore.OnPlayerEnteredMainMenu += OnPlayerEnteredMainMenu;
            ServerCore.OnPlayerLeftMainMenu += OnPlayerLeftMainMenu;
            ServerCore.OnPlayerReadyToShoot += OnPlayerReadyToShoot;
            ServerCore.OnPlayerNotReadyToShoot += OnPlayerNotReadyToShoot;
            ServerCore.OnPlayerStartedAiming += OnPlayerStartedAiming;
            ServerCore.OnPlayerStoppedAiming += OnPlayerStoppedAiming;
            ServerCore.OnPlayerHealthGain += OnPlayerHealthGain;
            ServerCore.OnPlayerHealthLoss += OnPlayerHealthLoss;
            ServerCore.OnPlayerArmourGain += OnPlayerArmourGain;
            ServerCore.OnPlayerArmourLoss += OnPlayerArmourLoss;

            ServerCore.OnPlayerTryingToEnterVehicle += OnPlayerTryingToEnterVehicle;
            ServerCore.OnPlayerEnteredVehicle += OnPlayerEnteredVehicle;
            ServerCore.OnPlayerLeaveVehicle += OnPlayerLeaveVehicle;
            ServerCore.OnPlayerSeatChange += OnPlayerSeatChange;
            ServerCore.OnPlayerSpawnIntoVehicle += OnPlayerSpawnIntoVehicle;
            ServerCore.OnPlayerEnteredBoat += OnPlayerEnteredBoat;
            ServerCore.OnPlayerLeftBoat += OnPlayerLeftBoat;
            ServerCore.OnPlayerEnteredHeli += OnPlayerEnteredHeli;
            ServerCore.OnPlayerLeftHeli += OnPlayerLeftHeli;
            ServerCore.OnPlayerEnteredPlane += OnPlayerEnteredPlane;
            ServerCore.OnPlayerLeftPlane += OnPlayerLeftPlane;
            ServerCore.OnPlayerEnteredPoliceVehicle += OnPlayerEnteredPoliceVehicle;
            ServerCore.OnPlayerLeftPoliceVehicle += OnPlayerLeftPoliceVehicle;
            ServerCore.OnPlayerEnteredSub += OnPlayerEnteredSub;
            ServerCore.OnPlayerLeftSub += OnPlayerLeftSub;
            ServerCore.OnPlayerEnteredTaxi += OnPlayerEnteredTaxi;
            ServerCore.OnPlayerLeftTaxi += OnPlayerLeftTaxi;
            ServerCore.OnPlayerEnteredTrain += OnPlayerEnteredTrain;
            ServerCore.OnPlayerLeftTrain += OnPlayerLeftTrain;
            ServerCore.OnPlayerEnteredFlyingVehicle += OnPlayerEnteredFlyingVehicle;
            ServerCore.OnPlayerLeftFlyingVehicle += OnPlayerLeftFlyingVehicle;
            ServerCore.OnPlayerStartedOnBike += OnPlayerStartedOnBike;
            ServerCore.OnPlayerStoppedOnBike += OnPlayerStoppedOnBike;
            ServerCore.OnPlayerStartedOnVehicle += OnPlayerStartedOnVehicle;
            ServerCore.OnPlayerStoppedOnVehicle += OnPlayerStoppedOnVehicle;
            ServerCore.OnPlayerStartedJumpingOutOfVehicle += OnPlayerStartedJumpingOutOfVehicle;
            ServerCore.OnPlayerStoppedJumpingOutOfVehicle += OnPlayerStoppedJumpingOutOfVehicle;
            ServerCore.OnPlayerStartedMovingVehicle += OnPlayerStartedMovingVehicle;
            ServerCore.OnPlayerStoppedVehicle += OnPlayerStoppedVehicle;
            ServerCore.OnPlayerStartedBurnouting += OnPlayerStartedBurnouting;
            ServerCore.OnPlayerStoppedBurnouting += OnPlayerStoppedBurnouting;
            ServerCore.OnVehicleHealthGain += OnVehicleHealthGain;
            ServerCore.OnVehicleHealthLoss += OnVehicleHealthLoss;
            ServerCore.OnVehicleCrash += OnVehicleCrash;
            ServerCore.OnPlayerWeaponChange += OnPlayerWeaponChange;
            Utils.Log("======== CopsAndRobbersServer Main END ========");
        }

        public void OnPlayerSpawned(Player client)
        {
            Utils.Log("CNR OnPlayerSpawned " + client.Handle);
        }

        public void OnPlayerStartedWalking(Player client)
        {
            Utils.Log("OnPlayerStartedWalking");
        }

        public void OnPlayerStoppedWalking(Player client)
        {
            Utils.Log("OnPlayerStoppedWalking");
        }

        public void OnPlayerStartedRunning(Player client)
        {
            Utils.Log("OnPlayerStartedRunning");
        }

        public void OnPlayerStoppedRunning(Player client)
        {
            Utils.Log("OnPlayerStoppedRunning");
        }

        public void OnPlayerStartedSprinting(Player client)
        {
            Utils.Log("OnPlayerStartedSprinting");
        }

        public void OnPlayerStoppedSprinting(Player client)
        {
            Utils.Log("OnPlayerStoppedSprinting");
        }

        public void OnPlayerStartedJumping(Player client)
        {
            Utils.Log("OnPlayerStartedJumping");
        }

        public void OnPlayerStoppedJumping(Player client)
        {
            Utils.Log("OnPlayerStoppedJumping");
        }

        public void OnPlayerCuffed(Player client)
        {
            Utils.Log("OnPlayerCuffed");
        }

        public void OnPlayerUnCuffed(Player client)
        {
            Utils.Log("OnPlayerUnCuffed");
        }

        public void OnPlayerStartedToGetUp(Player client)
        {
            Utils.Log("OnPlayerStartedToGetUp");
        }

        public void OnPlayerStoppedToGetUp(Player client)
        {
            Utils.Log("OnPlayerStoppedToGetUp");
        }

        public void OnPlayerStartedToAimFromCover(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedToAimFromCover");
        }

        public void OnPlayerStoppedToAimFromCover(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedToAimFromCover");
        }

        public void OnPlayerStartedGettingJacked(Player client)
        {
            Utils.Log("OnPlayerStartedGettingJacked");
        }

        public void OnPlayerStoppedGettingJacked(Player client)
        {
            Utils.Log("OnPlayerStoppedGettingJacked");
        }

        public void OnPlayerStartedJacking(Player client)
        {
            Utils.Log("OnPlayerStartedJacking");
        }

        public void OnPlayerStoppedJacking(Player client)
        {
            Utils.Log("OnPlayerStoppedJacking");
        }

        public void OnPlayerStartedGettingStunned(Player client)
        {
            Utils.Log("OnPlayerStartedGettingStunned");
        }

        public void OnPlayerStoppedGettingStunned(Player client)
        {
            Utils.Log("OnPlayerStoppedGettingStunned");
        }

        public void OnPlayerStartedClimbing(Player client)
        {
            Utils.Log("OnPlayerStartedClimbing");
        }

        public void OnPlayerStoppedClimbing(Player client)
        {
            Utils.Log("OnPlayerStoppedClimbing");
        }

        public void OnPlayerDied(Player client, float x, float y, float z)
        {
            Utils.Log("OnPlayerDied");
        }

        public void OnPlayerRevived(Player client, float x, float y, float z)
        {
            Utils.Log("OnPlayerRevived");
        }

        public void OnPlayerStartedDiving(Player client)
        {
            Utils.Log("OnPlayerStartedDiving");
        }

        public void OnPlayerStoppedDiving(Player client)
        {
            Utils.Log("OnPlayerStoppedDiving");
        }

        public void OnPlayerStartedDriveBy(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedDriveBy");
        }

        public void OnPlayerStoppedDriveBy(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedDriveBy");
        }

        public void OnPlayerStartedFalling(Player client)
        {
            Utils.Log("OnPlayerStartedFalling");
        }

        public void OnPlayerStoppedFalling(Player client)
        {
            Utils.Log("OnPlayerStoppedFalling");
        }

        public void OnPlayerStartedOnFoot(Player client)
        {
            Utils.Log("OnPlayerStartedOnFoot");
        }

        public void OnPlayerStoppedOnFoot(Player client)
        {
            Utils.Log("OnPlayerStoppedOnFoot");
        }

        public void OnPlayerEnteredMeleeCombat(Player client, uint weapon)
        {
            Utils.Log("OnPlayerEnteredMeleeCombat");
        }

        public void OnPlayerLeftMeleeCombat(Player client, uint weapon)
        {
            Utils.Log("OnPlayerLeftMeleeCombat");
        }

        public void OnPlayerEnteredCover(Player client)
        {
            Utils.Log("OnPlayerEnteredCover");
        }

        public void OnPlayerLeftCover(Player client)
        {
            Utils.Log("OnPlayerLeftCover");
        }

        public void OnPlayerEnteredParachuteFreefall(Player client)
        {
            Utils.Log("OnPlayerEnteredParachuteFreefall");
        }

        public void OnPlayerLeftParachuteFreefall(Player client)
        {
            Utils.Log("OnPlayerLeftParachuteFreefall");
        }

        public void OnPlayerStartedReloading(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedReloading");
        }

        public void OnPlayerStoppedReloading(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedReloading");
        }

        public void OnPlayerStartedShooting(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedShooting");
        }

        public void OnPlayerStoppedShooting(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedShooting");
        }

        public void OnPlayerStartedSwimming(Player client)
        {
            Utils.Log("OnPlayerStartedSwimming");
        }

        public void OnPlayerStoppedSwimming(Player client)
        {
            Utils.Log("OnPlayerStoppedSwimming");
        }

        public void OnPlayerStartedSwimmingUnderwater(Player client)
        {
            Utils.Log("OnPlayerStartedSwimmingUnderwater");
        }

        public void OnPlayerStoppedSwimmingUnderwater(Player client)
        {
            Utils.Log("OnPlayerStoppedSwimmingUnderwater");
        }

        public void OnPlayerStartedStealthKill(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedStealthKill");
        }

        public void OnPlayerStoppedStealthKill(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedStealthKill");
        }

        public void OnPlayerStartedVaulting(Player client)
        {
            Utils.Log("OnPlayerStartedVaulting");
        }

        public void OnPlayerStoppedVaulting(Player client)
        {
            Utils.Log("OnPlayerStoppedVaulting");
        }

        public void OnPlayerStartedWearingHelmet(Player client)
        {
            Utils.Log("OnPlayerStartedWearingHelmet");
        }

        public void OnPlayerStoppedWearingHelmet(Player client)
        {
            Utils.Log("OnPlayerStoppedWearingHelmet");
        }

        public void OnPlayerEnteredMainMenu(Player client)
        {
            Utils.Log("OnPlayerEnteredMainMenu");
        }

        public void OnPlayerLeftMainMenu(Player client)
        {
            Utils.Log("OnPlayerLeftMainMenu");
        }

        public void OnPlayerReadyToShoot(Player client, uint weapon)
        {
            Utils.Log("OnPlayerReadyToShoot");
        }

        public void OnPlayerNotReadyToShoot(Player client)
        {
            Utils.Log("OnPlayerNotReadyToShoot");
        }

        public void OnPlayerStartedAiming(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStartedAiming");
        }

        public void OnPlayerStoppedAiming(Player client, uint weapon)
        {
            Utils.Log("OnPlayerStoppedAiming");
        }

        public void OnPlayerHealthGain(Player client, int oldHealth, int newHealth)
        {
            Utils.Log("OnPlayerHealthGain");
        }

        public void OnPlayerHealthLoss(Player client, int oldHealth, int newHealth)
        {
            Utils.Log("OnPlayerHealthLoss");
        }

        public void OnPlayerArmourGain(Player client, int oldArmour, int newArmour)
        {
            Utils.Log("OnPlayerArmourGain");
        }

        public void OnPlayerArmourLoss(Player client, int oldArmour, int newArmour)
        {
            Utils.Log("OnPlayerArmourLoss");
        }

        public void OnPlayerTryingToEnterVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerTryingToEnterVehicle");
        }

        public void OnPlayerEnteredVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredVehicle");
        }

        public void OnPlayerLeaveVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeaveVehicle");
        }

        public void OnPlayerSeatChange(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerSeatChange");
        }

        public void OnPlayerSpawnIntoVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerSpawnIntoVehicle");
        }

        public void OnPlayerEnteredBoat(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredBoat");
        }

        public void OnPlayerLeftBoat(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftBoat");
        }

        public void OnPlayerEnteredHeli(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredHeli");
        }

        public void OnPlayerLeftHeli(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftHeli");
        }

        public void OnPlayerEnteredPlane(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredPlane");
        }

        public void OnPlayerLeftPlane(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftPlane");
        }

        public void OnPlayerEnteredPoliceVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredPoliceVehicle");
        }

        public void OnPlayerLeftPoliceVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftPoliceVehicle");
        }

        public void OnPlayerEnteredSub(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredSub");
        }

        public void OnPlayerLeftSub(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftSub");
        }

        public void OnPlayerEnteredTaxi(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredTaxi");
        }

        public void OnPlayerLeftTaxi(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftTaxi");
        }

        public void OnPlayerEnteredTrain(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredTrain");
        }

        public void OnPlayerLeftTrain(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftTrain");
        }

        public void OnPlayerEnteredFlyingVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerEnteredFlyingVehicle");
        }

        public void OnPlayerLeftFlyingVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerLeftFlyingVehicle");
        }

        public void OnPlayerStartedOnBike(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerStartedOnBike");
        }

        public void OnPlayerStoppedOnBike(Player client, int vehicleNetworkId, int seat)
        {
            Utils.Log("OnPlayerStoppedOnBike");
        }

        public void OnPlayerStartedOnVehicle(Player client)
        {
            Utils.Log("OnPlayerStartedOnVehicle");
        }

        public void OnPlayerStoppedOnVehicle(Player client)
        {
            Utils.Log("OnPlayerStoppedOnVehicle");
        }

        public void OnPlayerStartedJumpingOutOfVehicle(Player client, int vehicleNetworkId, int vehicleSeat)
        {
            Utils.Log("OnPlayerStartedJumpingOutOfVehicle");
        }

        public void OnPlayerStoppedJumpingOutOfVehicle(Player client, int vehicleNetworkId, int vehicleSeat)
        {
            Utils.Log("OnPlayerStoppedJumpingOutOfVehicle");
        }

        public void OnPlayerStartedMovingVehicle(Player client, int vehicleNetworkId)
        {
            Utils.Log("OnPlayerStartedMovingVehicle");
        }

        public void OnPlayerStoppedVehicle(Player client, int vehicleNetworkId)
        {
            Utils.Log("OnPlayerStoppedVehicle");
        }

        public void OnPlayerStartedBurnouting(Player client, int vehicleNetworkId)
        {
            Utils.Log("OnPlayerStartedBurnouting");
        }

        public void OnPlayerStoppedBurnouting(Player client, int vehicleNetworkId)
        {
            Utils.Log("OnPlayerStoppedBurnouting");
        }

        public void OnVehicleHealthGain(Player client, int vehicleNetworkId, int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Utils.Log("OnVehicleHealthGain");
        }

        public void OnVehicleHealthLoss(Player client, int vehicleNetworkId, int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Utils.Log("OnVehicleHealthLoss");
        }

        public void OnVehicleCrash(Player client, int vehicleNetworkId)
        {
            Utils.Log("OnVehicleCrash");
        }

        public void OnPlayerWeaponChange(Player client, uint oldWeapon, uint newWeapon)
        {
            Debug.WriteLine("CNR: OnPlayerWeaponChange");
        }
    }
}
