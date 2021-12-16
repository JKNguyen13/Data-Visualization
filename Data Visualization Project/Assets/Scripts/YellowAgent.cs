using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class YellowAgent : MonoBehaviour
{
    public Transform home;
    NavMeshAgent yAgent;
    int number = 0;
    int number2 = 0;
    int number3 = 0;
    int number4 = 0;
    public TextMeshProUGUI s1;
    public TextMeshProUGUI s2;
    public TextMeshProUGUI s3;
    public TextMeshProUGUI s4;

    //.FindWithTag();

    // Start is called before the first frame update
    void Start()
    {

        yAgent = this.GetComponent<NavMeshAgent>();

        yAgent.destination = GameObject.FindWithTag(NumberGenerator()).transform.position;
         
    }

    string NumberGenerator(){

        int numbs = Random.Range(1,100); //million 174 million total
        /*if(numbs <= 61){
            return "Yellow";
        }else if(numbs <= 111){
            return "Black";
        }else if(numbs <= 147){
            return "Red";
        }else if(numbs <= 174){
            return "Blue";
        }else{
            return "0";
        }*/

        if(numbs <= 35){
            return "Yellow";
        }else if(numbs <= 64){
            return "Black";
        }else if(numbs <= 85){
            return "Red";
        }else if(numbs <= 100){
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

        if(clone.CompareTag("Yellow") || clone.CompareTag("Black") || clone.CompareTag("Red")){
            
            //Destroy(gameObject);
           
            
        }
        
        if(clone.CompareTag("Yellow")){
            Data.number++;
            s1.text = "Views: " + Data.number.ToString();
        }else if (clone.CompareTag("Black")){
            Data.number2++;
            s2.text = "Views: " + Data.number2.ToString();
        }else if (clone.CompareTag("Red")){
            Data.number3++;
            s3.text = "Views: " + Data.number3.ToString();
        }else if (clone.CompareTag("Blue")){
            Data.number4++;
            s4.text = "Views: " + Data.number4.ToString();
        }else{
            Debug.Log(1);
        }
    }
}
