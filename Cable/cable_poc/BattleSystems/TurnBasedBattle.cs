//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// TurnBasedBattle.cs
//-----–----------–------------------
namespace cable_poc.BattleSystems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Characters;
    using Interfaces;
    
    /// <summary>
    /// Basic turned based battle system.
    /// </summary>
    public class TurnBasedBattle : IBattleSystem
    {
        #region Constructors
        
        public TurnBasedBattle()
        {
        }
        
        #endregion
        
        #region IBattleSystem Methods
        
        /// <summary>
        /// Starting up the battle with fighters
        /// </summary>
        public void Initialize(List<BaseCharacter> characters)
        {
        }
        
        /// <summary>
        /// Readies the current turn
        /// </summary>
        public void ReadyTurn()
        {
        }
        
        /// <summary>
        /// Performs the current turn
        /// </summary>
        public void PerformTurn()
        {
        }
        
        /// <summary>
        /// Ends the current turn
        /// </summary>
        public void EndTurn()
        {
        }
        
        /// <summary>
        /// Performs battle ending procedures
        /// </summary>
        public void EndBattle()
        {
        }
        
        /// <summary>
        /// End of battle results
        /// </summary>
        public void Results()
        {
        }
        
        #endregion
    }
}