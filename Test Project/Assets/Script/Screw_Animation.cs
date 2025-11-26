using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw_Animation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Driller")
        {
            this.GetComponent<Animator>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Driller")
        {
            this.GetComponent<Animator>().enabled = false;
        }
    }
}
