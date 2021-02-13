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
            Debug.WriteLine("======== CopsAndRobbersServer Main ========");
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
            Debug.WriteLine("======== CopsAndRobbersServer Main END ========");
        }

        public void OnPlayerSpawned(Player client)
        {
            Debug.WriteLine("CNR OnPlayerSpawned " + client.Handle);
        }

        public void OnPlayerStartedWalking(Player client)
        {
            Debug.WriteLine("OnPlayerStartedWalking");
        }

        public void OnPlayerStoppedWalking(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedWalking");
        }

        public void OnPlayerStartedRunning(Player client)
        {
            Debug.WriteLine("OnPlayerStartedRunning");
        }

        public void OnPlayerStoppedRunning(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedRunning");
        }

        public void OnPlayerStartedSprinting(Player client)
        {
            Debug.WriteLine("OnPlayerStartedSprinting");
        }

        public void OnPlayerStoppedSprinting(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedSprinting");
        }

        public void OnPlayerStartedJumping(Player client)
        {
            Debug.WriteLine("OnPlayerStartedJumping");
        }

        public void OnPlayerStoppedJumping(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedJumping");
        }

        public void OnPlayerCuffed(Player client)
        {
            Debug.WriteLine("OnPlayerCuffed");
        }

        public void OnPlayerUnCuffed(Player client)
        {
            Debug.WriteLine("OnPlayerUnCuffed");
        }

        public void OnPlayerStartedToGetUp(Player client)
        {
            Debug.WriteLine("OnPlayerStartedToGetUp");
        }

        public void OnPlayerStoppedToGetUp(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedToGetUp");
        }

        public void OnPlayerStartedToAimFromCover(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedToAimFromCover");
        }

        public void OnPlayerStoppedToAimFromCover(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedToAimFromCover");
        }

        public void OnPlayerStartedGettingJacked(Player client)
        {
            Debug.WriteLine("OnPlayerStartedGettingJacked");
        }

        public void OnPlayerStoppedGettingJacked(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedGettingJacked");
        }

        public void OnPlayerStartedJacking(Player client)
        {
            Debug.WriteLine("OnPlayerStartedJacking");
        }

        public void OnPlayerStoppedJacking(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedJacking");
        }

        public void OnPlayerStartedGettingStunned(Player client)
        {
            Debug.WriteLine("OnPlayerStartedGettingStunned");
        }

        public void OnPlayerStoppedGettingStunned(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedGettingStunned");
        }

        public void OnPlayerStartedClimbing(Player client)
        {
            Debug.WriteLine("OnPlayerStartedClimbing");
        }

        public void OnPlayerStoppedClimbing(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedClimbing");
        }

        public void OnPlayerDied(Player client, float x, float y, float z)
        {
            Debug.WriteLine("OnPlayerDied");
        }

        public void OnPlayerRevived(Player client, float x, float y, float z)
        {
            Debug.WriteLine("OnPlayerRevived");
        }

        public void OnPlayerStartedDiving(Player client)
        {
            Debug.WriteLine("OnPlayerStartedDiving");
        }

        public void OnPlayerStoppedDiving(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedDiving");
        }

        public void OnPlayerStartedDriveBy(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedDriveBy");
        }

        public void OnPlayerStoppedDriveBy(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedDriveBy");
        }

        public void OnPlayerStartedFalling(Player client)
        {
            Debug.WriteLine("OnPlayerStartedFalling");
        }

        public void OnPlayerStoppedFalling(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedFalling");
        }

        public void OnPlayerStartedOnFoot(Player client)
        {
            Debug.WriteLine("OnPlayerStartedOnFoot");
        }

        public void OnPlayerStoppedOnFoot(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedOnFoot");
        }

        public void OnPlayerEnteredMeleeCombat(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerEnteredMeleeCombat");
        }

        public void OnPlayerLeftMeleeCombat(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerLeftMeleeCombat");
        }

        public void OnPlayerEnteredCover(Player client)
        {
            Debug.WriteLine("OnPlayerEnteredCover");
        }

        public void OnPlayerLeftCover(Player client)
        {
            Debug.WriteLine("OnPlayerLeftCover");
        }

        public void OnPlayerEnteredParachuteFreefall(Player client)
        {
            Debug.WriteLine("OnPlayerEnteredParachuteFreefall");
        }

        public void OnPlayerLeftParachuteFreefall(Player client)
        {
            Debug.WriteLine("OnPlayerLeftParachuteFreefall");
        }

        public void OnPlayerStartedReloading(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedReloading");
        }

        public void OnPlayerStoppedReloading(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedReloading");
        }

        public void OnPlayerStartedShooting(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedShooting");
        }

        public void OnPlayerStoppedShooting(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedShooting");
        }

        public void OnPlayerStartedSwimming(Player client)
        {
            Debug.WriteLine("OnPlayerStartedSwimming");
        }

        public void OnPlayerStoppedSwimming(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedSwimming");
        }

        public void OnPlayerStartedSwimmingUnderwater(Player client)
        {
            Debug.WriteLine("OnPlayerStartedSwimmingUnderwater");
        }

        public void OnPlayerStoppedSwimmingUnderwater(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedSwimmingUnderwater");
        }

        public void OnPlayerStartedStealthKill(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedStealthKill");
        }

        public void OnPlayerStoppedStealthKill(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedStealthKill");
        }

        public void OnPlayerStartedVaulting(Player client)
        {
            Debug.WriteLine("OnPlayerStartedVaulting");
        }

        public void OnPlayerStoppedVaulting(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedVaulting");
        }

        public void OnPlayerStartedWearingHelmet(Player client)
        {
            Debug.WriteLine("OnPlayerStartedWearingHelmet");
        }

        public void OnPlayerStoppedWearingHelmet(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedWearingHelmet");
        }

        public void OnPlayerEnteredMainMenu(Player client)
        {
            Debug.WriteLine("OnPlayerEnteredMainMenu");
        }

        public void OnPlayerLeftMainMenu(Player client)
        {
            Debug.WriteLine("OnPlayerLeftMainMenu");
        }

        public void OnPlayerReadyToShoot(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerReadyToShoot");
        }

        public void OnPlayerNotReadyToShoot(Player client)
        {
            Debug.WriteLine("OnPlayerNotReadyToShoot");
        }

        public void OnPlayerStartedAiming(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStartedAiming");
        }

        public void OnPlayerStoppedAiming(Player client, uint weapon)
        {
            Debug.WriteLine("OnPlayerStoppedAiming");
        }

        public void OnPlayerHealthGain(Player client, int oldHealth, int newHealth)
        {
            Debug.WriteLine("OnPlayerHealthGain");
        }

        public void OnPlayerHealthLoss(Player client, int oldHealth, int newHealth)
        {
            Debug.WriteLine("OnPlayerHealthLoss");
        }

        public void OnPlayerArmourGain(Player client, int oldArmour, int newArmour)
        {
            Debug.WriteLine("OnPlayerArmourGain");
        }

        public void OnPlayerArmourLoss(Player client, int oldArmour, int newArmour)
        {
            Debug.WriteLine("OnPlayerArmourLoss");
        }

        public void OnPlayerTryingToEnterVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerTryingToEnterVehicle");
        }

        public void OnPlayerEnteredVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredVehicle");
        }

        public void OnPlayerLeaveVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeaveVehicle");
        }

        public void OnPlayerSeatChange(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerSeatChange");
        }

        public void OnPlayerSpawnIntoVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerSpawnIntoVehicle");
        }

        public void OnPlayerEnteredBoat(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredBoat");
        }

        public void OnPlayerLeftBoat(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftBoat");
        }

        public void OnPlayerEnteredHeli(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredHeli");
        }

        public void OnPlayerLeftHeli(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftHeli");
        }

        public void OnPlayerEnteredPlane(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredPlane");
        }

        public void OnPlayerLeftPlane(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftPlane");
        }

        public void OnPlayerEnteredPoliceVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredPoliceVehicle");
        }

        public void OnPlayerLeftPoliceVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftPoliceVehicle");
        }

        public void OnPlayerEnteredSub(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredSub");
        }

        public void OnPlayerLeftSub(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftSub");
        }

        public void OnPlayerEnteredTaxi(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredTaxi");
        }

        public void OnPlayerLeftTaxi(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftTaxi");
        }

        public void OnPlayerEnteredTrain(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredTrain");
        }

        public void OnPlayerLeftTrain(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftTrain");
        }

        public void OnPlayerEnteredFlyingVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerEnteredFlyingVehicle");
        }

        public void OnPlayerLeftFlyingVehicle(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerLeftFlyingVehicle");
        }

        public void OnPlayerStartedOnBike(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerStartedOnBike");
        }

        public void OnPlayerStoppedOnBike(Player client, int vehicleNetworkId, int seat)
        {
            Debug.WriteLine("OnPlayerStoppedOnBike");
        }

        public void OnPlayerStartedOnVehicle(Player client)
        {
            Debug.WriteLine("OnPlayerStartedOnVehicle");
        }

        public void OnPlayerStoppedOnVehicle(Player client)
        {
            Debug.WriteLine("OnPlayerStoppedOnVehicle");
        }

        public void OnPlayerStartedJumpingOutOfVehicle(Player client, int vehicleNetworkId, int vehicleSeat)
        {
            Debug.WriteLine("OnPlayerStartedJumpingOutOfVehicle");
        }

        public void OnPlayerStoppedJumpingOutOfVehicle(Player client, int vehicleNetworkId, int vehicleSeat)
        {
            Debug.WriteLine("OnPlayerStoppedJumpingOutOfVehicle");
        }

        public void OnPlayerStartedMovingVehicle(Player client, int vehicleNetworkId)
        {
            Debug.WriteLine("OnPlayerStartedMovingVehicle");
        }

        public void OnPlayerStoppedVehicle(Player client, int vehicleNetworkId)
        {
            Debug.WriteLine("OnPlayerStoppedVehicle");
        }

        public void OnPlayerStartedBurnouting(Player client, int vehicleNetworkId)
        {
            Debug.WriteLine("OnPlayerStartedBurnouting");
        }

        public void OnPlayerStoppedBurnouting(Player client, int vehicleNetworkId)
        {
            Debug.WriteLine("OnPlayerStoppedBurnouting");
        }

        public void OnVehicleHealthGain(Player client, int vehicleNetworkId, int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Debug.WriteLine("OnVehicleHealthGain");
        }

        public void OnVehicleHealthLoss(Player client, int vehicleNetworkId, int vehicleHealth, float vehicleBodyHealth, float vehicleEngineHealth, float vehiclePetrolTankHealth)
        {
            Debug.WriteLine("OnVehicleHealthLoss");
        }

        public void OnVehicleCrash(Player client, int vehicleNetworkId)
        {
            Debug.WriteLine("OnVehicleCrash");
        }
    }
}
