/*
 * Author: Zachery Brunner
 * Edited by: Benjamin M. Manglona Jr.
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.True(br.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.True(br.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.True(br.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.True(br.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.True(br.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Bun = false;
            Assert.False(br.Bun);
            br.Bun = true;
            Assert.True(br.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Ketchup = false;
            Assert.False(br.Ketchup);
            br.Ketchup = true;
            Assert.True(br.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Mustard = false;
            Assert.False(br.Mustard);
            br.Mustard = true;
            Assert.True(br.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Pickle = false;
            Assert.False(br.Pickle);
            br.Pickle = true;
            Assert.True(br.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Cheese = false;
            Assert.False(br.Cheese);
            br.Cheese = true;
            Assert.True(br.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.Equal(6.32, br.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger br = new BriarheartBurger();
            uint cal = 732;
            Assert.Equal(cal, br.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger br = new BriarheartBurger();
            br.Bun = includeBun;
            br.Ketchup = includeKetchup;
            br.Mustard = includeMustard;
            br.Pickle = includePickle;
            br.Cheese = includeCheese;

            if (!includeBun) Assert.Contains("Hold bun", br.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", br.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", br.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", br.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", br.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(br.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger br = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", br.ToString());
        }
    }
}