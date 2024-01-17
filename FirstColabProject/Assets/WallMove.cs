using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -50)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(10, 0, 0) * Time.deltaTime;
    }
}
