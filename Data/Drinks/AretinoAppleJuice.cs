/*
 * Author: Benjamin M. Manglona Jr.
 * Class: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice drink.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice
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
                if (Size == Size.Small) price = 0.62;
                if (Size == Size.Medium) price = 0.87;
                if (Size == Size.Large) price = 1.01;

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
                if (Size == Size.Small) calories = 44;
                if (Size == Size.Medium) calories = 88;
                if (Size == Size.Large) calories = 132;

                return calories;
            }
        }

        /// <value>
        /// Gets the special instructions for creating an Aretino Apple Juice drink. 
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
            string size = Size.ToString();
            return $"{size} Aretino Apple Juice";
        }
    }
}
