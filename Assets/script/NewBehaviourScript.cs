using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
   public Animator anim;
   public float speed;
   public Rigidbody2D rb;
   



    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("speed", movement.magnitude);

        //transform.position = transform.position + movement * speed * Time.deltaTime; 

        rb.velocity = new Vector2(movement.x, movement.y) * speed;

    }
}
