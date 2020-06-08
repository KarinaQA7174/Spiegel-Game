using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gff : MonoBehaviour
{

    Rigidbody2D rb;
    int Life = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            gly();
        }
    }

    [System.Obsolete]
    void OnTriggerEnter2D(Collider2D shit)
    {
        if (shit.gameObject.tag == "Eat")
        {
            Life++;
            Destroy(shit.gameObject);
        }

        if (shit.gameObject.tag == "Finish")
        {
            Application.LoadLevel("SampleScene(2)");
        }

    }

    [System.Obsolete]
    void OnCollisionEnter2D(Collision2D shit)
    {
        if (shit.gameObject.tag == "riss")
        {
         
            Life--;
        }
        if (Life < 1)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 30), "Life = " + Life);
    }

    [System.Obsolete]
    void ReloadLevel()
    {
        Application.LoadLevel (Application.loadedLevel);
    }



    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 12f, rb.velocity.y);
    }

    void gly()
    {
        rb.AddForce (transform.up * 14f, ForceMode2D.Impulse);

    }
}