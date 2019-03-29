using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Player1 player;
    public GameObject target;
    public float speed=10;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        target = player.targeting;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.targeting!=null && target!=null)
        {
            transform.Translate((target.transform.position - transform.position).normalized * speed * Time.deltaTime);
        }
        else
        {
            target = player.targeting;
        }
      
    }
}
