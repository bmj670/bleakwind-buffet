/*
 * Author: Benjamin Manglona Jr.
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone entree.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A class representing a Thugs T-Bone entree.
    /// </summary>
    public class ThugsTBone
    {
        /// <value>
        /// Gets the Price of the entree.
        /// </<value>>
        public double Price => 6.44;

        /// <value>
        /// Gets the calories of the entree.
        /// </<value>>
        public uint Calories => 982;


        /// <summary>
        /// Gets the special instructions for creating a Thugs T-Bone entree.
        /// </summary>
        /// <remarks>
        /// Since there are no options (properties), it returns an empty list. 
        /// </remarks>
        public List<string> SpecialInstructions
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
            return "Thugs T-Bone";
        }
    }
}
