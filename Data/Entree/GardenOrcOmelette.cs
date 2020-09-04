/*
 * Author: Benjamin Manglona Jr.
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent a Garden Orc Omelette entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Garden Orc Omelette entree.
    /// </summary>
    /// <remarks>
    /// A vegetarian entree with a two egg omelette packed with a mix of broccoli, 
    /// mushrooms, and tomatoes. Topped with cheddar cheese.
    /// </remarks>
    public class GardenOrcOmelette
    {
        /// <value>
        /// Gets the Price of the entree.
        /// </<value>>
        public double Price => 4.57;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 404;

        /// <value>
        /// Gets/Sets whether the entree contains broccoli.
        /// </value>
        public bool Broccoli { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains mushrooms.
        /// </value>
        public bool Mushrooms { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains tomatos.
        /// </value>
        public bool Tomato { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains cheddar.
        /// </value>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Gets the special instructions for creating a Garden Orc Omelette entree.
        /// </summary>
        /// <remarks>
        /// If there are no special instructions, it returns an empty list.
        /// </remarks>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
