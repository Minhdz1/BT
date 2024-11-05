using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Body : MonoBehaviour
{
    private  Rigidbody2D m_Ridgidbody;
    public float Speed1 = 1.0f;
    private void Awake()
    {
       m_Ridgidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
      
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            MoveUp();
        }
    }
    private void MoveUp()
    {
        m_Ridgidbody.velocity = Vector2.up * Speed1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("wall"))

        {
            Destroy(gameObject);
        }
    }

   
}