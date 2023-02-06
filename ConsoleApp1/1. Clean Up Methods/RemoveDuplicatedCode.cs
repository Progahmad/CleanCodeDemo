using System;

namespace CleanUpMethods
{
    public class RemoveDuplicatedCode
    {
        private decimal _belowTaxSalaryAmount;
        private decimal _taxPercentage;

        public RemoveDuplicatedCode(decimal belowTaxSalaryAmount, decimal taxPercentage)
        {
            _belowTaxSalaryAmount = belowTaxSalaryAmount;
            _taxPercentage = taxPercentage;
        }

        public decimal CheckAndCalculate(decimal higherSalaryAmount, decimal grossSalaryAmount)
        {
            if (grossSalaryAmount < 0)
            {
                throw new ArgumentException("Provided salary amount is not correct.");
            }
            if (higherSalaryAmount < 0)
            {
                throw new ArgumentException("Provided salary amount is not correct.");
            }

            return CalculateNetAmount(grossSalaryAmount, higherSalaryAmount);
        }

        private decimal CalculateNetAmount(decimal grossSalaryAmount, decimal higherSalaryAmount)
        {
            if (_belowTaxSalaryAmount == 0 || _taxPercentage == 0)
            {
                return grossSalaryAmount;
            }

            decimal taxSum = 0m;

            if (grossSalaryAmount <= _belowTaxSalaryAmount)
            {
                return grossSalaryAmount;
            }
            decimal tax = (grossSalaryAmount - _belowTaxSalaryAmount) * (_taxPercentage / 100);
            taxSum += tax;

            decimal taxableSalary = grossSalaryAmount;

            if (taxableSalary > higherSalaryAmount)
            {
                taxableSalary = higherSalaryAmount;
            }
            tax = (taxableSalary - _belowTaxSalaryAmount) * (_taxPercentage / 100);
            taxSum += tax;

            return grossSalaryAmount - taxSum;
        }
    }
}
