using UnityEngine;
using System.Collections;


public class Controls : MonoBehaviour {

    public Rigidbody2D rb;
    public float movespeed;
    public int movespeedIncreaseBy;
    public int threshold;
    private int points;
    private int count = 0;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            Destroy(other.gameObject);
            points += 1;
            count +=1;
            if (count == threshold)
            {
              movespeed += movespeedIncreaseBy;
              count = 0;
            }
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            points += 1;
            count +=1;

            if (count == threshold)
            {
              movespeed += movespeedIncreaseBy;
              count = 0;
            }
        }

      if (other.gameObject.CompareTag("Wall"))
      {
          points = 0;
          Application.LoadLevel("CubeGame");
      }
    }




    void OnGUI()
    {
        GUI.Label(new Rect(70, 1, 200, 30), "                      " + points);
    }

 }
