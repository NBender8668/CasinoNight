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
    void Start()
    {
        // Add on click listeners to the buttons
        dealButton.onClick.AddListener(() => DealClicked());
        hitButton.onClick.AddListener(() => HitClicked());
        standButton.onClick.AddListener(() => StandClicked());
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void DealClicked()
    {
        throw new NotImplementedException();
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
