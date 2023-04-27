using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Transform pointB;

    private void OnTriggerEnter(Collider other)
    {     
        other.GetComponent<CharacterController>().enabled = false;
        other.transform.position = pointB.position;
        other.GetComponent<CharacterController>().enabled = true;
        Debug.Log("Arrived at pointB");     
       
    }
}
