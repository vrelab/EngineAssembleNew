using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw_Rotate_Trigger : MonoBehaviour
{
   // public GameObject p;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Driller")
        {
            Debug.Log("ghghghgh");
            this.GetComponent<Animator>().enabled = true;
            //p.GetComponent<Animator>().enabled = true;
            //other.gameObject.GetComponentInParent<Animator>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Driller")
        {
            Debug.Log("ghghghgh");
            this.GetComponent<Animator>().enabled = false;
            //p.GetComponent<Animator>().enabled = false;
            //other.gameObject.GetComponentInParent<Animator>().enabled = true;
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("bbbhjhjh");
    //    if (collision.gameObject.CompareTag("Driller"))
    //    {
    //        Debug.Log("jhjhjhjh");
    //        this.GetComponent<Animator>().enabled = true;
    //        p.GetComponent<Animator>().enabled = true;
    //        //collision.gameObject.GetComponentInParent<Animator>().enabled = true;
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Driller"))
    //    {
    //        this.GetComponent<Animator>().enabled = false;
    //        p.GetComponent<Animator>().enabled = false;
    //        //collision.gameObject.GetComponentInParent<Animator>().enabled = false;
    //    }
    //}
}
