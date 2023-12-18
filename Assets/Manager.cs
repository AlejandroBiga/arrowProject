#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    private void Start()
    {
        SwitchCam1();
    }

    public void SwitchCam1()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
    public void SwitchCam2()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
    }
    public void SwitchCam3()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
    }
    public void SwitchCam4()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("Arco1");
    }
}
#endif
