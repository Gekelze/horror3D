using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float cameraSensative;
    private float horizontal;
    private float verticale;
    private Rigidbody rb;
    private float mouseX;
    private float mouseY;
    public GameObject kamera;
    private GameManager gameManager;
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        score = GameObject.Find("Score").GetComponent<Score>();
        score.UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        mouseY = Input.GetAxis("Mouse Y")*cameraSensative;
        mouseX = Input.GetAxis("Mouse X")*cameraSensative;
        horizontal = Input.GetAxis("Horizontal");
        verticale = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward*speed*verticale);
        rb.AddForce(transform.right*speed*horizontal);
        transform.Rotate(Vector3.up*mouseX*Time.deltaTime);
        kamera.transform.Rotate(Vector3.left*mouseY*Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {      
        if(other.gameObject.CompareTag("Coin"))
        {
            score.AddScore(); 
            Destroy(other.gameObject); 
        }
       if(other.gameObject.CompareTag("Victory"))
        {
            Debug.Log("работает");
            gameManager.VictoryGame();
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("monster"))
        {
            gameManager.GameOver();
        }
    }
}
