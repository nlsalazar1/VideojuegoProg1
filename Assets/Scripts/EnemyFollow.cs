using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject MyTarget;
    public NavMeshAgent MyAgent;
    public int range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(this.transform.position, MyTarget.transform.position);
        print("Distance to other " + dist);
        if(dist<range)  //para q se acerque si es menor al rango
        {
            MyAgent.destination = MyTarget.transform.position;
        }
    }
}
