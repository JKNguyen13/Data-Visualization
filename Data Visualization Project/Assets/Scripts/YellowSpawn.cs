using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YellowSpawn : MonoBehaviour
{
    int time;
    public GameObject prefab;
    public int check;
    public List<GameObject> storage = new List<GameObject>();   
    public TextMeshProUGUI totalN;
    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time++;
            
        if(time == 300){
        check++;
        if(check < 174){ //321.1 //each agent is 100,000 viewers //total viewers for season 1 is 32,110,000
            
        clone = Instantiate(prefab, new Vector3(85,1,175), Quaternion.identity);

        //clone.name = "clone" + check.ToString();

        storage.Add(prefab);
   
        time = 0 ;
       
        }
        }
        totalN.text = "Millions: " + storage.Count.ToString();
        
        
    }
    
}

