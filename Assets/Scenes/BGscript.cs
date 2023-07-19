using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscript : MonoBehaviour
{
    public float moveSpeed = 2;
    public double respawnPosTrig = -52.8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x <= respawnPosTrig)
        {
            transform.position = new Vector3(0, 0, 0); 
        }
    }
}
