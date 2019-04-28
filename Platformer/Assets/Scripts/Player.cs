using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jump_force;
    private float original_jump;
    public float speed;


    public bool can_jump = false, jumping = false, just_jumped = false;

    // Start is called before the first frame update
    void Start()
    {
        original_jump = jump_force;
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Animator>().SetBool("running", false);
        

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position += Vector3.right * speed;
            GetComponent<Animator>().SetBool("running", true);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position += -Vector3.right * speed;
            GetComponent<Animator>().SetBool("running", true);
            GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetKeyDown(KeyCode.Space) == true && can_jump && !just_jumped)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump_force), ForceMode2D.Impulse);
            can_jump = false;
            just_jumped = true;
            jump_force = original_jump;

            GetComponent<Animator>().SetBool("jumping", true);


            StartCoroutine(jumped());


        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jumppad" && jump_force < original_jump * 2)
        {
            can_jump = true;
            
            jump_force *= 2;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Jumppad")
        {
            can_jump = true;
            //GetComponent<Animator>().SetBool("falling", false);
        }

        else
        {
            can_jump = false;
        }


        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(collision.gameObject);
            //Destroy(this.gameObject);

            SceneManager.LoadScene("End");

        }

    }

    IEnumerator jumped()
    {
        yield return new WaitForSeconds(0.9f);
        just_jumped = false;

        GetComponent<Animator>().SetBool("jumping", false);
        //GetComponent<Animator>().SetBool("falling", true);
    }
}
