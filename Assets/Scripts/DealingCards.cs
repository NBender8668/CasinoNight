using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealingCards : MonoBehaviour
{
    public Button cardOneBtn;
    public Button cardTwoBtn;
    public Button cardThreeBtn;
    public Button cardFourBtn;
    public Button cardFiveBtn;

    public List<Card> cards = new List<Card>();

    private DeckOfCards deck = new DeckOfCards();

    public void DealCards()
    {
        deck.shuffle();

        Card cardOne;
        Card cardTwo;
        Card cardThree;
        Card cardFour;
        Card cardFive;

    System.Random randomCard = new System.Random();
        System.Random randomCard2 = new System.Random();
        System.Random randomCard3 = new System.Random();
        System.Random randomCard4 = new System.Random();
        System.Random randomCard5 = new System.Random();

        int indexForCardOne = randomCard.Next(deck.cards.Count);
        cardOne = deck.cards[indexForCardOne];
        deck.cards.Remove(deck.cards[indexForCardOne]);

        int indexForCardTwo = randomCard2.Next(deck.cards.Count);
        cardTwo = deck.cards[indexForCardTwo];
        deck.cards.Remove(deck.cards[indexForCardTwo]);

        int indexForCardThree = randomCard3.Next(deck.cards.Count);
        cardThree = deck.cards[indexForCardThree];
        deck.cards.Remove(deck.cards[indexForCardThree]);

        int indexForCardFour = randomCard4.Next(deck.cards.Count);
        cardFour = deck.cards[indexForCardFour];
        deck.cards.Remove(deck.cards[indexForCardFour]);

        int indexForCardFive = randomCard5.Next(deck.cards.Count);
        cardFive = deck.cards[indexForCardFive];
        deck.cards.Remove(deck.cards[indexForCardFive]);

        cards.Add(cardOne);
        cards.Add(cardTwo);
        cards.Add(cardThree);
        cards.Add(cardFour);
        cards.Add(cardFive);

    }
}
