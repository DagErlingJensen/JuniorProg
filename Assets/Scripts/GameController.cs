using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

 [Header("Coin Settings")]
    public GameObject coinPickUp;
    

 [Header ("Bomb Settings")]
    public GameObject bombPickUp;
    

    [Header("Spawn Area")]
    public float maxYSpawn;
    public float minYSpawn;
    public float distanceFromPlayerX;
    
    [Header("Spawn Rate")]
    public float startDelay;
    public float repeatRate;
    

    private int randomSpawn;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRoll", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRoll()
    {
        randomSpawn = Random.Range(1, 10);

        if (randomSpawn < 5)
        {
            Debug.Log("Spawn Coin");
        }
        else {
            Debug.Log("Spawn Bomb");
        }
    }
}
