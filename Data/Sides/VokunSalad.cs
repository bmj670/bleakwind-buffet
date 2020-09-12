/*
 * Author: Benjamin Manglona Jr.
 * Class: VokunSalad.cs
 * Purpose: A class that represents a Vokun Salad side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing a Vokun Salad side. 
    /// </summary>
    public class VokunSalad : Side
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
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
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
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
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
            return $"{Size} Vokun Salad";
        }
    }
}
