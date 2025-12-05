using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.HandGrab;

public class Screw_Trigger : MonoBehaviour
{
    int va;
    GameObject df;
    private void Update()
    {
        if (va == 10)
        {
            Debug.Log("done!");

            va = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "screw")
        {
            //rr();
            //other.gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<Screw_Trigger>().enabled = false;
            other.gameObject.transform.position = this.gameObject.transform.position;
            other.gameObject.transform.rotation = this.gameObject.transform.rotation;
            other.gameObject.GetComponentInChildren<HandGrabInteractable>().enabled = false;
        }
/*        if (other.gameObject.tag == "Driller")
        {
            this.gameObject.GetComponent<Animator>().enabled = true;
        }*/
    }
/*    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Driller")
        {
            this.gameObject.GetComponent<Animator>().enabled = false;
        }
    }*/
    public void rr()
    {
        df = GameObject.FindWithTag("Tag");
        //df.SetActive(true);
        //this.gameObject.GetComponentInChildren<MeshRenderer>().enabled = true;
        //this.gameObject.GetComponentInChildren<BoxCollider>().enabled = true;
    }

}
