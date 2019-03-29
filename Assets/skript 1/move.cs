using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Player1 player;
    public float maxstamina;
    public float stamina;
    public float speedstamina;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        maxstamina = player.stamina;
        stamina = maxstamina;
        movespeed = player.movespeed;
        speedstamina = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (stamina<maxstamina)
        {
            stamina += Time.deltaTime * speedstamina;
        }
        if (stamina<=0)
        {
            player.destamin = true;
        }
        if (player.destamin==true && stamina>=maxstamina)
        {
            player.destamin = false;
        }
        if (player.destamin==true)
        {
            movespeed = player.movespeed/2;
        }
        else
        {
            movespeed = player.movespeed;
            if (player.stun != true)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    stamina -= Time.deltaTime * speedstamina * 3;
                    movespeed = player.movespeed * 2;
                }
            }
        }
        if (player.stun!=true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * movespeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * movespeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up * movespeed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.down * movespeed * Time.deltaTime;
            }
        }

    }
}
