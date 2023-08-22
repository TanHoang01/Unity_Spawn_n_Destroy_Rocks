using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // make rock move in random direction
        Vector3 direction = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10));
        GetComponent<Rigidbody2D>().AddForce(direction, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
