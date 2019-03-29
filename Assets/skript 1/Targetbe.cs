using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetbe : MonoBehaviour
{
    Player1 player;
    public Vector3 target;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        if (player.targeting!=null)
        {
            target = player.targeting.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        if (player.targeting != null)
        {
            target = player.targeting.transform.position;
            var angle = Vector2.Angle(Vector2.right, target - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, transform.position.y < target.y ? angle : -angle), 0.5f);
            distance = (target - transform.position).magnitude;
            player.distansetarget = distance;
        }
    }
}
