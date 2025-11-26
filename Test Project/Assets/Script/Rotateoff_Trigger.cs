using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateoff_Trigger : MonoBehaviour
{
    public GameObject tr1;
    public GameObject tr;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "R_Off")
        {
            
            tr1.SetActive(true);
            tr.SetActive(false);
            //other.gameObject.SetActive(false);
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        if (other.gameObject.tag == "Ts_Off")
        {
            tr1.SetActive(true);
            tr.SetActive(false);
        }
    }
}
