using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jump_force;
    public float speed;

    public bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position += Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position += -Vector3.right * speed;
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (jumping == false)
        {
            if (collision.gameObject.tag == "Ground")
            {
                if (Input.GetKeyDown(KeyCode.Space) == true)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump_force), ForceMode2D.Impulse);

                    jumping = true;

                }
            }
        }
        
    }
}
