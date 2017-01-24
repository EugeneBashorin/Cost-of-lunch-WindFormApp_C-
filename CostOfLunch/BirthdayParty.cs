namespace CostOfLunch
{
    class BirthdayParty : Party
    {
        public readonly int MinPeople;
    
        public readonly int MinCakeSize;
        public readonly int MaxCakeSize;
        public readonly int CostMinCake;
        public readonly int CostMaxCake;
        public readonly int MinLetterCake;
        public readonly int MaxLetterCake;
        public readonly decimal LetterCakeCost;

        public string CakeWriting { get; set; }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
        }

        public BirthdayParty(int costPerPerson = 25, decimal addDecorations = 15M, decimal withoutDecorations = 7.5M, int contrWithoutDecorations = 30,
                             int contrAddDecorations= 50, int minPeople = 4, int minCakeSize = 8, int maxCakeSize = 16,
                             int costMinCake = 40, int costMaxCake = 75, int minLetterCake = 16, int maxLetterCake = 40,
                             decimal letterCakeCost = 0.25M) : base(costPerPerson, addDecorations, withoutDecorations, contrWithoutDecorations, contrAddDecorations)
        {
            MinPeople = minPeople;
            MinCakeSize = minCakeSize;
            MaxCakeSize = maxCakeSize;
            CostMinCake = costMinCake;
            CostMaxCake = costMaxCake;
            MinLetterCake = minLetterCake;
            MaxLetterCake = maxLetterCake;
            LetterCakeCost = letterCakeCost;
        }       

        private int CakeSize()
        {
            if (NumberOfPeople <= MinPeople)
            {
                return MinCakeSize;
            }
            else
            {
                return MaxCakeSize;
            }
        }

        private int MaxWritingLength()
        {
            if(CakeSize() == MinCakeSize)
            {
                return MinLetterCake;
            }
            else
            {
                return MaxLetterCake;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if(CakeWriting.Length > MaxWritingLength())
                { return true; }
                else { return false; }
            }
        }

        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == MinCakeSize)
                {
                    cakeCost = ActualLength * LetterCakeCost + CostMinCake;
                }
                else
                {
                    cakeCost = ActualLength * LetterCakeCost + CostMaxCake;
                }
                return totalCost + cakeCost;
            }
        }
    }
}
