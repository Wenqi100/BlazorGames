﻿using BlazorGames.Models.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Models.Solitaire
{
    public class SuitPile : PileBase
    {
        public CardSuit Suit { get; set; }

        public CardSuit AllowedSuit
        {
            get
            {
                return Suit;
            }
        }

        public CardValue AllowedValue
        {
            get
            {
                var topCard = Last();
                if (topCard == null) return CardValue.Ace;
                if (topCard.Value == CardValue.King) return CardValue.Ace;

                int currentValue = (int)topCard.Value;
                return (CardValue)(currentValue + 1);
            }
        }

        public SuitPile(CardSuit suit)
        {
            Suit = suit;
        }
    }
}