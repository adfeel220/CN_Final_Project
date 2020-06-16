namespace server
{
    public class Constants
    {
        public const int TICKS_PER_SEC = 35;
        public const int MS_PER_TICK = 1000 / TICKS_PER_SEC;
        public const string SERVER_IP = "192.168.1.110";
        public const int ROUTER_SERVER_PORT = 26950;
        public const int SERVER_PORT_OFFSET = 12;
        public const int SERVER_PORT = 26950;
        public const int WIN_SCORE = 50;

        // Game Setting
        public static int FinishLineScore = 3;
        public static int KillScore = 5;
        public static int Damage = 10;
    }
}