using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAndController : MonoBehaviour
{
    public GameObject lineInput1;
    public GameObject lineInput2;
    public GameObject lineOutput;
    bool input1;
    bool input2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lineInput1.GetComponent<Renderer>().material.color == Color.green)
        {
            input1 = true;
        }
        else
        {
            input1 = false;
        }

        if (lineInput2.GetComponent<Renderer>().material.color == Color.green)
        {
            input2 = true;
        }
        else
        {
            input2 = false;
        }

        if (LogicController.Conjunction(input1, input2))
        {
            lineOutput.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            lineOutput.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
