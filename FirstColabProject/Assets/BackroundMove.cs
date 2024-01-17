using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackroundMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(10, 0, 0) * Time.deltaTime;

        if (transform.position.x <= -8)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
