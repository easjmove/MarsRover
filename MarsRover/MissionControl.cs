public class MissionControl
{
    public void ExecuteMission()
    {
        Console.WriteLine("Mission Control: Starter dags-sekvens.");
        CommsLink earthComms = new CommsLink();
        for (int i = 0; i < 10; i++)
        {
            try
            {
                earthComms.TransmitToSpace(50); // vi beder roveren køre 50 meter
                Console.WriteLine("Mission Control: Sekvens fuldført uden fejl.");
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Vi er nu færdige...");
        }
    }
}