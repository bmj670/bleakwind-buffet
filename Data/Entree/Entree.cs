/*
 * Author: Benjamin Manglona Jr.
 * Class name: Entree.cs
 * Purpose: Base class for the entree's.
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A base class representing the entree's.
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        
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
