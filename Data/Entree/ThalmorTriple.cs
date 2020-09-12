/*
 * Author: Benjamin Manglona Jr.
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent a Thalmor Triple burger entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Thalmor Triple burger entree.
    /// </summary>
    /// <remarks>
    /// A 1lb burger with two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, 
    /// pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.
    /// </remarks>
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price => 8.32;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public override uint Calories => 943;

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
        /// Gets/Sets whether the entree contains tomatos.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains lettuce.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains mayo.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains bacon.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains an egg.
        /// </summary>
        public bool Egg { get; set; } = true;


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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string 
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
