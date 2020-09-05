/*
 * Author: Benjamin Manglona Jr.
 * Class: MadOtarGrits.cs
 * Purpose: A class that represents a Mad Otar Grits side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing a Mad Otar Grits side.
    /// </summary>
    public class MadOtarGrits
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
                if (Size == Size.Small) price = 1.22;
                if (Size == Size.Medium) price = 1.58;
                if (Size == Size.Large) price = 1.93;

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
                if (Size == Size.Small) calories = 105;
                if (Size == Size.Medium) calories = 142;
                if (Size == Size.Large) calories = 179;

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
            return $"{size} Mad Otar Grits";
        }
    }
}
