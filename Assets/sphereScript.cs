using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    float distanceLeft;
    float distanceRight;
    float distanceUp;
    float distanceDown;
    public float speed;
    bool canBecomeTrigger;
    Rigidbody myRigidbody;
    int leftrigth;
    public int lives = 3;
    public int points = 0;
    public int powerUpCountDown = 6;
    public bool canStartCountDown = true;
    //public bool runCountdown = false;

    public bool canAffectCountDown;

    GameObject platform;
    [SerializeField]
    GameObject breakableBox;

    [SerializeField]
    GameObject stearingplatform;

    [SerializeField]
    GameObject LivesText;

    [SerializeField]
    GameObject PointsText;

    [SerializeField]
    GameObject powerUpCountDownText;

    public platformScript PlatformScript;

    //public GameObject sphere;
    public float scale = 2.0f;
    public float scaleBack = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(-1000, -1000, 0));
        speed = 10;
        platform = GameObject.FindGameObjectWithTag("stearingPlatform");
        canBecomeTrigger = false;

        canAffectCountDown = true;

        /*foreach (GameObject v in GameObject.FindGameObjectsWithTag("breakableBox"))
        {
            Destroy(v);
        }*/
    }

    void FixedUpdate()
    {
        if (stearingplatform == null && GameObject.FindObjectOfType<platformScript>())
        {
            stearingplatform = GameObject.FindObjectOfType<platformScript>().gameObject;
            PlatformScript = stearingplatform.GetComponent<platformScript>();

        }
    }
    // Update is called once per frame
    void Update()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.left, out hit))
        {
            print("Shpere hit " + hit.collider.gameObject);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(Vector3.up * 1000);
        }
        
        if (myRigidbody.velocity != Vector3.zero)
        {
            myRigidbody.velocity = myRigidbody.velocity.normalized * speed;
        }

        if (myRigidbody.transform.position.y < -7)
        {
            lives -= 1;

            TextMeshProUGUI tap = LivesText.GetComponent<TextMeshProUGUI>();
            tap.text = ("Lives: " + lives);

            leftrigth = Random.Range(1, 3);
            if (leftrigth == 1)
            {
                myRigidbody.transform.position = new Vector3(PlatformScript.Xposition, -4, 0);
                myRigidbody.AddForce(new Vector3(-1000, 1000, 0));
            }

            if (leftrigth == 2)
            {
                myRigidbody.transform.position = new Vector3(PlatformScript.Xposition, -4, 0);
                myRigidbody.AddForce(new Vector3(1000, 1000, 0));
            }
        }
    }
    void ScaleResolution()
    {
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    void ScaleBackResolution()
    {
        gameObject.transform.localScale = new Vector3(scaleBack, scaleBack, scaleBack);
    } 

    private IEnumerator Countdown10()
    {
        // powerUpCountDown = 0;
        //canAffectCountDown = false;
        canStartCountDown = false;
            yield return new WaitForSeconds(10); //wait 10 seconds
            print("countdown ended");
            ScaleBackResolution();
            //runCountdown = false;
            powerUpCountDown = 6;
            StopCoroutine(Countdown10());
        TextMeshProUGUI tapp = powerUpCountDownText.GetComponent<TextMeshProUGUI>();
        tapp.text = ("Blocks left till power up: " + powerUpCountDown);
        canStartCountDown = true;

            //canAffectCountDown = true;//do thing
       // StopCoroutine

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("breakableBox"))
        {
            points += 1;
            if (powerUpCountDown > 0)
            {
                powerUpCountDown -= 1;
            }

            TextMeshProUGUI tap = PointsText.GetComponent<TextMeshProUGUI>();
            tap.text = ("Points: " + points);

            if (powerUpCountDown <= 0 && canStartCountDown == true)
            {
                //canAffectCountDown = false;
                //powerUpCountDown = 6;
                //runCountdown = true;
                ScaleResolution();
                StartCoroutine(Countdown10());
                //StopCoroutine(Countdown10());
            }

            TextMeshProUGUI tapp = powerUpCountDownText.GetComponent<TextMeshProUGUI>();
            tapp.text = ("Blocks left till power up: " + powerUpCountDown);

            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, -myRigidbody.velocity.y);
            Destroy(collision.gameObject);
            print("you touched and destroyed a prefab");
        }

        if (collision.gameObject.CompareTag("wall"))
        {
            myRigidbody.velocity = new Vector3(-myRigidbody.velocity.x, myRigidbody.velocity.y);
            print("touched wall");


        }

        if (collision.gameObject.CompareTag("horzWall"))
        {
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, -myRigidbody.velocity.y);
            print("touched wall");

        }

        if (collision.gameObject.CompareTag("stearingPlatform"))
        {
            if (myRigidbody.velocity.x > 0 && collision.gameObject.GetComponent<Rigidbody>().velocity.x < 0 || myRigidbody.velocity.x < 0 && collision.gameObject.GetComponent<Rigidbody>().velocity.x > 0)
            {
                myRigidbody.velocity = new Vector3(-myRigidbody.velocity.x, -myRigidbody.velocity.y);
            }
            else
            {
                myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, -myRigidbody.velocity.y);
            }
            print("touched platform");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        

        

        
        



        /*
        RaycastHit hitLeft;
        if (Physics.Raycast(transform.position, Vector3.left, out hitLeft))
        {
            print("Sphere hitLeft " + hitLeft.collider.gameObject);
        }
        distanceLeft = hitLeft.distance;
        if (distanceLeft < 0.01)
        {
            rb.velocity = Vector3.right * 10;
        }

        RaycastHit hitRight;
        if (Physics.Raycast(transform.position, Vector3.left, out hitRight))
        {
            print("hitLeft " + hitRight.collider.gameObject);
        }
        distanceLeft = hitRight.distance;
        if (distanceLeft < 0.01)
        {
            rb.velocity = Vector3.left * 10;
        }

        RaycastHit hitUp;
        if (Physics.Raycast(transform.position, Vector3.left, out hitUp))
        {
            print("hitLeft " + hitUp.collider.gameObject);
        }
        distanceLeft = hitUp.distance;
        if (distanceUp < 0.01)
        {
            rb.velocity = Vector3.down * 10;
        }

        RaycastHit hitDown;
        if (Physics.Raycast(transform.position, Vector3.left, out hitDown))
        {
            print("hitLeft " + hitDown.collider.gameObject);
        }
        distanceLeft = hitDown.distance;
        if (distanceLeft < 0.01)
        {
            rb.velocity = Vector3.up * 10;
        }
        */
    }

    /*
         if (Physics2D.Raycast(raycastHit2Dup, out ))
         {
             if (hit.collider == "wall")
             {

             }
         }*/

}

