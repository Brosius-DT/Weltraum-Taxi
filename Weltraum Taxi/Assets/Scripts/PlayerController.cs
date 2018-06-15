using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Vector2 Speed;
    public bool isGearUp = true;
    private bool isCrashed = false;
    private bool hasCustomer = false;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") > 0)
        {
            //Beschleunigen hoch
            rb.AddForce(Speed * Time.deltaTime, ForceMode2D.Force);
        } else
        {
            rb.AddForce(-Speed * Time.deltaTime, ForceMode2D.Force);
        }
       
    }

    void Accelarate()
    {
        
    }

    void GearDown ()
    {

    }

    void GearUp ()
    {

    }
}
