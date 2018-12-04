//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// IBattleSystem.cs
//-----–----------–------------------
namespace cable_poc.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    /// <summary>
    /// Battle system interface.
    /// </summary>
    public interface IBattleSystem
    {
        /// <summary>
        /// Starting up the battle with fighters
        /// </summary>
        void Initialize(List<BaseCharacter> characters);
        
        /// <summary>
        /// Readies the current turn
        /// </summary>
        void ReadyTurn();
        
        /// <summary>
        /// Performs the current turn
        /// </summary>
        void PerformTurn();
        
        /// <summary>
        /// Ends the current turn
        /// </summary>
        void EndTurn();
        
        /// <summary>
        /// Performs battle ending procedures
        /// </summary>
        void EndBattle();
        
        /// <summary>
        /// End of battle results
        /// </summary>
        void Results();
    }
}