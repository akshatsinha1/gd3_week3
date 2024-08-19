using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float moveSpeed = 10;
    float horizontal;
    public float xRange ;
    public GameObject[] food;
    public Transform projectileParent;

    public int animalsFed = 0;

    //public int applesEaten;



    //bool isHungry;

   
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(moveSpeed * Time.deltaTime * horizontal * Vector3.right );

        if(transform.position.x >= xRange) // make sure the player doesnt go beyond it
        {
            transform.position = new Vector3(xRange, 0, transform.position.z);
        }


        if(transform.position.x <= -xRange) // make sure the player doesnt go beyond it
        {
            transform.position = new Vector3(-xRange, 0, transform.position.z);
        }

        if (animalsFed >= 10) Debug.Log("You Win!");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnProjectile();
        }

        //if(applesEaten >=10)
        //{
        //    //hunger level reduces
        //}
    }

    void spawnProjectile()
    {
        int randomIndex = Random.Range(0, food.Length);

        Instantiate(food[randomIndex], transform.position + Vector3.up, food[randomIndex].transform.rotation, projectileParent);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.transform.tag == "Apple")
    //    {
    //        applesEaten += 1;
    //    }
    //}
}
