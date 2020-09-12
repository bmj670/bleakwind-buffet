/*
 * Author: Benjamin M. Manglona Jr.
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak mir = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(mir);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            FriedMiraak mir = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(mir);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak mir = new FriedMiraak();
            Assert.Equal(Size.Small, mir.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak mir = new FriedMiraak();
            mir.Size = Size.Large;
            Assert.Equal(Size.Large, mir.Size);
            mir.Size = Size.Medium;
            Assert.Equal(Size.Medium, mir.Size);
            mir.Size = Size.Small;
            Assert.Equal(Size.Small, mir.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak mir = new FriedMiraak();
            Assert.Empty(mir.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak mir = new FriedMiraak();
            mir.Size = size;
            Assert.Equal(price, mir.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak mir = new FriedMiraak();
            mir.Size = size;
            Assert.Equal(calories, mir.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak mir = new FriedMiraak();
            mir.Size = size;
            Assert.Equal(name, mir.ToString());
        }
    }
}