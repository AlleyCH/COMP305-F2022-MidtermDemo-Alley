using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starthrower : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * 20;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
