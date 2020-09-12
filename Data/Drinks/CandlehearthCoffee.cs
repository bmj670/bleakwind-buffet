/*
 * Author: Benjamin Manglona Jr.
 * Class: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth coffee drink.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing a Candlehearth coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        /// <summary>
        /// Gets/sets whether the drink contains ice. 
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Gets/sets whether the drink contains creamer.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Gets/sets whether the drink is decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;

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
                    case Size.Small: return 0.75;
                    case Size.Medium: return 1.25;
                    case Size.Large: return 1.75;
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
                    case Size.Small: return 7;
                    case Size.Medium: return 10;
                    case Size.Large: return 20;
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
                if (RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            if (Decaf) return $"{Size} Decaf Candlehearth Coffee";
            else return "";
        }
    }
}
