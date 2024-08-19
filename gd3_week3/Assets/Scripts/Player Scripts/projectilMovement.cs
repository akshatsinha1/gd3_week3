using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilMovement : MonoBehaviour
{
    public float projectileSpeed;
    playerControls _pc;

    // Start is called before the first frame update
    void Start()
    {
        //Finds the PlayerControls script attached to the player
        _pc = GameObject.FindGameObjectWithTag("Player").GetComponent<playerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);

        if(transform.position.z >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Animal")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);


            //increases the animals fed integer by one. this is attached to the player controls script in the player.
            _pc.animalsFed++;

        }
    }

  

}
