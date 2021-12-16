using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject original;
    int time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        //time++;

        //if(time == 600){
        GameObject clone = (GameObject)Instantiate (original, new Vector3(45,1,-20), Quaternion.identity);
        //time = 0;
    //}
    }
}
