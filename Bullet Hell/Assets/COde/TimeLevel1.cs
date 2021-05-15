using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLevel1 : MonoBehaviour
{
    public UnityEngine.UI.Text timer;
    public float time;


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = (int)time + "";
        if (time < 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
