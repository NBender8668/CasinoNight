using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotGameController : MonoBehaviour
{
    public List<SpriteRandomizer> slots;
    public Text prizetxt;
    public Text BetAmounttxt;
    public Text Moneytxt;

    int cashout = 0;

    // Update is called once per frame
    void Update()
    {
        SlotCheck();
    }


    void SlotCheck()
    {
       if(slots[0].sprites[0].name == "Banana"&& slots[1].sprites[0].name == "Banana")
        {

        }
    }
}
