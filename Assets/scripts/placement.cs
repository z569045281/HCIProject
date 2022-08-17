using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placement : MonoBehaviour
{

   public void JustDoit(){

    GameObject[] containers = GameObject.FindGameObjectsWithTag("container");
    GameObject[] v_elements = GameObject.FindGameObjectsWithTag("element");
    

    for(int i = 0; i< v_elements.Length; i++){
        Debug.Log(containers[i].transform.position);
        Debug.Log(v_elements[i].transform.position);

        v_elements[i].transform.position= containers[i].transform.position;
    }
    
}}
