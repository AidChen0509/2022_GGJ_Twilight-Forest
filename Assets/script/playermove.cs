using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playermove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    float runspeed;
    float walkspeed;
    public float RotationSpeed;
    //float energy = 20;
    bool runcd=false;
    bool trap;
    bool onrun=false;
    bool oncharge = true;
    public float traptime=2f;
    public bool trapact;
    public float power=100;
    public Vector2 mo;
    public Animator playerani;
    public Vector2 mousePosition;
    public Transform playersp;
    public Text powerui;
    public string gameoverScene;
    // Start is called before the first frame update
    void Start()
    {
        runspeed = speed + 3;
        walkspeed = speed;
        //powerui = gameObject.transform.Find("powerui").GetComponent<Text>();
        this.transform.position = playersp.position;
        mousePosition.x = 0f;
        mousePosition.y = 0f;
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
            powerui.text = "power:" + power;
            if(power==0)
            {
                runcd = true;
            }
            if (runcd && power > 40)
                runcd = false;
            if (Input.GetKey("e")&&!onrun&&power>6&&!runcd)
            {
                onrun = true;
                oncharge = false;
                speed = runspeed;
                power -= 7;
                StartCoroutine(rundelay());
            }else if(oncharge&&!onrun)
            {
                oncharge = false;
                StartCoroutine(runcharge());
            }
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
            /*if (energy >= 0) canrun = true;
            else canrun = false;
            if (canrun = false)
            {
                energy += Time.deltaTime;
                if (energy >= 20) canrun = true;
            }*/
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
    IEnumerator rundelay()
    {
        yield return new WaitForSeconds(0.1f);
        speed = walkspeed;
        oncharge = true;
        onrun = false;
    }
    IEnumerator runcharge()
    {
        yield return new WaitForSeconds(0.05f);
        if (power < 100)
            power += 1;
        oncharge = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag=="monster")
        {
            print("gameover");
            SceneManager.LoadScene(gameoverScene); 
        }
    }
    void faceMouse() {
            if (Input.GetKey(KeyCode.W))
            {
                if (mousePosition.y != 1.0f)
                {
                    mousePosition.y = mousePosition.y + 0.25f;
            }
                if (Input.GetKey(KeyCode.A)!= true)
                {
                if (Input.GetKey(KeyCode.D) != true)
                {
                    mousePosition.x = 0f;
                }
            }
                
        }

            if (Input.GetKey(KeyCode.S))
            {
                if (mousePosition.y != -1.0f)
                {
                    mousePosition.y = mousePosition.y - 0.25f;
            }
            if (Input.GetKey(KeyCode.A) != true)
            {
                if (Input.GetKey(KeyCode.D) != true)
                {
                    mousePosition.x = 0f;
                }
            }
        }

            if (Input.GetKey(KeyCode.A))
            {
                if (mousePosition.x != -1.0f)
                {
                    mousePosition.x = mousePosition.x - 0.25f;
                }
                if (Input.GetKey(KeyCode.W)!=true)
                {
                    if (Input.GetKey(KeyCode.S) != true)
                    {
                    mousePosition.y = 0f;
                    }
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (mousePosition.x != 1.0f)
                {
                    mousePosition.x = mousePosition.x + 0.25f;
            }
            if (Input.GetKey(KeyCode.W) != true)
            {
                if (Input.GetKey(KeyCode.S) != true)
                {
                    mousePosition.y = 0f;
                }
            }
        }
        transform.up = mousePosition;
    }
}
