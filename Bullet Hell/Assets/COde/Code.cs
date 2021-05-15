using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Code : MonoBehaviour
{
public void basla()
    {
        SceneManager.LoadScene("Level1");
    }
    public void cıkıs()
    {
        Application.Quit();
    }
    public void Samene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
