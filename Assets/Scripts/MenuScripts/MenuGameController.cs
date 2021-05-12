using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGameController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject optionScreen;
    public GameObject pauseScreen;


    bool isPaused = false;
    float timeScale;

    static MenuGameController instance = null;
    public static MenuGameController Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        //audioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume",0));
        //audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume",0));
        //audioMixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume",0));

        //audioMixer.GetFloat("MasterVlume", out float volume);
        //masterSlider.value = volume;
    }
    
  
    public void OnLoadGameScene(string sceneName)
    {
        titleScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //StartCoroutine(LoadGameScene(sceneName));
        SceneManager.LoadScene(sceneName);
    }

    IEnumerable LoadGameScene(string sceneName)
    {
       
        titleScreen.SetActive(false);
        SceneManager.LoadScene(sceneName);

        yield return null;
    }
    public void OnLoadMenuScene(string sceneName)
    {
        titleScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //StartCoroutine((LoadMenuScene(sceneName));
        SceneManager.LoadScene(sceneName);
    }

    IEnumerable LoadMenuScene(string sceneName)
    {

        titleScreen.SetActive(true);
        SceneManager.LoadScene(sceneName);

        yield return null;
    }
    public void OnTitleScreen()
    {
        titleScreen.SetActive(true);
        optionScreen.SetActive(false);
    }

    public void OnOptionScreen()
    {
        titleScreen.SetActive(false);
        optionScreen.SetActive(true);
    }

    public void OnPauseScreen()
    {
        if(isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = timeScale;
            Debug.Log("Pause");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            timeScale = Time.timeScale;
            Time.timeScale = 0;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void OnPause()
    {
        OnPauseScreen();
    }

    public void OnMasterVolume(float level)
    {
        //audioMixer.SetFloat("MasterVolume", level);
        //PlayerPrefs.SetFloat("MasterVolume", level);
    } 
    
    public void OnMusicVolume(float level)
    {
    //    audioMixer.SetFloat("MusicVolume", level);
    //    PlayerPrefs.SetFloat("MusicVolume", level);
    }
    public void OnSFXVolume(float level)
    {
    //    audioMixer.SetFloat("SFXVolume", level);
    //    PlayerPrefs.SetFloat("SFXVolume", level);
    }
}
