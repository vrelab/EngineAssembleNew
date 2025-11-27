using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using OVRTouchSample;
using Oculus;
using OculusSampleFramework;
using Oculus.Interaction;

public class trigger_tochange : MonoBehaviour
{
    public GameObject Crine1;
    public GameObject Crine2;
    //public Grabbable ee;
    //OneGrabFreeTransformer ww;
    private void Start()
    {
        //ww=Crine.GetComponent<OneGrabFreeTransformer>();
        //Debug.Log("hhhhh");
    }
    private void OnTriggerEnter(Collider other)
    {
        Crine2.SetActive(true);
        Crine1.SetActive(false);
        //Crine.gameObject.GetComponent<Grabbable>()._oneGrabTransformer = ww;
        //Debug.Log("sssss");
    }
}
