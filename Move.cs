using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
     // The use of serialized fields
   
  
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    
    
    void Start()
    {
        PrintInstruction();
      
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the Maze.");
        Debug.Log("Your player buttons are WASD or the arrow keys.");
        Debug.Log("Guide your player carefully");

    }

    void PlayerMovement()
    {
    //using deltatime to create consistent motion.
        float xValue = Input.GetAxis("Horizontal")*moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*moveSpeed * Time.deltaTime;

        transform.Translate(xValue,0, zValue);
    }


}
