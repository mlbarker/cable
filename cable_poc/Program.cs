//+src=BattleSystems/TurnBasedBattle.cs
//+src=Characters/BaseCharacter.cs
//+src=Game/Game.cs
//+src=Interfaces/IGame.cs
//+src=Interfaces/IBattleSystem.cs
//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Program.cs
//-----–----------–------------------
namespace cable_poc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Game;

    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            
            game.Initialize();
            game.Run();
            game.Shutdown();            
        }
    }
}