using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlotsBetController : MonoBehaviour
{
    public int currentBet;
    public int total = 999;
    public TMP_Text betAmount;
    public TMP_Text totalAmount;

    public Button betOneBtn;
    public Button betFiveBtn;
    public Button betTenBtn;
    public Button betTwentyBtn;
    public Button betFiftyBtn;
    public Button betOneHundredBtn;
    public Button betFiveHundredBtn;
    public Button betOneKBtn;
    public Button betFiveKBtn;


    private void Start()
    {
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void Update()
    {
        if(total < 1)
        {
            betOneBtn.enabled = false;
            betFiveBtn.enabled = false;
            betTenBtn.enabled = false;
            betTwentyBtn.enabled = false;
            betFiftyBtn.enabled = false;
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 5)
        {
            betFiveBtn.enabled = false;
            betTenBtn.enabled = false;
            betTwentyBtn.enabled = false;
            betFiftyBtn.enabled = false;
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 10)
        {
            betTenBtn.enabled = false;
            betTwentyBtn.enabled = false;
            betFiftyBtn.enabled = false;
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 20)
        {
            betTwentyBtn.enabled = false;
            betFiftyBtn.enabled = false;
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 50)
        {
            betFiftyBtn.enabled = false;
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 100)
        {
            betOneHundredBtn.enabled = false;
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 500)
        {
            betFiveHundredBtn.enabled = false;
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 1000)
        {
            betOneKBtn.enabled = false;
            betFiveKBtn.enabled = false;
        }
        else if(total < 5000)
        {
            betFiveKBtn.enabled = false;
        }
        
    }

    public void BetOneChip()
    {
        currentBet += 1;
        total -= 1;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetFiveChips()
    {
        currentBet += 5;
        total -= 5;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetTenChips()
    {
        currentBet += 10;
        total -= 10;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetTwentyChips()
    {
        currentBet += 20;
        total -= 20;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetFiftyChips()
    {
        currentBet += 50;
        total -= 50;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetOneHundredChips()
    {
        currentBet += 100;
        total -= 100;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetFiveHundredChips()
    {
        currentBet += 500;
        total -= 500;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetOneKChips()
    {
        currentBet += 1000;
        total -= 1000;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }

    public void BetFiveKChips()
    {
        currentBet += 5000;
        total -= 5000;
        betAmount.text = currentBet.ToString();
        totalAmount.text = total.ToString();
    }
}
