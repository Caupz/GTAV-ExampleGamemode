using System;
using CitizenFX.Core;

namespace CopsAndRobbersServer
{
    class Utils
    {
        public static void Log(string data)
        {
            Debug.WriteLine(String.Format("CNR: {0}", data));
        }
    }
}
