﻿/*
 * Author: Benjamin Manglona Jr.
 * Class: DragonbornWaffleFries.cs
 * Purpose: A class that represents a Dragonborn Waffle Fries side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing a Dragonborn Waffle Fries side.
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <value>
        /// Gets/sets the size of the drink. Default Size is small. 
        /// </value>
        public Size Size { get; set; } = Size.Small;


        private double price = 0.00;    //Private backing variable for the "Price" property.

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 0.42;
                if (Size == Size.Medium) price = 0.76;
                if (Size == Size.Large) price = 0.96;

                return price;
            }
        }


        private uint calories = 0;  //Private backing variable for the "Calories" property.

        /// <value>
        /// Gets the calories of the drink. 
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 77;
                if (Size == Size.Medium) calories = 89;
                if (Size == Size.Large) calories = 100;

                return calories;
            }
        }

        /// <value>
        /// Gets the special instructions for creating the side. 
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            string size = Size.ToString();
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}