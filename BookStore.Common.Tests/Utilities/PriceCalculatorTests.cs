using BookStore.Common.Utilities;
using FluentAssertions;
using Xunit;

namespace BookStore.Common.Tests.Utilities
{
    public class PriceCalculatorTests
    {
        [Theory]
        [InlineData(100, 5, 95.24)]
        [InlineData(85.4, 5, 81.33)]
        [InlineData(12, 23, 9.76)]
        public void CalculateNetByGrossAndVat_Should_ReturnCalculatedNet(decimal gross, int vat, decimal expectedNet)
        {
            var calculatedNet = PriceCalculator.CalculateNetByGrossAndVat(gross, vat);

            calculatedNet.Should().Be(expectedNet);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateNetByGrossAndVat_Should_Return0_WhenGrossIsNotPositive(decimal gross)
        {
            var calculatedNet = PriceCalculator.CalculateNetByGrossAndVat(gross, 23);

            calculatedNet.Should().Be(0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateNetByGrossAndVat_Should_Return0_WhenVatIsNotPositive(int vat)
        {
            var calculatedNet = PriceCalculator.CalculateNetByGrossAndVat(23, vat);

            calculatedNet.Should().Be(0);
        }

        [Theory]
        [InlineData(95.24, 5, 100)]
        [InlineData(81.33, 5, 85.4)]
        [InlineData(9.76, 23, 12)]
        public void CalculateGrossByNetAndVat_Should_ReturnCalculatedGross(decimal net, int vat, decimal expectedGross)
        {
            var calculatedGross = PriceCalculator.CalculateGrossByNetAndVat(net, vat);

            calculatedGross.Should().Be(expectedGross);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateGrossByNetAndVat_Should_Return0_WhenNetIsNotPositive(decimal net)
        {
            var calculatedNet = PriceCalculator.CalculateGrossByNetAndVat(net, 23);

            calculatedNet.Should().Be(0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateGrossByNetAndVat_Should_Return0_WhenVatIsNotPositive(int vat)
        {
            var calculatedNet = PriceCalculator.CalculateGrossByNetAndVat(23, vat);

            calculatedNet.Should().Be(0);
        }

        [Theory]
        [InlineData(100, 95.24, 5)]
        [InlineData(12, 9.76, 23)]
        public void CalculateVatByGrossAndNet_Should_ReturnCalculatedVat(decimal gross, decimal net, int expectedVet)
        {
            var calculatedVat = PriceCalculator.CalculateVatByGrossAndNet(gross, net);

            calculatedVat.Should().Be(expectedVet);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateVatByGrossAndNet_Should_Return0_WhenGrossIsNotPositive(decimal gross)
        {
            var calculatedNet = PriceCalculator.CalculateVatByGrossAndNet(gross, 23);

            calculatedNet.Should().Be(0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CalculateVatByGrossAndNet_Should_Return0_WhenNetIsNotPositive(decimal net)
        {
            var calculatedNet = PriceCalculator.CalculateVatByGrossAndNet(23, net);

            calculatedNet.Should().Be(0);
        }
    }
}
