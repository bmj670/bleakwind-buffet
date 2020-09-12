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
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override  double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException("Should not execute");
                }
            }
        }


        /// <summary>
        /// The calories if the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
