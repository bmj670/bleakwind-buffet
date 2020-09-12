/*
 * Author: Benjamin M. Manglona Jr.
 * Class: DataTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Menu;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveCorrectNumberOfEntrees()
        {
            //Menu m = new Menu();
            //var result = m.Sides();
            //Side o = new VokunSalad();
            //Side t = new MadOtarGrits();

            //o.Size = Size.Large;
            //t.Size = Size.Medium;
            //IOrderItem n = o as IOrderItem;
            //IOrderItem p = t as IOrderItem;

            //Assert.Collection(result,
            //    //item => Assert.Equal(t, item),
            //    item => Assert.Equal(o.SpecialInstructions, item.SpecialInstructions),
            //    item => Assert.Equal(t.SpecialInstructions, item.SpecialInstructions)
            //    );
        }
    }
}
