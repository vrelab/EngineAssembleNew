using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chas_Trigger : MonoBehaviour
{
    public GameObject mainchas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Chas")
        {

            mainchas.SetActive(true);
            other.gameObject.SetActive(false);
            //this.gameObject.SetActive(false);  
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Chas_Trigger>().enabled = false;                   
        }
        if (other.gameObject.tag == "Pich_Chas")
        {
            other.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
            other.gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Chas_Trigger>().enabled = false;

            //this.gameObject.SetActive(false);
        }
    }
}
