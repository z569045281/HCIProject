using System.Collections;
using System.Collections.Generic;
using UnityEngine;






namespace Assets.Scripts
{

    public class spatio
    {
        public GameObject[] containers;

        public GameObject[] v_elements;

        public GameObject[] p_objects;

        public GameObject[] p_player;


        public void caculateSpatio()
        {
          containers = GameObject.FindGameObjectsWithTag("container");
          p_player = GameObject.FindGameObjectsWithTag("Player");

          double[] arrayN = new double[containers.Length];

          for (int i = 0; i < containers.Length; i ++){

              
              double distance = Vector3
                                .Distance(containers[i].transform.position,
                                p_player[0].transform.position);
              
              arrayN[i] = distance;

          }

          Debug.Log(arrayN[0]); 
          

        }
    }
}

