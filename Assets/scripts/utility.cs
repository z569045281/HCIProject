using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


namespace Assets.Scripts
{
    public class utility{

  public void caculatutility(){

    

    GameObject[] containers = GameObject.FindGameObjectsWithTag("container");
    GameObject[] v_elements = GameObject.FindGameObjectsWithTag("element");
    GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
    GameObject[] p_object = GameObject.FindGameObjectsWithTag("object");

    double[] spatialU= new double[containers.Length];
    double[] combinnationU =new double[p_object.Length];
    double[] U_value =new double[p_object.Length];


    //caculate sptial distacne 
     for (int i = 0; i < containers.Length; i ++){
        double Cdistance= Vector3
                                .Distance(containers[i].transform.position,
                                player[0].transform.position);

        double Vdistance = containers[i].transform.position.y - player[0].transform.position.y;


        spatialU[i] = 1/3 *(Math.Pow(System.Math.E, Math.Pow(-(Cdistance-0.5),2))) + Math.Pow((1+ Math.Pow(Math.E, 10*Math.Abs(Vdistance)-0.5)),-1) + 1;

        // Debug.Log("spatialU is "+ spatialU[i]);


        double[] maxnumber = new double[p_object.Length];
        for(int j = 0; j< p_object.Length; j++){
            
            maxnumber[j] = 0.5/ Vector3.Distance(containers[i].transform.position,
                                           p_object[j].transform.position);
        }

         double maxValue = maxnumber.Max();
         int maxIndex = maxnumber.ToList().IndexOf(maxValue);
        
        combinnationU[i]= spatialU[i] + maxValue;
        Debug.Log("combinnationU "+ combinnationU[i]);
        Debug.Log("max index is  "+ maxIndex +"with container number "+ i);


        U_value[i]= 0.33* (0.6 * 1 *combinnationU[i] 
                                        + 0.4 * 
                                        (Math.Pow(Math.E, Math.Abs(1-combinnationU[i])) 
                                        - Math.Pow(Math.E, -1) )
                                        /(1- Math.Pow(Math.E, -1)));


        Debug.Log(U_value[i]);


     }
    




  }




}
    
}

