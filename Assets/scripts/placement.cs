using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gurobi;



namespace Assets.Scripts{
public class placement : MonoBehaviour
{

   public void JustDoit(){

    GameObject[] containers = GameObject.FindGameObjectsWithTag("container");
    GameObject[] v_elements = GameObject.FindGameObjectsWithTag("element");

    double[,] array2D = new double[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

    
    
    for(int i = 0; i< v_elements.Length; i++){
        Debug.Log(containers[i].transform.position);
        Debug.Log(v_elements[i].transform.position);

        v_elements[i].transform.position= containers[i].transform.position;
    }


    
    
}
public void utility(){
    var U = new utility();

    U.caculatutility();

}

}
}