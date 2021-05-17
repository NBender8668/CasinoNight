using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DealingCards cards = new DealingCards();
        cards.DealCards();

        Debug.Log(cards.cards[0]);
        Debug.Log(cards.cards[1]);
        Debug.Log(cards.cards[2]);
        Debug.Log(cards.cards[3]);
        Debug.Log(cards.cards[4]);
    }


}
