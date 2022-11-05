using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPipes : MonoBehaviour
{

    public GameObject pipePrefab;
    public GameObject explosion;
    public void Destroy()
    {
        Destroy(pipePrefab);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pipe"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
            //Destroy(pipePrefab);
            // pipePrefab = null;
            //DestroyImmediate(pipePrefab, true);
            //Debug.Log("Pipe destroy");
        }

    }
}
