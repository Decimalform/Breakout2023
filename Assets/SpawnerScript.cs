using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    GameObject breakableBox;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(breakableBox, transform.position = new Vector3(0, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 10, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 10, 0), Quaternion.identity);

        Instantiate(breakableBox, transform.position = new Vector3(0, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 11.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 11.5f, 0), Quaternion.identity);

        Instantiate(breakableBox, transform.position = new Vector3(0, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 13, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 13, 0), Quaternion.identity);

        Instantiate(breakableBox, transform.position = new Vector3(0, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 14.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 14.5f, 0), Quaternion.identity);

        Instantiate(breakableBox, transform.position = new Vector3(0, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 16, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 16, 0), Quaternion.identity);

        Instantiate(breakableBox, transform.position = new Vector3(0, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-3.5f, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(3.5f, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-7, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(7, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(-10.5f, 17.5f, 0), Quaternion.identity);
        Instantiate(breakableBox, transform.position = new Vector3(10.5f, 17.5f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
