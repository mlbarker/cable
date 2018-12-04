//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseCharacter.cs
//-----–----------–------------------
namespace cable_poc.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    /// <summary>
    /// Base implementation that all characters will inherit.
    /// </summary>
    public abstract class BaseCharacter
    {
        #region Fields
        #endregion

        #region Public Properties
        
        /// <summary>
        /// The character's name
        /// </summary>
        public string Name { get; private set; } = "Gal";
        
        /// <summary>
        /// Is this character playable?
        /// </summary>
        public bool Playable { get; private set; } = false;

        /// <summary>
        /// The character's max hit points
        /// </summary>
        public int MaxHitPoints { get; private set; } = 20;
        
        /// <summary>
        /// The character's hit points
        /// </summary>
        public int HitPoints { get; private set; } = 20;

        /// <summary>
        /// The character's strength
        /// </summary>
        public int Strength { get; private set; } = 20;
        
        /// <summary>
        /// The character's defense
        /// </summary>
        public int Defense { get; private set; } = 20;
        
        /// <summary>
        /// Is this character alive?
        /// </summary>
        public bool Alive { get; private set; } = true;

        #endregion

        #region Constructors

        /// <summary>
        /// Base constructor
        /// </summary>
        public BaseCharacter()
        {

        }

        /// <summary>
        /// Constructor for max HP, strength and defense
        /// </summary>
        /// <param name="name">The character's name</param>
        /// <param name="maxHitPoints">The amount of max hp</param>
        /// <param name="strength">The amount of strength</param>
        /// <param name="defense">The amount of defense</param>
        /// <param name="playable">Is this character playable?</param>
        public BaseCharacter(string name, int maxHitPoints, int strength, int defense, bool playable)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            HitPoints = MaxHitPoints;
            Strength = strength;
            Defense = defense;
            Playable = playable;
            
            if (HitPoints > 0)
            {
                IsAlive = true;
            }
        }

        #endregion

        #region Abstract Methods/Properties

        /// <summary>
        /// The specific attack for this character.
        /// </summary>
        /// <param name="enemyDefense">The enemy's defense.</param>
        public abstract void Attack(int enemyDefense);

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize the character with any attributes necessary.
        /// </summary>
        public void Initialize()
        {
            
        }
        
        /// <summary>
        /// Defensive action for the character that grants some HP.
        /// </summary>
        public void Defend()
        {
            float tenPercent = 0.1f;
            float mHP = (float)MaxHitPoints;
            
            HitPoints += (int)(tenPercent * mHP);
            CapHitPoints();
        }

        /// <summary>
        /// Adjust the character's HP.
        /// </summary>
        /// <param name="changeAmt">The amount to change.</param>
        public void AdjustHitPoints(int changeAmt)
        {
            HitPoints += changeAmt;
            CapHitPoints();
        }
        
        /// <summary>
        /// Updating the character's status.
        /// </summary>
        public void UpdateStatus()
        {
            // Defeated...
            if (HitPoints <= 0)
            {
                // Snapping HP to 0 if it went negative
                HitPoints = 0;
                Alive = false;
            }
        }

        #endregion
        
        #region Private Methods
        
        /// <summary>
        /// Helper to cap hit points at max.
        /// </summary>
        private void CapHitPoints()
        {
            if (HitPoints > MaxHitPoints)
            {
                HitPoints = MaxHitPoints;
            }
        }
        
        #endregion
    }
}
