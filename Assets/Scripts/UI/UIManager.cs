using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private bool lateStart = true;

    private void Update()
    {
        if(lateStart == true)
        {
            Cursor.lockState = CursorLockMode.None;
            lateStart = false;
        }
    }

    public void ChangeScene(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
