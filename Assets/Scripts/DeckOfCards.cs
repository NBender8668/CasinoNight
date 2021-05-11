using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOfCards : MonoBehaviour
{
    private List<Card> cards = new List<Card>();

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

    }
}

