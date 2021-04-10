using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour
{
    public NavMeshAgent player;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = gameObject.GetComponent<NavMeshAgent>();
        if (target !=null)
        {
            player.destination = target.transform.position;
        }
    }
}
