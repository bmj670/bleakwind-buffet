/*
 * Author: Benjamin M. Manglona Jr.
 * Class: Menu.cs
 * Purpose: A static class representing a menu.
 */
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// A static class representing the menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Creates new instances of all available entrees.
        /// </summary>
        /// <returns>
        /// An "IEnumerable<IOrderItem>" of all entrees offered by BleakwindBuffet.
        /// </returns>
        public IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> result = new List<IOrderItem>();
            result.Add(new BriarheartBurger());
            result.Add(new DoubleDraugr());
            result.Add(new GardenOrcOmelette());
            result.Add(new PhillyPoacher());
            result.Add(new SmokehouseSkeleton());
            result.Add(new ThalmorTriple());
            result.Add(new ThugsTBone());

            return result;
        }

        /// <summary>
        /// Creates new instances of all available sides.
        /// </summary>
        /// <returns>
        /// An "IEnumerable<IOrderItem>" of all sides offered by BleakwindBuffet.
        /// </returns>
        public IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> result = new List<IOrderItem>();
            Size[] availSizes = new Size[] { Size.Small, Size.Medium, Size.Large };

            foreach(Size currSize in availSizes)
            {
                /*Creates new sides according to the size*/
                Side fries = new DragonbornWaffleFries
                {
                    Size = currSize
                };
                Side miraak = new FriedMiraak
                {
                    Size = currSize
                };
                Side grits = new MadOtarGrits
                {
                    Size = currSize
                };
                Side salad = new VokunSalad
                {
                    Size = currSize
                };

                /*Adds the created sides to the list*/
                result.Add(fries);
                result.Add(miraak);
                result.Add(grits);
                result.Add(salad);
            }
            return result;
        }

        /// <summary>
        /// Creates new instances of all available drinks.
        /// </summary>
        /// <returns>
        /// An "IEnumerable<IOrderItem>" of all drinks offered by BleakwindBuffet.
        /// </returns>
        public IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> result = new List<IOrderItem>();
            Size[] availSizes = new Size[] { Size.Small, Size.Medium, Size.Large };
            SodaFlavor[] availflav = new SodaFlavor[] { SodaFlavor.Blackberry, SodaFlavor.Cherry,
                SodaFlavor.Grapefruit, SodaFlavor.Lemon,SodaFlavor.Peach, SodaFlavor.Watermelon
            };

            foreach (Size currSize in availSizes)
            {
                /*Creates new sides according to the size*/
                Drink aj = new AretinoAppleJuice
                {
                    Size = currSize
                };
                Drink cof = new CandlehearthCoffee
                {
                    Size = currSize
                };
                Drink mlk = new MarkarthMilk
                {
                    Size = currSize
                };
                Drink wtr = new WarriorWater
                {
                    Size = currSize
                };

                /*Creates a new sailor soda with all avail. flavors and sizes*/
                foreach (SodaFlavor currFlav in availflav)
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Flavor = currFlav;
                    Drink soda = (Drink)ss;
                    soda.Size = currSize;
                    result.Add(soda);
                }

                /*Adds the created sides to the list*/
                result.Add(aj);
                result.Add(cof);
                result.Add(mlk);
                result.Add(wtr);
            }
            return result;
        }

    }
}
