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

    private DeckOfCards deck;

    private Card cardOne;
    private Card cardTwo;
    private Card cardThree;
    private Card cardFour;
    private Card cardFive;


    public void DealCards()
    {
        deck.shuffle();
        int numOfRandom = 0;

        System.Random randomCard = new System.Random();
        System.Random randomCard2 = new System.Random();
        System.Random randomCard3 = new System.Random();
        System.Random randomCard4 = new System.Random();
        System.Random randomCard5 = new System.Random();

        int indexForCardOne = randomCard.Next(deck.cards.Count);
        deck.cards.Remove(deck.cards[indexForCardOne]);

        int indexForCardTwo = randomCard.Next(deck.cards.Count);
        deck.cards.Remove(deck.cards[indexForCardTwo]);

        int indexForCardThree = randomCard.Next(deck.cards.Count);
        deck.cards.Remove(deck.cards[indexForCardThree]);

        int indexForCardFour = randomCard.Next(deck.cards.Count);
        deck.cards.Remove(deck.cards[indexForCardFour]);

        int indexForCardFive = randomCard.Next(deck.cards.Count);
        deck.cards.Remove(deck.cards[indexForCardFive]);

        cardOne = deck.cards[indexForCardOne];
        cardTwo = deck.cards[indexForCardTwo];
        cardThree = deck.cards[indexForCardThree];
        cardFour = deck.cards[indexForCardFour];
        cardFive = deck.cards[indexForCardFive];
    }
}
