using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carrot : MonoBehaviour
{
    public GameObject carrot;
    public GameObject bottom;
    public GameObject player;
    private bool isTrigerred = false;

    //Устанавливает позицию моркови
    void Start()
    {
        float x = player.transform.position.x;
        float y = bottom.transform.position.y + 2.0f;
        carrot.transform.position = new Vector3(x, y, -0.2f);
    }

    // Управляет ее исчезновением при прохождении уровня
    void Update()
    {
            if (player.transform.position.y <= carrot.transform.position.y && isTrigerred.Equals(false))
            {
                GetComponent<Animation>().Play("AnimationCarrot");
                isTrigerred = true;
            }
    }
}
