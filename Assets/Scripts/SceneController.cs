using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Text LifeText;
    public Text SceneNumber;
    [HideInInspector]
    public static int life;
    // Start is called before the first frame update
    void Start()
    {
        LifeText.text = "x " + life.ToString();
        SceneNumber.text = "Уровень " + SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
