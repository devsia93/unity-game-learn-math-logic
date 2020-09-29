using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool statusButton { get; set; }
    public GameObject line;
    void OnMouseDown()
    {
        if (this.gameObject.transform.localScale.x >= 1.2f)
        {
            GetComponent<Animation>().Play("AnimationButtonOff");
            statusButton = false;
            line.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Animation>().Play("AnimationButtonOn");
            statusButton = true;
            line.GetComponent<Renderer>().material.color = Color.green;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        line.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
