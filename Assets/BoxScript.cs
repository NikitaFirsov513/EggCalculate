using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public Transform pointer;
      void Update()
    {

    
        Ray ray = new Ray(transform.position, transform.forward*2.9f);
        Debug.DrawRay(transform.position, transform.forward*2.9f, Color.blue);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit,2.9f))
        {
            pointer.position=hit.point;
            hit.collider.gameObject.GetComponent<Renderer>().material.color=Color.blue;
            Debug.Log(hit.distance);
        }
    }
}
