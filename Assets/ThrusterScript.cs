using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThrusterScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float thrust = 20f;
    public float maxSpeed = 20f;
    public float torque = 5f;

    public GameObject QSprite;
    public GameObject WSprite;
    public GameObject ESprite;
    public GameObject RSprite;
    public GameObject USprite;
    public GameObject ISprite;
    public GameObject OSprite;
    public GameObject PSprite;

    public GameObject ThrusterQ;
    public GameObject ThrusterW;
    public GameObject ThrusterE;
    public GameObject ThrusterR;
    public GameObject ThrusterU;
    public GameObject ThrusterI;
    public GameObject ThrusterO;
    public GameObject ThrusterP;

    public GameObject UISpriteQ;
    public GameObject UISpriteW;
    public GameObject UISpriteE;
    public GameObject UISpriteR;
    public GameObject UISpriteU;
    public GameObject UISpriteI;
    public GameObject UISpriteO;
    public GameObject UISpriteP;

    public GameObject UISpriteQRed;
    public GameObject UISpriteWRed;
    public GameObject UISpriteERed;
    public GameObject UISpriteRRed;
    public GameObject UISpriteURed;
    public GameObject UISpriteIRed;
    public GameObject UISpriteORed;
    public GameObject UISpritePRed;



    private bool QKeyPressed = false;
    private bool WKeyPressed = false;
    private bool EKeyPressed = false;
    private bool RKeyPressed = false;
    private bool UKeyPressed = false;
    private bool IKeyPressed = false;
    private bool OKeyPressed = false;
    private bool PKeyPressed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("q"))
        {
            QKeyPressed = true;
            QSprite.SetActive(false);
            ThrusterQ.SetActive(true);
            UISpriteQ.SetActive(false);
            UISpriteQRed.SetActive(true);
        }
        else
        {
            QSprite.SetActive(true);
            ThrusterQ.SetActive(false);
            UISpriteQ.SetActive(true);
            UISpriteQRed.SetActive(false);
        }

        if (Input.GetKey("w"))
        {
            WKeyPressed = true;
            WSprite.SetActive(false);
            ThrusterW.SetActive(true);
            UISpriteW.SetActive(false);
            UISpriteWRed.SetActive(true);
        }
        else
        {
            WSprite.SetActive(true);
            ThrusterW.SetActive(false);
            UISpriteW.SetActive(true);
            UISpriteWRed.SetActive(false);
        }

        if (Input.GetKey("e"))
        {
            EKeyPressed = true;
            ESprite.SetActive(false);
            ThrusterE.SetActive(true);
            UISpriteE.SetActive(false);
            UISpriteERed.SetActive(true);
        }
        else
        {
            ESprite.SetActive(true);
            ThrusterE.SetActive(false);
            UISpriteE.SetActive(true);
            UISpriteERed.SetActive(false);
        }

        if (Input.GetKey("r"))
        {
            RKeyPressed = true;
            RSprite.SetActive(false);
            ThrusterR.SetActive(true);
            UISpriteR.SetActive(false);
            UISpriteRRed.SetActive(true);
        }
        else
        {
            RSprite.SetActive(true);
            ThrusterR.SetActive(false);
            UISpriteR.SetActive(true);
            UISpriteRRed.SetActive(false);
        }

        if (Input.GetKey("u"))
        {
            UKeyPressed = true;
            USprite.SetActive(false);
            ThrusterU.SetActive(true);
            UISpriteU.SetActive(false);
            UISpriteURed.SetActive(true);
        }
        else
        {
            USprite.SetActive(true);
            ThrusterU.SetActive(false);
            UISpriteU.SetActive(true);
            UISpriteURed.SetActive(false);
        }

        if (Input.GetKey("i"))
        {
            IKeyPressed = true;
            ISprite.SetActive(false);
            ThrusterI.SetActive(true);
            UISpriteI.SetActive(false);
            UISpriteIRed.SetActive(true);
        }
        else
        {
            ISprite.SetActive(true);
            ThrusterI.SetActive(false);
            UISpriteI.SetActive(true);
            UISpriteIRed.SetActive(false);
        }

        if (Input.GetKey("o"))
        {
            OKeyPressed = true;
            OSprite.SetActive(false);
            ThrusterO.SetActive(true);
            UISpriteO.SetActive(false);
            UISpriteORed.SetActive(true);
        }
        else
        {
            OSprite.SetActive(true);
            ThrusterO.SetActive(false);
            UISpriteO.SetActive(true);
            UISpriteORed.SetActive(false);
        }

        if (Input.GetKey("p"))
        {
            PKeyPressed = true;
            PSprite.SetActive(false);
            ThrusterP.SetActive(true);
            UISpriteP.SetActive(false);
            UISpritePRed.SetActive(true);
        }
        else
        {
            PSprite.SetActive(true);
            ThrusterP.SetActive(false);
            UISpriteP.SetActive(true);
            UISpritePRed.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        if (QKeyPressed) //top left thruster
        {
            rb.AddForce(transform.up * thrust * Time.fixedDeltaTime * -1); //adds downwards force
            rb.AddTorque(torque * Time.fixedDeltaTime); //rotates anticlockwise

            QKeyPressed = false;//
        }

        if (WKeyPressed) //left top thruster
        {
            rb.AddForce(transform.right * thrust * Time.fixedDeltaTime); //adds right facing force
            rb.AddTorque(torque * -1 * Time.fixedDeltaTime); //rotates clockwise

            WKeyPressed = false;//
        }

        if (EKeyPressed) //left bottom thruster
        {
            rb.AddForce(transform.right * thrust * Time.fixedDeltaTime); //adds right facing force
            rb.AddTorque(torque * Time.fixedDeltaTime); //rotates anticlockwise

            EKeyPressed = false;
        }

        if (RKeyPressed) //bottom left thruster
        {
            rb.AddForce(transform.up * thrust * Time.fixedDeltaTime); //adds upwards force
            rb.AddTorque(torque * -1 * Time.fixedDeltaTime); //rotates clockwise

            RKeyPressed = false; //
        }

        if (UKeyPressed) //bottom right thruster
        {
            rb.AddForce(transform.up * thrust * Time.fixedDeltaTime); //adds upwards force
            rb.AddTorque(torque * Time.fixedDeltaTime); //rotates anticlockwise

            UKeyPressed = false; //
        }

        if (IKeyPressed) //right bottom thruster
        {
            rb.AddForce(transform.right * thrust * Time.fixedDeltaTime * -1); //adds left facing force
            rb.AddTorque(torque * -1 * Time.fixedDeltaTime); //rotates clockwise

            IKeyPressed = false;//
        }

        if (OKeyPressed) //right top thruster
        {
            rb.AddForce(transform.right * thrust * Time.fixedDeltaTime * -1); //adds left facing force
            rb.AddTorque(torque * Time.fixedDeltaTime); //rotates anticlockwise

            OKeyPressed = false;
        }

        if (PKeyPressed) //top right thruster
        {
            rb.AddForce(transform.up * thrust * Time.fixedDeltaTime * -1); //adds downwards force
            rb.AddTorque(torque * -1 * Time.fixedDeltaTime); //rotates clockwise

            PKeyPressed = false;
        }




        //Debug.Log(rb.velocity + "angular velocity: " + rb.angularVelocity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LevelEnd")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("level ended");
        }

        if (collision.gameObject.tag == "LevelRestart")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("level restarted");
        }
    }
}
