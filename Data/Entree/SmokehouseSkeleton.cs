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
    public class SmokehouseSkeleton
    {
        /// <value>
        /// Gets the price of the entree.
        /// </<value>>
        public double Price => 5.62;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 602;

        /// <value>
        /// Gets/Sets whether the entree contains sausage links.
        /// </value>
        public bool SausageLink { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains eggs.
        /// </value>
        public bool Egg { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree contains hash browns.
        /// </value>
        public bool HashBrowns { get; set; } = true;

        /// <value>
        /// Gets/Sets whether the entree containts pancakes.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Gets the special instructions for creating a Smokehouse Skeleton entree.
        /// </summary>
        /// <remarks>
        /// If there are no special instructions, it returns an empty list.
        /// </remarks>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
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
