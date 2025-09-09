// <copyright file="CalculatorTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestModernSoftwareApp
{
    using ModernSoftwareApp;

    /// <summary>
    /// Contains unit tests for the <see cref="Calculator"/> class, verifying the correctness of its operations.
    /// </summary>
    /// <remarks>This class uses the xUnit testing framework to validate the behavior of the <see
    /// cref="Calculator"/> class. Each test method ensures that specific operations produce the expected
    /// results.</remarks>
    public class CalculatorTests
    {
        /// <summary>
        /// Tests that the <see cref="Calculator.Add(int, int)"/> method returns the correct sum of two integers.
        /// </summary>
        /// <remarks>This test verifies that the <see cref="Calculator.Add(int, int)"/> method correctly
        /// adds two integers  and returns their sum. It uses the values 2 and 3 as inputs and expects the result to be
        /// 5.</remarks>
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }
    }
}