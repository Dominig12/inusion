using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponinhand : MonoBehaviour
{
    public weapon weapon;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GameObject.FindGameObjectWithTag("Player").GetComponent<weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (weapon!=null)
        {
            transform.localScale=new Vector2(weapon.lenght, transform.localScale.y);
            transform.localPosition = new Vector3(0 + 1/2 + (weapon.lenght/2), 0, -5);
        }
    }
}
