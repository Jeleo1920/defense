using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mybotbase : MonoBehaviour
{
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(pos.x - 1, 0, pos.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(pos.x + 1, 0, pos.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(pos.x, 0, pos.z + 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(pos.x, 0, pos.z - 1);
        }
    }
}
