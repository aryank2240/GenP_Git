using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody player;
    public Transform player2;
    public bool ground44()
    {
        if (player2.position.y != 1)
        {
            return false;

        }
        return true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.AddForce(500*Time.deltaTime,0,0 ,ForceMode.VelocityChange) ;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.AddForce(-500*Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKeyDown(KeyCode.W) && ground44() )
        {
            player.AddForce(0, 500*Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
