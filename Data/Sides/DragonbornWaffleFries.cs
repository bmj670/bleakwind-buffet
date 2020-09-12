/*
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
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// The price of the side.
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
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Should not execute");
                }
            }
        }


        /// <summary>
        /// The calories of the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException("Should not execute");
                }
            }
        }

        /// <summary>
        /// The special instructions to create the side.
        /// </summary>
        public override List<string> SpecialInstructions
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
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
