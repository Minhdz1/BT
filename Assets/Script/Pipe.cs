using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 3f;
   
    void Start()
    {

    }

    
    void Update()
    {
        if (Time.time > 2)
        {
            speed = 10f;
        }
        else if (Time.time > 4)
        {
            speed = 4f;
        }
        else if (Time.time > 6)
        {
            speed = 4.1f;
        }
        else if (Time.time > 8)
        {
            speed = 4.5f;
        }
        else if (Time.time > 10)
        {
            speed = 5.0f;
        }
        Move();
    }
    public void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    
}
