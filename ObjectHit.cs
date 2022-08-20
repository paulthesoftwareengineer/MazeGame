using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {

        if(other.gameObject.tag == "Player" )
        {
        //changing the color of the object after it is hit
            GetComponent<MeshRenderer>().material.color=Color.red;
            gameObject.tag = "Hit";
        }
    }
}
