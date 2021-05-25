using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // --- This script is for BOTH player and dealer

    //Get other scripts
    public CardScript cardScript;
    public BlackJackDeck blackJackDeck;

    //Total value of player/dealer's hand
    public int handValue = 0;

    // Betting money
    private int money = 1000;

    //Array of card objects on table
    public GameObject[] hand;
    //Index of next card to be turned over
    public int cardIndex = 0;
    //public int aceCount = 0;
    // Track aces for 1 to 11 conversions
    List<CardScript> aceList = new List<CardScript>();

    public void StartHand()
    {
        GetCard();
        GetCard();
    }

    // Add a hand to the player/dealer's hand
    public int GetCard()
    {

        // Get a card, use deal card to assign sprite and value to card on table
        int cardValue = blackJackDeck.DealCard(hand[cardIndex].GetComponent<CardScript>());
        //Show card on game screen
        hand[cardIndex].GetComponent<Renderer>().enabled = true;
        // Add card value to running total of the hand
        handValue += cardValue;
        if (cardValue == 1)
        {
            aceList.Add(hand[cardIndex].GetComponent<CardScript>());
        }
        //Check if we should use an 11 instead of a 1
        //AceCheck()
        cardIndex++;
        return handValue;
        
    }
}
