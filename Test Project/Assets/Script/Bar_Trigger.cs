using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Oculus.Interaction.HandGrab;

public class Bar_Trigger : MonoBehaviour
{
    int va;
    private void Update()
    {
        if (va == 5)
        {
            Debug.Log("done!");

            va = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bar")
        {
            other.gameObject.transform.position = this.gameObject.transform.position;
            other.gameObject.transform.rotation = this.gameObject.transform.rotation;
            //other.gameObject.GetComponentInChildren<HandGrabInteractable>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
