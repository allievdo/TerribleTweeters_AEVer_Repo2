using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void Yes()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
