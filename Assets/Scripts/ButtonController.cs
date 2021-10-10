using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void newScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
