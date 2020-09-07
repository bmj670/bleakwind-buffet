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
    public class WarriorWater
    {
        /// <value>
        /// Gets/sets whether the drink contains ice. False by default. 
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Gets/sets whether the drink contains lemon. False by default. 
        /// </value>
        public bool Lemon { get; set; } = false;

        /// <value>
        /// Gets/sets the size of the drink. Default Size is small. 
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public double Price => 0.00;

        /// <value>
        /// Gets the calories for the drink.
        /// </value>
        public uint Calories => 0;

        /// <value>
        /// Gets the special instructions for creating a Warrior Water drink. 
        /// </value>
        public List<string> SpecialInstructions
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
