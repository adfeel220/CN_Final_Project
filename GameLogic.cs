using System;
using System.Text;
using System.Collections.Generic;
namespace server
{
    public class GameLogic
    {
        public static int readyPlayers = 0;
        public static int currentPlayers = 0;
        public static bool isGameStarted = false;
        public static int[] score = new int[2];

        private static int timer = 0;
        private static int frameIncreaseFactor = 1;

        public static void Reset() {
            readyPlayers = 0;
            currentPlayers = 0;
            isGameStarted = false;
            for (int i=0; i<2; i++) {
                score[i] = 0;
            }
            RouterServer.Initialize();
            Server.Initialize();
        }
        public static void Update() {
            ThreadManager.UpdateMain();
            
            if (isGameStarted){
                if (timer == 0){
                    ServerSend.PositionRotationAllUpdate();
                }
                timer = (timer +1) % frameIncreaseFactor;

                if (currentPlayers == 0) {
                    Reset();

                    Console.WriteLine($"RESET: No player is online, reset Game Logic");
                }
            }
        }
    }
}