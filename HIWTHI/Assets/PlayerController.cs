using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private int health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > .1)
        {
            transform.position += new Vector3(.05f, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < -.1)
        {
            transform.position += new Vector3(-.05f, 0, 0);
        }

        if (Input.GetAxis("Vertical") > .1)
        {
            transform.position += new Vector3(0, 0.05f, 0);
        }
        if (Input.GetAxis("Vertical") < -.1)
        {
            transform.position += new Vector3(0, -.05f, 0);
        }


    }

    public void takeDamage(int dmg)
    {
        print("Player just took " + dmg + " damage");
        health -= dmg;
        if (health <= 0)
        {
            print("Oh no! The player has died!");
        }
    }
}
