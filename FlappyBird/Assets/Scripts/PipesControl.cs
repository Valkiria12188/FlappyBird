using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesControl : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Pipes Speed Settings")]
    private Vector3 direction = new Vector3(-1, 0, 0);
    public float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * speed;
    }
}
