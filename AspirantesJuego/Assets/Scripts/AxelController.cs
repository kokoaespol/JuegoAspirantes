using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxelController : MonoBehaviour
{
    bool front;
    bool back;

    private void Start()
    {
        front = false;
        back = false;
    }
    void Update()
    {
        if (Input.GetKey("right"))
        {
            front = false;
            back = false;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(3000f * Time.deltaTime,0,0));
            gameObject.GetComponent<Animator>().SetBool("lateralMove", true);
        }    
        if (Input.GetKey("left"))
        {
            front = false;
            back = false;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(-3000f * Time.deltaTime, 0, 0));
            gameObject.GetComponent<Animator>().SetBool("lateralMove", true);
        }
        if (Input.GetKeyDown("up")) {
            back = true;
            front = false;
            gameObject.GetComponent<Animator>().SetBool("back", true);
        }
        if (Input.GetKeyDown("down")) {
            front = true;
            back = false;
            gameObject.GetComponent<Animator>().SetBool("front", true);
        }
        if (!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("lateralMove", false);
        }
        if (!front)
        {
            gameObject.GetComponent<Animator>().SetBool("front", false);
        }
        if (!back)
        {
            gameObject.GetComponent<Animator>().SetBool("back", false);
        }
    }
}
