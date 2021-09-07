using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25; //1인당 음식 가격은 고정
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
    
        //장식비 체크시 1인당 5달러 + 기본 50달러
        //미체크시 1인당 7달러 50센트 + 기본 30달러
        public decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;
            if (FancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15.00m) + 50m;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50m) + 30m;
            }
            return CostOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

        //총 비용 계산
        //(장식비 + 1인당 음식가격) * 사람수)
        //헬씨 옵션 선택시 전체에서 5% 할인
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ( (CalculateCostOfDecorations() + CostOfFoodPerPerson) * NumberOfPeople );
                if (HealthyOption)
                {
                    totalCost *= 0.95m;
                }
                return totalCost;
            }
        }
    }
}
