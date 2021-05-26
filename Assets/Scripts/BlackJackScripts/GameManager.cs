using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button dealButton;
    public Button hitButton;
    public Button standButton;
    public Button betButton;

    // Access the player and dealers
    public PlayerScript playerScript;
    public PlayerScript dealerScript;

    void Start()
    {
        // Add on click listeners to the buttons
        dealButton.onClick.AddListener(() => DealClicked());
        hitButton.onClick.AddListener(() => HitClicked());
        standButton.onClick.AddListener(() => StandClicked());
    }

    public void DealClicked()
    {
        GameObject.Find("Deck").GetComponent<BlackJackDeck>().Shuffle();
        playerScript.StartHand();
        dealerScript.StartHand();
    }
    private void HitClicked()
    {
        throw new NotImplementedException();
    }
    private void StandClicked()
    {
        throw new NotImplementedException();
    }

}
