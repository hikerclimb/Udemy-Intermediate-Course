using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __DinnerParty
{
    public class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;

        private int numberOfPeople;


        //Main Property with Accessor and Mututor
        public int NumberOfPeople
        {
            get { return numberOfPeople; }

            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        private bool fancyDecorations;

        //Not sure why we used decimal here?

        //The Decimal, Double, and Float variable types are different in the way that they store the values.
        //Precision is the main difference where float is a single precision(32 bit) floating point data type, 
        //double is a double precision(64 bit) floating point data type and decimal is a 128-bit floating point data type.

        //Float - 32 bit(7 digits)
        //Double - 64 bit(15-16 digits)
        //Decimal - 128 bit(28-29 significant digits)

        //Difference between Decimal, Float and Double
        
        //The main difference is Floats and Doubles are binary floating point types and a Decimal will 
        //store the value as a floating decimal point type.So Decimals have much higher precision and 
        //are usually used within monetary(financial) applications that require a high degree of accuracy.
        //But in performance wise Decimals are slower than double and float types.
        //Decimal can 100% accurately represent any number within the precision of the decimal format, 
        //whereas Float and Double, cannot accurately represent all numbers, even numbers that are within their respective formats precision.

        //When To Use Decimal, Double, and Float
        //Decimal
        //In case of financial applications it is better to use Decimal types because it gives you a high level of accuracy and easy to avoid rounding errors
        
        //Double
        //Double Types are probably the most normally used data type for real values, except handling money.
        
        //Float
        //It is used mostly in graphic libraries because very high demands for processing powers, also used situations that can endure rounding errors.

        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        

        //Main Constructor
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        //Main Methods

        public void SetHealthyOption(bool healthyOption)
        {
            //Healthy option ... No Booze...just water 
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M; //the M implies a decimal number
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M; 
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;

            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            //Getting a discount for healthy option ... 
            //on top of the fact that CostOfBeveragesPerPerson is less ie 5 vs 20

            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
