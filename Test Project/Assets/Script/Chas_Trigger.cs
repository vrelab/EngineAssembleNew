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
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            mainchas.SetActive(true);
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);                      
        }
        if (other.gameObject.tag == "Pich_Chas")
        {
            other.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<Chas_Trigger>().enabled = true;
            this.gameObject.SetActive(false);
        }
    }
}
