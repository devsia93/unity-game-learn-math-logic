using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMouseClickOnButton();
    }

    private void CheckMouseClickOnButton()
    {
        if (Input.GetMouseButton(0) == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray.direction.x);
        }

    }
}
