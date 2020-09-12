/*
 * Author: Benjamin Manglona Jr.
 * Class: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing a Warrior Water Drink.
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Gets/sets whether the drink contains ice.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Gets/sets whether the drink contains lemon.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        public override double Price => 0.00;

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public override uint Calories => 0;

        /// <summary>
        /// The special instructions for creating the drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
