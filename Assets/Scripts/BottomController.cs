using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomController : MonoBehaviour
{
    private int CurrentSceneIndex;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Helper.isSuccess)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneController.life--;
            if (SceneController.life < 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            SceneManager.LoadScene(CurrentSceneIndex + 1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
