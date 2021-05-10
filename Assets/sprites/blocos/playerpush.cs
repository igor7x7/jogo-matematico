using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpush : MonoBehaviour
{
    // Start is called before the first frame update
    public float distance=1f;
    public LayerMask boxMask;
    GameObject box;
    RaycastHit2D hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Physics2D.queriesStartInColliders = false;
            hit= Physics2D.Raycast(transform.position, Vector2.left*transform.localScale.x,distance,boxMask);
        if(Input.GetKey(KeyCode.D) ){
            hit= Physics2D.Raycast(transform.position, Vector2.right*transform.localScale.x,distance,boxMask);
        }
        if (hit.collider != null && hit.collider.gameObject.tag=="pushable" && Input.GetKey(KeyCode.E)){

            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled= true;
            box.GetComponent<FixedJoint2D>().connectedBody=this.GetComponent<Rigidbody2D> ();

        }else if(Input.GetKeyUp(KeyCode.E)){

            box.GetComponent<FixedJoint2D>().enabled=false; 
        }
    }
        
    
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine ((Vector2)transform.position - Vector2.right*transform.localScale.x * distance, (Vector2)transform.position + Vector2.right*transform.localScale.x * distance);
         


    }
    
}
