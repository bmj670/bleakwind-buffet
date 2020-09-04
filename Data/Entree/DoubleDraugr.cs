/*
 * Author: Benjamin Manglona Jr.
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Double Draugr burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Double Draugr burger entree.
    /// </summary>
    /// <remarks>
    /// A 1/2lb double patty burger on a brioche bun. Comes with ketchup, mustard, 
    /// pickle, cheese, tomato, lettuce, and mayo.
    /// </remarks>
    public class DoubleDraugr
    {
        /// <value>
        /// Gets the Price of the entree.
        /// </<value>>
        public double Price => 7.32;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 843;

        /// <value>
        /// Gets/Sets whether the entree contains a bun.
        /// </value>
        public bool Bun { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains ketchup.
        /// </value>
        public bool Ketchup { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains mustard.
        /// </value>
        public bool Mustard { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains pickles.
        /// </value>
        public bool Pickle { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains cheese.
        /// </value>
        public bool Cheese { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains tomatos.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains lettuce.
        /// </value>
        public bool Lettuce { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains mayo.
        /// </value>
        public bool Mayo { get; set; } = true;


        /// <value>
        /// Gets the special instructions for creating a Double Draugr burger entree.
        /// </value>
        /// <remarks>
        /// If there are no special instructions, it returns an empty list.
        /// </remarks>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold cheese");
                if (!Lettuce) instructions.Add("Hold cheese");
                if (!Mayo) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string 
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
