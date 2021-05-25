using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DealingCards cards = new DealingCards();
        //cards.DealCards();

        cards.TestIfCardImageChange();
    }
}
