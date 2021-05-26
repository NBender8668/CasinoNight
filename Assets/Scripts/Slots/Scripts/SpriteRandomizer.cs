using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteRandomizer : MonoBehaviour
{
    public Sprite[] sprites;
    public float stoptime;
   

    void Update()
    {
        RandomSprite();
    }

    void RandomSprite()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

    void EndRand()
    {
        enabled = false;
    }

    public void StopRand()
    {
        Invoke("EndRand", stoptime);
    }

    public void StartRand()
    {
        enabled = true;
    }
    void SlotCheck()
    {
        if(sprites[0].name == "Banana")
        {
            
        }
    }
}
