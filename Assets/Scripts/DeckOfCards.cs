using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DeckOfCards
{
    System.Random random = new System.Random();
    public List<Card> cards = new List<Card>();

    public DeckOfCards()
    {
        foreach (Card.eSuit suit in Enum.GetValues(typeof(Card.eSuit)))
        {
            for (int i = 1; i < 14; i++)
            {
                cards.Add(new Card(i, suit));
            }
        }
    }

    public void shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            var temp = cards[i];
            var index = random.Next(0, i + 1);
            cards[i] = cards[index];
            cards[index] = temp;
        }
    }

}

