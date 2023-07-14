using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Flow : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject introScreen;
    public GameObject gotoScreen;
    public GameObject pauseScreen;
    public GameObject settingScreen;
    public GameObject statScreen;
    public GameObject homeScreen;
    public GameObject storeScreen;
    public GameObject workScreen;
    public GameObject parkScreen;
    public GameObject gymScreen;
    public GameObject dinerScreen;
    public GameObject clinicScreen;
    public GameObject schoolScreen;
    public GameObject bankScreen;
    void Start()
    {
        mainScreen.SetActive(true);
        introScreen.SetActive(false);
        gotoScreen.SetActive(false);
        pauseScreen.SetActive(false);
        settingScreen.SetActive(false);
        statScreen.SetActive(false);
        homeScreen.SetActive(false);
        storeScreen.SetActive(false);
        workScreen.SetActive(false);
        parkScreen.SetActive(false);
        gymScreen.SetActive(false);
        dinerScreen.SetActive(false);
        clinicScreen.SetActive(false);
        schoolScreen.SetActive(false);
        bankScreen.SetActive(false);
    }
    public void Start_disappear()
    {
        mainScreen.SetActive(false);
        introScreen.SetActive(true);
    }
    public void Cont_disappear()
    {
        introScreen.SetActive(false);
        homeScreen.SetActive(true);
        gotoScreen.SetActive(true);
    }
    public void LeavePlace()
    {
        homeScreen.SetActive(false);
        storeScreen.SetActive(false);
        workScreen.SetActive(false);
        parkScreen.SetActive(false);
        gymScreen.SetActive(false);
        dinerScreen.SetActive(false);
        clinicScreen.SetActive(false);
        schoolScreen.SetActive(false);
        bankScreen.SetActive(false);
    }
    public void GoHome()
    {
        homeScreen.SetActive(true);
    }
    public void GoStore()
    {
        storeScreen.SetActive(true);
    }
    public void GoWork()
    {
        workScreen.SetActive(true);
    }
    public void GoPark()
    {
        parkScreen.SetActive(true);
    }
    public void GoGym()
    {
        gymScreen.SetActive(true);
    }
    public void GoDiner()
    {
        dinerScreen.SetActive(true);
    }
    public void GoClinic()
    {
        clinicScreen.SetActive(true);
    }
    public void GoSchool()
    {
        schoolScreen.SetActive(true);
    }
    public void GoBank()
    {
        bankScreen.SetActive(true);
    }
    public void LeaveUI()
    {
        statScreen.SetActive(false);
        settingScreen.SetActive(false);
    }
    public void GoSetting()
    {
        settingScreen.SetActive(true);
    }
    public void GoStat()
    {
        statScreen.SetActive(true);
    }
    public void LeavePause()
    {
        pauseScreen.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LeaveApp()
    {
        Application.Quit();
    }
    public void BackMain()
    {
        mainScreen.SetActive(true);
        introScreen.SetActive(false);
        gotoScreen.SetActive(true);
        pauseScreen.SetActive(false);
        settingScreen.SetActive(false);
        statScreen.SetActive(false);
        homeScreen.SetActive(false);
        storeScreen.SetActive(false);
        workScreen.SetActive(false);
        parkScreen.SetActive(false);
        gymScreen.SetActive(false);
        dinerScreen.SetActive(false);
        clinicScreen.SetActive(false);
        schoolScreen.SetActive(false);
        bankScreen.SetActive(false);
    }

    void Update(){
        if (!(mainScreen.activeSelf) && !(introScreen.activeSelf) && Input.GetKeyDown(KeyCode.Escape))
            if (pauseScreen.activeSelf)
                pauseScreen.SetActive(false);
            else
                pauseScreen.SetActive(true);
    }
}