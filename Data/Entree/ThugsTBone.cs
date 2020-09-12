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
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In U.S. Dollars
        /// </value>
        public override double Price => 6.44;

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public override uint Calories => 982;


        /// <summary>
        /// The special instructions to create the entree.
        /// </summary>
        public override List<string> SpecialInstructions
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
