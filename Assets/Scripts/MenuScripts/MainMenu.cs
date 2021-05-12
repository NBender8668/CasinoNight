using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        MenuGameController.Instance.OnTitleScreen();
        //GameController.Instance.transition.StartTransition(Color.clear, 1);
    }

}
