using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    Taget1 target;
    Player1 player;
    weapon weapon;
    move move;
    float updatetime;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player1>();
        weapon = player.GetComponent<weapon>();
        move = player.GetComponent<move>();
        updatetime = weapon.attackspeed*20;
        if (player.targeting != null)
        {
            target = player.targeting.GetComponent<Taget1>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.targeting != null)
        {
            target = player.targeting.GetComponent<Taget1>();
            if (updatetime <= 0)
            {
                player.attacking = false;
                target.attacked = false;
                if (player.attacking==false)
                {
                    updatetime = weapon.attackspeed * 20;
                }
            }
        }
        if (weapon!=null)
        {
            if(Input.GetKeyDown(KeyCode.R) && move.stamina>=20 && player.stun!=true && player.attacking!=true && updatetime==weapon.attackspeed*20)
            {
                player.attacking = true;
                move.stamina -= 20;
                if (weapon.lenght >= player.distansetarget)
                {
                    target.attacked = true;
                    if (updatetime<=0)
                    {
                        target.hp -= weapon.damage;
                        updatetime = weapon.attackspeed * 20;
                    }
                }
            }
            if (player.attacking==true)
            {
                updatetime -= 1;
            }

        }
    }
}
