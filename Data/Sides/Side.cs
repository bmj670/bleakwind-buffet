/*
 * Author: Benjamin Manglona Jr.
 * Class: Side.cs
 * Purpose: Base class for the sides.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of the sides.
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side.
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions to create the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
