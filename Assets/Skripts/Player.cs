using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float speed;
    
 
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Jump();
        Death();
    }

    void Move()
    {


        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxX)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x >= minX)
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }

        

    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
    }

    void Death()
    {
        if (transform.position.y <= -2)
        {
            SceneManager.LoadScene("Lose");
        }
    }

   
}
