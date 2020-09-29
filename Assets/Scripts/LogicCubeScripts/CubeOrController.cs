using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOrController : MonoBehaviour
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
        input1 = lineInput1.GetComponent<Renderer>().material.color == Color.green ? true : false;
        input2 = lineInput2.GetComponent<Renderer>().material.color == Color.green ? true : false;
        lineOutput.GetComponent<Renderer>().material.color =
            LogicController.Disjunction(input1, input2) ? Color.green : Color.red;
    }
}
