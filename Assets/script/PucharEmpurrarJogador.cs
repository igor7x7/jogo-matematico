using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PucharEmpurrarJogador : MonoBehaviour
{
    public float distance = 1f;
    public LayerMask boxMask;
    public float raio_circulo ;

    GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Physics2D.queriesStartInColliders = false;
       RaycastHit2D hit= Physics2D.CircleCast(transform.position, raio_circulo, transform.position, raio_circulo, boxMask);

        if (hit.collider != null && hit.collider.gameObject.tag=="pushable" && Input.GetKey(KeyCode.E)) 
        {
            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D> ().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        } else if (Input.GetKeyUp (KeyCode.E))
            {
            box.GetComponent<FixedJoint2D>().enabled = false;
            }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, raio_circulo);
    }
}
