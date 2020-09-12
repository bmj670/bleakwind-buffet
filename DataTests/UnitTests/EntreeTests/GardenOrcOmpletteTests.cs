/*
 * Author: Benjamin M. Manglona Jr.
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(oml);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(oml);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.True(oml.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.True(oml.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.True(oml.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.True(oml.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            oml.Broccoli = false;
            Assert.False(oml.Broccoli);
            oml.Broccoli = true;
            Assert.True(oml.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            oml.Mushrooms = false;
            Assert.False(oml.Mushrooms);
            oml.Mushrooms = true;
            Assert.True(oml.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            oml.Tomato = false;
            Assert.False(oml.Tomato);
            oml.Tomato = true;
            Assert.True(oml.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            oml.Cheddar = false;
            Assert.False(oml.Cheddar);
            oml.Cheddar = true;
            Assert.True(oml.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.Equal(4.57, oml.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            uint cal = 404;
            Assert.Equal(cal, oml.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            oml.Broccoli = includeBroccoli;
            oml.Mushrooms = includeMushrooms;
            oml.Tomato = includeTomato;
            oml.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", oml.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", oml.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", oml.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", oml.SpecialInstructions);
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(oml.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette oml = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", oml.ToString());
        }
    }
}