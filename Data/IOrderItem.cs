/*
 * Author: Benjamin M. Manglona Jr.
 * Class: IOrderItem.cs
 * Purpose: An interface to determine what can be invoked.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface indicating what can be passed.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the order.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions for creating the order.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
