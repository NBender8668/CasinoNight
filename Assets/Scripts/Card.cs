using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
   public enum eSuit
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs
    }

    public eSuit suit { get; set; }

    public int number;

    public eSuit GetSuit() { return suit; }

    public int GetNumber() { return number; }

    public Card(int cardValue, eSuit cardSuit)
    {
        suit = cardSuit;
        number = cardValue;
    }
}
