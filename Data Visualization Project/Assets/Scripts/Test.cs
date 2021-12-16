using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class Test : MonoBehaviour
{
    public Transform home;
    NavMeshAgent yAgent;
    //public TextMeshProUGUI totalN;
    int time;
    public GameObject prefab;
    int check;
    //public List<GameObject> storage = new List<GameObject>();
    GameObject clone;


    void Start()
    {
        yAgent = this.GetComponent<NavMeshAgent>();
        yAgent.SetDestination(home.position);
    }


    void Update()
    {   
        time++;
            
        if(time == 600){
        check++;
        if(check < 20){
            
        clone = Instantiate(prefab, new Vector3(45,1,20), Quaternion.identity);

        //storage.Add(prefab);
        

        /*if(other.gameObject.CompareTag("Yellow")){
            List<GameObject.Remove(check[1])
        }*/

        

        time = 0 ;
       
        }
        }

        //totalN.text = "Amount: " + storage.Count.ToString();

        

        /*if(storage[1].CompareTag("Red")){
            storage.RemoveAt(1);
        }*/
    }
     public void OnTriggerEnter (Collider clone) {
        if(clone.CompareTag("Yellow")){
            //storage.RemoveAt(0);
            check = 600;
            Destroy(clone,1);
        }
    }
}
