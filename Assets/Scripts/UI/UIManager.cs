﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ChangeScene(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
