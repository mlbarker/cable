//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// IJob.cs
//-----–----------–------------------
namespace striker_poc.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface for all jobs for the moles
    /// </summary>
    public interface IJob
    {
        #region Interface Properties

        /// <summary>
        /// Name of the job
        /// </summary>
        string Name { get; }

        #endregion

        #region Interface Methods

        /// <summary>
        /// Executes the jump action.
        /// </summary>
        void Jump();
        
        /// <summary>
        /// Executes the attack action.
        /// </summary>
        void Attack();
        
        /// <summary>
        /// Executes the block action.
        /// </summary>
        void Block();
        
        /// <summary>
        /// Executes the throw action.
        /// </summary>
        void Throw();
        
        /// <summary>
        /// Executes the defend action.
        /// </summary>
        void Defend();
        
        /// <summary>
        /// Executes the item use action.
        /// </summary>
        void Item();
        
        /// <summary>
        /// Checks if the object is null.
        /// </summary>
        void Null();

        #endregion
    }
}
