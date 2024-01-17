using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class WorldControler : MonoBehaviour
{
    public GameObject wallPrefab1;
    public GameObject wallPrefab2;
    public GameObject wallPrefab3;
    public GameObject wallPrefab4;
    GameObject[] walls;
    void Start()
    {
        walls = new GameObject[4] { wallPrefab1, wallPrefab2, wallPrefab3, wallPrefab4 };
        InvokeRepeating("SpawnRandomWall", 2f, 2.5f );
    }

    void Update()
    {
        
    }

    void SpawnRandomWall()
    {
        int rng = Random.Range(0, 101);

        if (rng <= 25)
        {
            Instantiate(walls[0], new Vector3(30, 0, 0), Quaternion.identity);

        }
        else if (rng > 25 && rng <= 50)
        {
            Instantiate(walls[1], new Vector3(30, 0, 0), Quaternion.identity);
        }
        else if (rng > 50 && rng <= 75)
        {
            Instantiate(walls[2], new Vector3(30, 0, 0), Quaternion.identity);
        }
        else if (rng > 75 && rng <= 100)
        {
            Instantiate(walls[3], new Vector3(30, 0, 0), Quaternion.identity);
        }
    }
}
