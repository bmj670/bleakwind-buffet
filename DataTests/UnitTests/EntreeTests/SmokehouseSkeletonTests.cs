/*
 * Author: Benjamin M. Manglona Jr.
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(sk);
        }

        [Fact]
        public void ShouldImplementIOrderItem()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(sk);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.True(sk.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.SausageLink = false;
            Assert.False(sk.SausageLink);
            sk.SausageLink = true;
            Assert.True(sk.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.Egg = false;
            Assert.False(sk.Egg);
            sk.Egg = true;
            Assert.True(sk.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.HashBrowns = false;
            Assert.False(sk.HashBrowns);
            sk.HashBrowns = true;
            Assert.True(sk.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.Pancake = false;
            Assert.False(sk.Pancake);
            sk.Pancake = true;
            Assert.True(sk.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.Equal(5.62, sk.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            uint cal = 602;
            Assert.Equal(cal, sk.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            sk.SausageLink = includeSausage;
            sk.Egg = includeEgg;
            sk.HashBrowns = includeHashbrowns;
            sk.Pancake = includePancake;

            if (!includeSausage) Assert.Contains("Hold sausage", sk.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", sk.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hashbrowns", sk.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", sk.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(sk.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton sk = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", sk.ToString());
        }
    }
}