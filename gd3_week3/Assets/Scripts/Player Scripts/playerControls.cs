using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float moveSpeed = 10;
    float horizontal;
    public float xRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(moveSpeed * Time.deltaTime * horizontal *Vector3.right );

        if(transform.position.x >= xRange) // make sure the player doesnt go beyond it
        {
            transform.position = new Vector3(xRange, 0, transform.position.z);
        }


        if(transform.position.x <= -xRange) // make sure the player doesnt go beyond it
        {
            transform.position = new Vector3(-xRange, 0, transform.position.z);
        }
    }
}
