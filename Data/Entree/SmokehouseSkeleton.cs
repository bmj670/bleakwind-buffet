/*
 * Author: Benjamin Manglona Jr.
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Smokehouse Skeleton entree.
    /// </summary>
    /// <remarks>
    /// A breakfast combo consisting of sausage links, eggs, and hash browns on the side. 
    /// Topped with the syrup of your choice.
    /// </remarks>
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price => 5.62;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Gets/Sets whether the entree contains sausage links.
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains eggs.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree contains hash browns.
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Gets/Sets whether the entree containts pancakes.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// The special instructions to create the entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hashbrowns");
                if (!Pancake) instructions.Add("Hold pancakes");

                return instructions;
            }
        }

        /// <summary>
        /// Changes the way the object is represented as a string.
        /// </summary>
        /// <returns>The name of the entree.</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
