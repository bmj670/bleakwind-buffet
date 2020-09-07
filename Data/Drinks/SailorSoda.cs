/*
 * Author: Benjamin Manglona Jr.
 * Class: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing a Silor Soda drink.
    /// </summary>
    public class SailorSoda
    {
        /// <value>
        /// Gets/sets whether the drink contains ice. True by default. 
        /// </value>
        public bool Ice { get; set; } = true;

        /// <value>
        /// Gets/sets the size of the drink. Default Size is small. 
        /// </value>
        public Size Size { get; set; } = Size.Small;

        /// <value>
        /// Gets/sets the flavor of the drink. Default flavor is Cherry. 
        /// </value>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;


        private double price = 0.00;    //Private backing variable for the "Price" property.

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.42;
                if (Size == Size.Medium) price = 1.74;
                if (Size == Size.Large) price = 2.07;

                return price;
            }
        }


        private uint calories = 0;      //Private backing variable for the "Price" property.

        /// <value>
        /// Gets the calories of the drink. 
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 117;
                if (Size == Size.Medium) calories = 153;
                if (Size == Size.Large) calories = 205;

                return calories;
            }
        }

        /// <value>
        /// Gets the special instructions for creating a Sailor Soda drink. 
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
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
