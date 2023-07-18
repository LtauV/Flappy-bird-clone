using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = transform.position.x;
        Vector3 newPosition = new Vector3((float)(startpos + 0.9), transform.position.y,0);
        transform.position = newPosition;
        if (temp > startpos + (length / 2)) startpos += length;
        else if (temp < startpos + (length / 2)) startpos -= length;
    }
}
