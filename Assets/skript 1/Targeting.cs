using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    public GameObject[] targets;
    public GameObject target;
    Player1 player;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        targets = GameObject.FindGameObjectsWithTag("target");
        i = targets.Length;
    }

    // Update is called once per frame
    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("target");
        if (player.stun != true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (player.targeting != null)
                {
                    player.targeting.GetComponent<Taget1>().attacked = false;
                }
                if (i >= 0)
                {
                    player.targeting = targets[i - 1];
                    target = player.targeting;
                    i -= 1;
                }
                if (i == 0)
                {
                    i = targets.Length;
                }
            }
        }
    }
}
