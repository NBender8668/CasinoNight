using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteScript : MonoBehaviour
{
    public int speed = 600;
    public bool isSpin = true;
    
     void Update()
    {
        Rotate();
    }

     void Start()
    {
        speed = 0;
    }

    public void Rotate()
    {
        if(isSpin == true)
        {
            speed = 600;
        }
        
        transform.Rotate(0, 0, speed * Time.deltaTime);

        if(isSpin == false && speed > 0)
        {
            Stop();
        }
    }

    public void Stop()
    {
        speed--;

        if(speed < 0)
        {
            speed = 0;
        }
    }

    public void SpinON()
    {
        isSpin = true;
    }

    public void SpinOff()
    {
        isSpin = false;
    }
}
