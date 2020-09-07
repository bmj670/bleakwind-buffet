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
    public class CandlehearthCoffee
    {
        /// <value>
        /// Gets/sets whether the drink contains ice. False by default. 
        /// </value>
        public bool Ice { get; set; } = false;

        /// <value>
        /// Gets/sets whether the drink contains creamer. False by default. 
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <value>
        /// Gets/sets whether the drink is decaf. False by default. 
        /// </value>
        public bool Decaf { get; set; } = false;

        /// <value>
        /// Gets/sets the size of the drink. Default Size is small. 
        /// </value>
        public Size Size { get; set; } = Size.Small;


        private double price = 0.00;        //Private backing variable for the "Price" property.

        /// <value>
        /// Gets the price of the drink.
        /// </value>
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 0.75;
                if (Size == Size.Medium) price = 1.25;
                if (Size == Size.Large) price = 1.75;

                return price;
            }
        }


        private uint calories = 0;      //Private backing variable for the "Calories" property.

        /// <value>
        /// Gets the calories of the drink. 
        /// </value>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 7;
                if (Size == Size.Medium) calories = 10;
                if (Size == Size.Large) calories = 20;

                return calories;
            }
        }

        /// <value>
        /// Gets the special instructions for creating a Candlehearth coffee drink. 
        /// </value>
        public List<string> SpecialInstructions
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
