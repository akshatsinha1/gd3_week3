using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalController : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0,Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
