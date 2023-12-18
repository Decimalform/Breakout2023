using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakableBoxScript : MonoBehaviour
{
    float distanceDown;
    float distanceUp;

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hitUp;
        if (Physics.Raycast(transform.position, Vector3.up, out hitUp))
        {
            print("hitDown " + hitUp.collider.gameObject);
        }
        distanceUp = hitUp.distance;

        RaycastHit hitDown;
        if (Physics.Raycast(transform.position, Vector3.down, out hitDown))
        {
            print("hitDown " + hitDown.collider.gameObject);
        }
        distanceDown = hitDown.distance;


        if (hitUp.collider.name != "top wall" && hitDown.collider.name == "bottom wall" || hitDown.collider.name == "Stearing platform")
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
                    //red
                }
            }
        }

        
        if (hitDown.collider.name == "bottom wall" || hitDown.collider.name != "Stearing platform" && hitUp.collider.name != "top wall")
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
                    //green
                }
            }
        }


        if (hitUp.collider.name != "top wall" && hitDown.collider.name != "bottom wall" || hitDown.collider.name != "Stearing platform")
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
                }
                //blue
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {/*
        RaycastHit hitDown;
        if (Physics.Raycast(transform.position, Vector3.down, out hitDown))
        {
            print("hitDown " + hitDown.collider.gameObject);
        }
        distanceDown = hitDown.distance;
        if (distanceDown > 5 && hitDown.collider.name == "bottom wall" || hitDown.collider.name == "Stearing platform")
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
                    //red
                }
            }
        }

        RaycastHit hitUp;
        if (Physics.Raycast(transform.position, Vector3.up, out hitUp))
        {
            print("hitDown " + hitUp.collider.gameObject);
        }
        distanceUp = hitUp.distance;
        if (distanceUp > 1 && hitUp.collider.name == "top wall")
        {
            foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
            {
                if (gameObj.tag == "breakableBox")
                {
                    gameObj.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1);
                    //green
                }
            }
        }*/
    }

    
}
