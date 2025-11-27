using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction.HandGrab;

public class crank_Trigger : MonoBehaviour
{
    public GameObject move_Crank;
    public GameObject move_Crank_coll;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Crank")
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<MeshCollider>().enabled = false;
            //other.gameObject.transform.position = this.gameObject.transform.position;
            //other.gameObject.transform.rotation = this.gameObject.transform.rotation;
            //ther.gameObject.GetComponentInChildren<HandGrabInteractable>().enabled = false;
            move_Crank.SetActive(true);
            move_Crank_coll.SetActive(true);
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
