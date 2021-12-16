using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class BlackAgent : MonoBehaviour
{
    public Transform home;
    NavMeshAgent bAgent;
    int likes = 0;
    int likes2 = 0;
    int likes3 = 0;
    int likes4 = 0;
    public TextMeshProUGUI s1l;
    public TextMeshProUGUI s2l;
    public TextMeshProUGUI s3l;
    public TextMeshProUGUI s4l;

    // Start is called before the first frame update
    void Start()
    {
        bAgent = this.GetComponent<NavMeshAgent>();

        bAgent.destination = GameObject.FindWithTag(NumberGenerator()).transform.position;
    }

    string NumberGenerator(){

        int numb = Random.Range(1,120); // 1000 likes 120,000 total
        if(numb <= 39){
            return "Yellow";
        }else if(numb <= 69){
            return "Black";
        }else if(numb <= 94){
            return "Red";
        }else if(numb <= 120){
            return "Blue";
        }else{
            return "0";
        }

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void OnTriggerEnter (Collider clone) {
        
            
            Destroy(gameObject);
            //Destroy(clone,200);

            if(clone.CompareTag("Yellow")){
            Data.likes++;
            s1l.text = "Likes: " + Data.likes.ToString();
        }else if (clone.CompareTag("Black")){
            Data.likes2++;
            s2l.text = "Likes: " + Data.likes2.ToString();
        }else if (clone.CompareTag("Red")){
            Data.likes3++;
            s3l.text = "Likes: " + Data.likes3.ToString();
        }else if (clone.CompareTag("Blue")){
            Data.likes4++;
            s4l.text = "Likes: " + Data.likes4.ToString();
        }
            
        
    }
}
