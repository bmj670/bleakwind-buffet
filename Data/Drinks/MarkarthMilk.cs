/*
 * Author: Benjamin Manglona Jr.
 * Class: MarkarthMilk.cs
 * Purpose: Class used to represent a Markarth Milk drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing a Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk
    {
        /// <value>
        /// Gets/sets whether the drink contains ice. False by default. 
        /// </value>
        public bool Ice { get; set; } = false;

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
                if (Size == Size.Small) price = 1.05;
                if (Size == Size.Medium) price = 1.11;
                if (Size == Size.Large) price = 1.22;

                return price;
            }
        }


        private uint calories = 0;      //Private backing variable for the "Calories" property.

        /// <value>
        /// Gets the calories of the drink. 
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 56;
                if (Size == Size.Medium) calories = 72;
                if (Size == Size.Large) calories = 93;

                return calories;
            }
        }

        /// <value>
        /// Gets the special instructions for creating a Markarth Milk drink. 
        /// </value>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
