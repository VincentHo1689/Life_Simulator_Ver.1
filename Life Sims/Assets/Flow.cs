using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{
    public GameObject startMainScreen;
    public GameObject startIntroScreen;
    public GameObject goToScreen;
    public GameObject pauseScreen;
    public GameObject startCombined;


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
        startCombined.SetActive(true);
    }

    public void start_Continue()
    {
        startIntroScreen.SetActive(false);
        goToScreen.SetActive(true);
        startCombined.SetActive(false);
    }

    void update(){
        if (Input.GetKeyDown(KeyCode.Escape) && startCombined.activeSelf == false)
        {
            Debug.Log("yes");
            Debug.Log(startMainScreen.activeSelf.ToString());
            pauseScreen.SetActive(!pauseScreen.activeInHierarchy);
        }
    }
}
