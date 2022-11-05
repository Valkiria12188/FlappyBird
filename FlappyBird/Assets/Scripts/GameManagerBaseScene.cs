using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManagerBaseScene : MonoBehaviour
{
    [Header("Bird Settings")]
    public GameObject birdPrefab;
    public Transform startPosition;

    [Header("Pipe Settings")]
    public GameObject pipePrefab;
    //private Vector3 pipeStartPosition = new Vector3(25, -3, 0);

    private void Awake()
    {
        Instantiate(birdPrefab, startPosition.position, Quaternion.identity);
        //Instantiate(pipePrefab, pipeStartPosition, Quaternion.identity);
    }
    private void Start()
    {
        InvokeRepeating("SpawnPipes", 1f, 2f);
    }

    public void SpawnPipes()
    {
        int randomIndex = Random.Range(-5, 7);
        Vector3 spaceBetweenPipes = new Vector3(25, randomIndex, 0);
        GameObject clone = Instantiate(pipePrefab, spaceBetweenPipes, Quaternion.identity);
        Destroy(clone,10f);
    }
    
}
