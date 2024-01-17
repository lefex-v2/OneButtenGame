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
        InvokeRepeating("SpawnRandomWall", 5f, 8f );
    }

    void Update()
    {
        
    }

    void SpawnRandomWall()
    {
        int rng = Random.Range(0, 4);
        Instantiate(walls[rng], new Vector3(30, 0, 0), Quaternion.identity);
    }
}
