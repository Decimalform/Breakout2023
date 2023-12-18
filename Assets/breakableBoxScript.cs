using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableBoxScript : MonoBehaviour
{
    float distanceDown;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (gameObj.tag == "breakableBox")
            {
                gameObj.GetComponent<Renderer>().material.color = new Color(100, 0, 100);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hitDown;
        if (Physics.Raycast(transform.position, Vector3.down, out hitDown))
        {
            print("hitDown " + hitDown.collider.gameObject);
        }
        distanceDown = hitDown.distance;
        if (distanceDown > 5)
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(0, 100, 100);
                }
            }
        }
    }

    
}
