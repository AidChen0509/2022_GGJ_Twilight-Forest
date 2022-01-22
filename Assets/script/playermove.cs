using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float RotationSpeed;
    float energy = 20;
    bool canrun;
    bool trap;
    public float traptime=2f;
    public bool trapact;
    public Vector2 mo;
    public Animator playerani;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (trapact)
        {
            StartCoroutine(trapatt());
        }
        else if (!trap)
        {
            rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
            mo = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
            if (mo.x != 0 || mo.y != 0)
            {
                playerani.SetBool("ismove", true);
            }
            else
            {
                playerani.SetBool("ismove", false);
            }
            if (energy >= 0) canrun = true;
            else canrun = false;
            if (canrun = false)
            {
                energy += Time.deltaTime;
                if (energy >= 20) canrun = true;
            }
        }
        
        faceMouse();
        //  StartCoroutine(energytime());
        /*  if (Input.GetKey(KeyCode.LeftShift) && canrun ) 
          {
              speed = 5;
              energy -= Time.deltaTime;
          }*/
    }
    IEnumerator trapatt()
    {
        playerani.SetBool("ismove", false);
        trapact = false;
        trap = true;
        rb.velocity = new Vector2(0,0);
        yield return new WaitForSeconds(traptime);
        trap = false;
    }

    IEnumerator energytime()
    {
        yield return new WaitForSeconds(0.05f);
    }
    void faceMouse() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
                mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y
            );
        transform.up = direction;
    }
}
