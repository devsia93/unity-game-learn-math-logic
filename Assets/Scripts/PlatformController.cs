using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public GameObject line;
    public float DefaultPositionX { get; private set; }
    public bool onCollision = false;
    private bool isMoved;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollision = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        DefaultPositionX = 4.77f;
        Helper.isSuccess = false;
    }
    public void MoveUpPlatform()
    {
        gameObject.transform.position += new Vector3(+3.0f, 0);
        isMoved = true;
    }
    public void MoveDownPlatform()
    {
        gameObject.transform.position += new Vector3(-3.0f, 0);
        isMoved = false;
    }

    private void OnEnable()
    {
        if (line.GetComponent<Renderer>().material.color == Color.green)
        {
            MoveUpPlatform();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (line.GetComponent<Renderer>().material.color == Color.green & !isMoved)
        {
            if (gameObject.transform.position.x > 7.0f)
            {
                MoveDownPlatform();
            }
            else
            {
                MoveUpPlatform();
            }
        }
        else if (line.GetComponent<Renderer>().material.color == Color.red & isMoved)
        {
            if (gameObject.transform.position.x > 7.0f)
            {
                MoveDownPlatform();
            }
            else
            {
                MoveUpPlatform();
            }
        }
    }
}
