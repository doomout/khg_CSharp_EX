﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25; //손님 1인당 25달러는 고정
        public int NumberOfPeople { get; set; } //파티 참여자 수
        public bool FancyDecorations { get; set; } 
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        //케익에 쓰여질 문구 길이 
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
        //케이크 사이즈(8인치 16인치 2종류) - 8인치면 최대 16글자, 16인치에는 40글자
        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        //파티 참석자가 4명 이하면 8인치, 5명 이상은 16인치
        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }
        //케이크에 들어갈 글자수 체크하고 경고 표시
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00m) + 50m;
            else
                costOfDecorations = (NumberOfPeople * 7.5m) + 30m;
            return costOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40m + ActualLength * 0.25m;
                else
                    cakeCost = 75m + ActualLength * 0.25m;
                return totalCost + cakeCost;
            }
        }
    }
}
