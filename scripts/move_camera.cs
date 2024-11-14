using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        // move rotation with mouse
    }
}
