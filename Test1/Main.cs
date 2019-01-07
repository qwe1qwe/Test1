using System;
using GTANetworkAPI;

namespace Test1 {
    public class Main : Script {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart() {
            NAPI.Util.ConsoleOutput("3BLUB :)");
        }
    }
}