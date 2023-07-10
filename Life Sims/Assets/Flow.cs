using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : MonoBehaviour
{
    public GameObject startMainScreen;
    public GameObject startIntroScreen;


    // Start is called before the first frame update
    void Start()
    {
        startMainScreen.SetActive(true);
        startIntroScreen.SetActive(false);
    }

    // Update is called once per frame

    public void start_Start()
    {
        startMainScreen.SetActive(false);
        startIntroScreen.SetActive(true);
    }
}
