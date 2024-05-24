using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoExercise2 : MonoBehaviour
{

    //Task 1. Create 3 variables: a,x,y:
    public int a;
    public int x;
    public int y;

    // Start is called before the first frame update
    void Start()
    {
        //Create and call this function in start
        QuickMath();
    }

    //Function to perform quick math operations
    void QuickMath()
    {
        //Check if 'a' is smaller than 'x'
        if (a < x)
        {
            // Add 'a' and 'y'
            int result = a + y;

            //Check if the result is smaller than x
            if (result < x)
            {
                // True = print x is the biggest number
                Debug.Log("x is the biggest number");
            }
            else
            {
                // False = printx is not the biggest number
                Debug.Log("x is not the biggest number");
            }
        }
        else
        {
            //print out the remainder of a/y
            int remainder = a % y;
            Debug.Log("Remainder of a divided by y: " + remainder);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
