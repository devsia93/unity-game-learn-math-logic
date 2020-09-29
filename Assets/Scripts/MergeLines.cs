using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeLines : MonoBehaviour
{
    public GameObject MainLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Renderer>().material.color = MainLine.GetComponent<Renderer>().material.color;
    }
}
