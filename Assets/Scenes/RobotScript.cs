using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RobotScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float jumpStrength;
    private bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if ((Input.GetKeyDown(KeyCode.Space) == true) && isAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        Debug.Log("Collided for real");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
