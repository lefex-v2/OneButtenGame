using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        InvokeRepeating("SpawnWall", 10f, 2f );
    }

    void Update()
    {
        
    }

    void SpawnWall()
    {
        Instantiate(walls[Random.Range(0, 3)], new Vector3(30, 0, 0), Quaternion.identity);
    }
}
