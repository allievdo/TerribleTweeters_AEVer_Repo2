using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
}
