using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerManager : MonoBehaviour
{


    DeckOfCards deck = new DeckOfCards();
    // Start is called before the first frame update
    void Start()
    {
        

        DealingCards cards = new DealingCards();
        cards.DealCards();

        Debug.Log(cards.cards[0].ToString());
        Debug.Log(cards.cards[1].ToString());
        Debug.Log(cards.cards[2].ToString());
        Debug.Log(cards.cards[3].ToString());
        Debug.Log(cards.cards[4].ToString());
    }
}
