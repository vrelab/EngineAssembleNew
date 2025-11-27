using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using OVR;
using Oculus.Interaction.Grab;
using Oculus.Interaction.GrabAPI;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;


public class trigger_Script : MonoBehaviour
{
    //public GameObject grab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "guard")
        {
            Debug.Log("ddddddd");
            this.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.transform.position = this.gameObject.transform.position;
            other.gameObject.transform.rotation = this.gameObject.transform.rotation;
            other.gameObject.GetComponentInChildren<HandGrabInteractable>().enabled = false;
        }
    }
}
