using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DealingCards : MonoBehaviour
{
    private Sprite cardFace;
    private Sprite cardFace2;
    private Sprite cardFace3;
    private Sprite cardFace4;
    private Sprite cardFace5;

    public Sprite cardClubs2;
    public Sprite cardClubs3;
    public Sprite cardClubs4;
    public Sprite cardClubs5;
    public Sprite cardClubs6;
    public Sprite cardClubs7;
    public Sprite cardClubs8;
    public Sprite cardClubs9;
    public Sprite cardClubs10;
    public Sprite cardClubsA;
    public Sprite cardClubsJ;
    public Sprite cardClubsK;
    public Sprite cardClubsQ;

    public Sprite cardDiamonds2;
    public Sprite cardDiamonds3;
    public Sprite cardDiamonds4;
    public Sprite cardDiamonds5;
    public Sprite cardDiamonds6;
    public Sprite cardDiamonds7;
    public Sprite cardDiamonds8;
    public Sprite cardDiamonds9;
    public Sprite cardDiamonds10;
    public Sprite cardDiamondsA;
    public Sprite cardDiamondsJ;
    public Sprite cardDiamondsK;
    public Sprite cardDiamondsQ;

    public Sprite cardHearts2;
    public Sprite cardHearts3;
    public Sprite cardHearts4;
    public Sprite cardHearts5;
    public Sprite cardHearts6;
    public Sprite cardHearts7;
    public Sprite cardHearts8;
    public Sprite cardHearts9;
    public Sprite cardHearts10;
    public Sprite cardHeartsA;
    public Sprite cardHeartsJ;
    public Sprite cardHeartsK;
    public Sprite cardHeartsQ;

    public Sprite cardSpades2;
    public Sprite cardSpades3;
    public Sprite cardSpades4;
    public Sprite cardSpades5;
    public Sprite cardSpades6;
    public Sprite cardSpades7;
    public Sprite cardSpades8;
    public Sprite cardSpades9;
    public Sprite cardSpades10;
    public Sprite cardSpadesA;
    public Sprite cardSpadesJ;
    public Sprite cardSpadesK;
    public Sprite cardSpadesQ;

    public Button cardOneBtn;
    public Button cardTwoBtn;
    public Button cardThreeBtn;
    public Button cardFourBtn;
    public Button cardFiveBtn;

    DeckOfCards deck = new DeckOfCards();
    //PokerManager pokerManager;
    Card card;

    Card cardOne;
    Card cardTwo;
    Card cardThree;
    Card cardFour;
    Card cardFive;
    public List<Card> cards = new List<Card>();
    public void Start()
    {
        cardFace = cardOneBtn.GetComponent<Image>().sprite;
        cardFace2 = cardTwoBtn.GetComponent<Image>().sprite;
        cardFace3 = cardThreeBtn.GetComponent<Image>().sprite;
        cardFace4 = cardFourBtn.GetComponent<Image>().sprite;
        cardFace5 = cardFiveBtn.GetComponent<Image>().sprite;
    }


    public void DealCards()
    {        
        deck.shuffle();

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

    public void PutImageOnCard_OnClick()
    {
        if (cards[0] != new Card(1, Card.eSuit.Hearts))
        {
            cardFace = cardHeartsA;
        }

        if (cards[1] != new Card(1, Card.eSuit.Hearts))
        {
            cardFace2 = cardHeartsA;
        }

        if (cards[2] != new Card(1, Card.eSuit.Hearts))
        {
            cardFace3 = cardHeartsA;
        }

        if (cards[3] != new Card(1, Card.eSuit.Hearts))
        {
            cardFace4 = cardHeartsA;
        }

        if (cards[4] != new Card(1, Card.eSuit.Hearts))
        {
            cardFace5 = cardHeartsA;
        }
    }

    public void TestIfCardImageChange()
    {
        card = new Card(1, Card.eSuit.Hearts);
        cardOne = card;
        cards.Add(cardOne);

        card = new Card(1, Card.eSuit.Hearts);
        cardTwo = card;
        cards.Add(cardTwo);

        card = new Card(1, Card.eSuit.Hearts);
        cardThree = card;
        cards.Add(cardThree);

        card = new Card(1, Card.eSuit.Hearts);
        cardFour = card;
        cards.Add(cardFour);

        card = new Card(1, Card.eSuit.Hearts);
        cardFive = card;
        cards.Add(cardFive);

        PutImageOnCard();
    }
}
