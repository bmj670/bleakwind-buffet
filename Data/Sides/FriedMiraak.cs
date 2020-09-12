/*
 * Author: Benjamin Manglona Jr.
 * Class: FriedMiraak.cs
 * Purpose: A class that represents a Fried Miraak side.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing a Fried Miraak side.
    /// </summary>
    public class FriedMiraak : Side
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
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
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
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
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
            return $"{Size} Fried Miraak";
        }
    }
}
