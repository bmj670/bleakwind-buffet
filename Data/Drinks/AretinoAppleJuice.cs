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
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// Gets/sets whether the drink contains ice. 
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
                    default: throw new NotImplementedException("Should never execute");
                }
            }
        }

        /// <summary>
        /// Gets the calories of the drink. 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never execute");
                }
            }
        }

        /// <summary>
        /// The special instructions to create the drink.
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <returns>The name of the drink.</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
