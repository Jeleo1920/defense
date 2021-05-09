using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kantuubulletDestroy : MonoBehaviour
{

    public float timeOut;
    private float timeElapsed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            Destroy(gameObject);
            Debug.Log("aaaaaa");
        }
        //float dist = Vector3.Distance(new Vector3(0, 0, 0), transform.position);
        //if (dist > 10.0f)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("aaaaaa");
        //}
    }
}
