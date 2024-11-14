using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_delegate_event : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    private DragonCollecting dragon;
    private GameObject toMove;
    bool moving = false;
    void Start()
    {
        GameObject dragonObj = GameObject.FindWithTag("blueDragon");
        if (dragonObj != null)
        {
            dragon = dragonObj.GetComponent<DragonCollecting>();
            if (dragon != null)
            {
                dragon.action += message;
            }
        }

        toMove = GameObject.FindWithTag("target");
        if(toMove == null)
        {
            Debug.Log("target not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(moving && toMove != null)
        {
            Vector3 direction = toMove.transform.position - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    void message(string msg)
    {   
        if(msg == "move") 
        {
            moving = true;
        }
    }
}
