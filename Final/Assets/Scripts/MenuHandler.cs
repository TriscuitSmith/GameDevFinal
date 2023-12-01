using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    public void Play()
    {

        SceneManager.LoadScene("SampleScene");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
