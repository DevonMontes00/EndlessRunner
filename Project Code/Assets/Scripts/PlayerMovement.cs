using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    [SerializeField] private float fallIntensity = 30f;
    [SerializeField] private bool isGrounded = false;
    int timer = 5;

    // Start is called before the first frame update
    void Start()
    {
        if(!gameController)
            gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update - Time - " + gameObject.transform.position);
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * gameController.jumpIntensity, ForceMode.Impulse);

        if(Input.GetKeyDown(KeyCode.S) && !isGrounded)
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * fallIntensity, ForceMode.Impulse);
        
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 1) * Time.deltaTime * gameController.speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
            isGrounded = true;

        if (collision.gameObject.tag == "Platform Barrier")
            gameController.GameOver();

    }   

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
            isGrounded = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit");
            gameController.health -= 10;
        }

        if (other.gameObject.tag == "healthPU") { 
            if(gameController.health < 50)
                gameController.health += 10;
    }

        if (other.gameObject.tag == "jumpPU")
        {
            Debug.Log("Powerup Hit");
            jumpPUFunction();
        }

        if (other.gameObject.tag == "slowPU")
        {
            Debug.Log("Powerup Hit");
            gameController.GameOver();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Obstacle 1")
        {
            Debug.Log("Obstacle Hit");
            gameController.health -= 5;
        }
    }

    void FixedUpdate()
    {
        
    }

    void jumpPUFunction()
    {
        gameController.jumpIntensity = 10;
        StartCoroutine("CountDown");
    }

    IEnumerator CountDown()
    {
        timer = 5;
        while (timer > 0)
        {
            // wait for 1 second
            yield return new WaitForSeconds(1);
            timer--;
        }
        //set jump intensity back
        gameController.jumpIntensity = 7;
    }
}