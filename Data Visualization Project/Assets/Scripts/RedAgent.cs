using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RedAgent : MonoBehaviour
{
    public Transform home;
    NavMeshAgent rAgent;

    // Start is called before the first frame update
    void Start()
    {
        rAgent = this.GetComponent<NavMeshAgent>();
        rAgent.SetDestination(home.position);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void OnTriggerEnter (Collider clone) {
        if(clone.CompareTag("Red")){
            
            Destroy(gameObject);
            //Destroy(clone,200);
            
        }
    }
}
