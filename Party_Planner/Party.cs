using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25; //손님 1인당 25달러는 고정
        public int NumberOfPeople { get; set; } //파티 참여자 수
        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00m) + 50m;
            else
                costOfDecorations = (NumberOfPeople * 7.5m) + 30m;
            return costOfDecorations;
        }

        virtual public  decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;
            }
        }
    }
}
