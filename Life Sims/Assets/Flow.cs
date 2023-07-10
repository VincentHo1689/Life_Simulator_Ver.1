using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{
    public GameObject startMainScreen;
    public GameObject startIntroScreen;
    public GameObject goToScreen;
    public GameObject pauseScreen;
    public GameObject Home;


    // Start is called before the first frame update
    void Start()
    {
        startMainScreen.SetActive(true);
        startIntroScreen.SetActive(false);
        goToScreen.SetActive(false);
    }

    // Update is called once per frame

    public void start_Start()
    {
        startMainScreen.SetActive(false);
        startIntroScreen.SetActive(true);
    }

    public void start_Continue()
    {
        startIntroScreen.SetActive(false);
        goToScreen.SetActive(true);
    }

    public void LeaveHome()
    {
        Home.SetActive(false);
    }

    public void GoHome()
    {
        Home.SetActive(true);
    }

    void Update(){

        if (!(startMainScreen.activeSelf) && !(startIntroScreen.activeSelf) && Input.GetKeyDown(KeyCode.Escape))
            if (pauseScreen.activeSelf)
                pauseScreen.SetActive(false);
            else
                pauseScreen.SetActive(true);
    }
}
