/*
 * Author: Benjamin Manglona Jr.
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a Briarheart Burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Briarheart Burger entree.
    /// </summary>
    /// <remarks>
    /// A 1/4lb single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.
    /// </remarks>
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price => 6.32;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public override uint Calories => 732;

        /// <summary>
        /// Gets/Sets whether the entree contains a bun.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains ketchup.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains mustard.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains pickles.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains cheese.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// The special instructions to create the entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

    }
}