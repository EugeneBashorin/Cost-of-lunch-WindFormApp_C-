using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfLunch
{
    class DinnerParty : Party
    {       
        public readonly int Alcohol;    
        public readonly int WaterJuice;  
        public readonly decimal Sale;   

        public bool HealthyOption { get; set; }
       

        public DinnerParty(int costPerPerson, decimal addDecorations, decimal withoutDecorations, int contrWithoutDecorations, int contrAddDecorations, int alcohol,
                           int waterJuice, decimal sale) : base (costPerPerson, addDecorations, withoutDecorations, contrWithoutDecorations, contrAddDecorations)
        {
            Alcohol = alcohol;
            WaterJuice = waterJuice;
            Sale = sale;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = (CostPerPerson + WaterJuice);
            }
            else
            {
                costOfBeveragesPerPerson = (CostPerPerson + Alcohol);
            }
            return costOfBeveragesPerPerson;
        }

       override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson()* NumberOfPeople;
                if (HealthyOption)
                {
                    totalCost = totalCost - totalCost * Sale;
                }
                return totalCost;
            }
        }
    }
}
