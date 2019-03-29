using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public float lenght;
    public float damage;
    public float attackspeed;
    public string damagetype;
    public string weapons="sword";
    // Start is called before the first frame update
    void Start()
    {
        Weapons(weapons);
    }

    void Weapons(string weapon)
    {
        if (weapon=="spire")
        {
            print("Weapon Spire");
            lenght = 5;
            damage = 20;
            attackspeed = 1;
            damagetype = "piercing";
        }
        if (weapon=="sword")
        {
            lenght = 3;
            damage = 15;
            attackspeed = 2;
            damagetype = "cutting";
        }
        if (weapon=="knife")
        {
            lenght = 2;
            damage = 10;
            attackspeed = 3;
            damagetype = "piercing";
        }
        if (weapon== "mace")
        {
            lenght = 3;
            damage = 20;
            attackspeed = 2;
            damagetype = "crushing";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
