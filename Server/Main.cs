using System;
using GTANetworkServer;
using GTANetworkShared;

namespace GTANResource
{
    public class Main : Script
    {
        public Main()
        {
            API.onResourceStart += onResourceStart;
        }
        public void onResourceStart()
        {
            API.consoleOutput("Resource started");
        }

        [Command("help")]
        public void HandleHelpCommand(Client sender)
        {
            API.sendNotificationToPlayer(sender, "There is no help yet", true); //TODO
        }
    }
}
