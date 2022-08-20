using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
//creating a simple way for blocks and other objects to fall from the air to the game floor
    MeshRenderer renderer;
    Rigidbody rigidbody;


    [SerializeField] float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidbody= GetComponent<Rigidbody>();
        rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime)
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }

    }
}
