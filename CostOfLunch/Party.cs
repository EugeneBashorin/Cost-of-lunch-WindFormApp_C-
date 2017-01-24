using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfLunch
{
    public abstract class Party
    {
        public int NumberOfPeople { get; set; }
        public bool UnusualDecorate { get; set; }

        public readonly int CostPerPerson;
        public readonly decimal AddDecorations;
        public readonly decimal WithoutDecorations;
        public readonly int ContributionWithoutDecorations;
        public readonly int ContributionAddDecorations;

        protected Party(int costPerPerson, decimal addDecorations, decimal withoutDecorations, int contrWithoutDecorations, int contrAddDecorations)
        {
            CostPerPerson = costPerPerson;
            AddDecorations = addDecorations;
            WithoutDecorations = withoutDecorations;
            ContributionWithoutDecorations = contrWithoutDecorations;
            ContributionAddDecorations = contrAddDecorations;
        }

       virtual public decimal Cost {
            get
            {
              decimal totalCost =  CalculateCostOfDecorations();
                totalCost += CostPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
            }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecoration;
            if (UnusualDecorate)
            {
                costOfDecoration = AddDecorations * NumberOfPeople + ContributionAddDecorations;
            }
            else
            {
                costOfDecoration = WithoutDecorations * NumberOfPeople + ContributionWithoutDecorations;
            }
            return costOfDecoration;
        }
    }
}
