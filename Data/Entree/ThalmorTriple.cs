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
    public class ThalmorTriple
    {
        /// <value>
        /// Gets the price of the entree.
        /// </<value>>
        public double Price => 8.32;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 943;

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
        /// Gets/Sets whether the entree contains bacon.
        /// </value>
        public bool Bacon { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains an egg.
        /// </value>
        public bool Egg { get; set; } = true;


        /// <value>
        /// Gets the special instructions for creating a Thalmor Triple burger entree.
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
