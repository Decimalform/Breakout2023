using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour
{
    float distanceLeft;
    float distanceRight;
    public float Xposition;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Xposition = transform.position.x;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RaycastHit hitLeft;
            if (Physics.Raycast(transform.position, Vector3.left, out hitLeft))
            {
                print("hitLeft " + hitLeft.collider.gameObject);
            }
            distanceLeft = hitLeft.distance;
            if (distanceLeft > 0.01)
            {
                rb.velocity = Vector3.left * 10;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RaycastHit hitRight;
            if (Physics.Raycast(transform.position, Vector3.left, out hitRight))
            {
                print("hitLeft " + hitRight.collider.gameObject);
            }
            distanceLeft = hitRight.distance;
            if (distanceLeft > 0.01)
            {
                rb.velocity = Vector3.right * 10;
            }
        }
    }

    

   
}
