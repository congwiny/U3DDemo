using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load() 
    {
        SceneManager.LoadScene("SampleTarget");
    }

    public void Back() {
        SceneManager.LoadScene(0);
    }
}
