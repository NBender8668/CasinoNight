using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerManager : MonoBehaviour
{
    System.Random random = new System.Random();

    public DeckOfCards deck;
    // Start is called before the first frame update
    void Start()
    {
        deck = GetComponent<DeckOfCards>();

        DealingCards cards = new DealingCards();
        cards.DealCards();

        Debug.Log(cards.cards[0]);
        Debug.Log(cards.cards[1]);
        Debug.Log(cards.cards[2]);
        Debug.Log(cards.cards[3]);
        Debug.Log(cards.cards[4]);
    }

    public void shuffle()
    {
        
        for (int i = deck.cards.Count; i > 0; i--)
        {
            var temp = deck.cards[i];
            var index = random.Next(0, i + 1);
            deck.cards[i] = deck.cards[index];
            deck.cards[index] = temp;
        }
    }


}
