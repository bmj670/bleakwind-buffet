/*
 * Author: Benjamin M. Manglona Jr.
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vok = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vok);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            VokunSalad vok = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vok);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vok = new VokunSalad();
            Assert.Equal(Size.Small, vok.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vok = new VokunSalad();
            vok.Size = Size.Large;
            Assert.Equal(Size.Large, vok.Size);
            vok.Size = Size.Medium;
            Assert.Equal(Size.Medium, vok.Size);
            vok.Size = Size.Small;
            Assert.Equal(Size.Small, vok.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vok = new VokunSalad();
            Assert.Empty(vok.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vok = new VokunSalad();
            vok.Size = size;
            Assert.Equal(price, vok.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vok = new VokunSalad();
            vok.Size = size;
            Assert.Equal(calories, vok.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vok = new VokunSalad();
            vok.Size = size;
            Assert.Equal(name, vok.ToString());
        }
    }
}