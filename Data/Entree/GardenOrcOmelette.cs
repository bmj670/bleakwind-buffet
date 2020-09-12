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
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override uint Calories => 404;

        /// <summary>
        /// Gets/Sets whether the entree contains broccoli.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains mushrooms.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains tomatos.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains cheddar.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// The special instructions to create the entree.
        /// </summary>
        public override List<string> SpecialInstructions
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
