using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackSpawn : MonoBehaviour
{
    int time;
    public GameObject prefab;
    public int check;
    

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
        if(check < 120){
        Instantiate(prefab, new Vector3(85,1,160), Quaternion.identity);
        time = 0 ;
        }
    }
}
}
