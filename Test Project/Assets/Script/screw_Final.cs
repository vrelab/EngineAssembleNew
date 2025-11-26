using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screw_Final : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject c9;
    public GameObject c10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "screw")
        {
            c1.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c2.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c3.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c4.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c5.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c6.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c7.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c8.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c9.gameObject.GetComponent<MeshRenderer>().enabled = false;
            c10.gameObject.GetComponent<MeshRenderer>().enabled = false;
            s2.SetActive(false);
            s1.SetActive(true);            
            s3.SetActive(false);
        }
    }
}
