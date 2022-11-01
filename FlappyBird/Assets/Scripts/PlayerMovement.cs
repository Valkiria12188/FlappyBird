using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Settings")]
    private Rigidbody rb;
    public float force;
    private int life = 1;

    GameManager gm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    void Update()
    {
        if (transform.position.y < 15f || transform.position.y > 35f)
        {
            gm.LoadLevel(0);
        }

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, force, 0, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            life--;
            if (life <= 0)
            {
                gm.LoadLevel(0);
            }
        }
    }

}
