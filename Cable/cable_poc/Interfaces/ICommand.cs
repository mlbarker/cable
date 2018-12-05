//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// ICommand.cs
//-----–----------–------------------
namespace cable_poc.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface for the command pattern
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command on the actor
        /// </summary>
        /// <param name="actor">The actor that will execute the command</param>
        //void Execute(Actor actor);

        /// <summary>
        /// Checks to see if the command is null
        /// </summary>
        //bool IsNull();
    }
}