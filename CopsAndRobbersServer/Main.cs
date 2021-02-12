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
        Server server = new Server();

        public Main()
        {
            Debug.WriteLine("======== CopsAndRobbersServer Main ========");
            server.OnPlayerSpawned += OnPlayerSpawned;
            Debug.WriteLine("======== CopsAndRobbersServer Main END ========");
        }

        public void OnPlayerSpawned(Player client)
        {
            Debug.WriteLine("CNR OnPlayerSpawned "+client.Handle);
        }
    }
}
