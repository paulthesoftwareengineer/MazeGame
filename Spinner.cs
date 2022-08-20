using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
//created options for the Unity Editor that enable the spinner to rotate on one or a combination of axis
    [SerializeField] float xAxis=0f;
    [SerializeField] float yAxis=0f;
    [SerializeField] float zAxis=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxis, yAxis, zAxis);
    }
}
