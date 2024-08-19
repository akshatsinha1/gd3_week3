using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject dog, cow;
    public float spawnRangeX, spawnRangeZ;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimal", 1, 1);
    }

    void spawnAnimal()
    {
        
        Instantiate(dog, new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0,
                                           Random.Range(-spawnRangeZ, spawnRangeZ)), dog.transform.rotation);
    }

}
