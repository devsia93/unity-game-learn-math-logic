using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColorController : MonoBehaviour
{
    public ButtonController button;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (button.statusButton)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
