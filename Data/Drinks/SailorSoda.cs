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
    public class SailorSoda : Drink
    {
        /// <summary>
        /// Gets/sets whether the drink contains ice.
        /// </summary>
        public bool Ice { get; set; } = true;


        /// <summary>
        /// Gets/sets the flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;


        /// <summary>
        /// The price of the drink.
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
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never execute");
                }
            }
        }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
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
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
