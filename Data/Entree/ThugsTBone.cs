/*
 * Author: Benjamin Manglona Jr.
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a ThugsTBone entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the Price of the burger
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Gets the calories of the burger
        /// </summary>
        public uint Calories => 732;

        public bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
        }
        

    }
}
