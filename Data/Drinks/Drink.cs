/*
 * Author: Benjamin Manglona Jr.
 * Class: Drinks.cs
 * Purpose: Base class for all drinks.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks.
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// The size of the drink.
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
