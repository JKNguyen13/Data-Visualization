using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpawn : MonoBehaviour
{
    int time;
    public GameObject prefab;
    int check;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time++;
            
        if(time == 600){
        check++;
        if(check < 20){
        Instantiate(prefab, new Vector3(85,1,190), Quaternion.identity);
        
        time = 0 ;
       
        }
        }
    }


}

