using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuperButton : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnClickExit()
    {
        Application.Quit();
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
        SceneController.life = 3;
    }
    public void OnClickTable()
    {
        SceneManager.LoadScene(10);
    }

    public void OnClickToMainPage()
    {
        SceneManager.LoadScene(0);
    }
}
