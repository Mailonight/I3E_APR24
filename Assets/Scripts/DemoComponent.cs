using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoComponent : MonoBehaviour
{
    //Properties
    public string componentName;
    public int value;
    public Color color;
    public bool isCollected; //to track whether the gemstone has been collected or not
    public string rarity; //the rarity level of the gemstone

    string helloString = "hello world, i'm a string";


    // Function to handle what happens when the collectible is collected

    //Behaviours that I want (Functions):
    //1. GetCollected()
    //2. DisplayEffect()
    //3. UpdateProperties()

    //Functions:
    public void GetCollected() //to handle what happens when the gemstone is collected, such as increasing the player's score or currency.
    {
        // Add functionality here, like increasing the player's score or currency
        isCollected = true;
        Debug.Log(name + " has been collected!");
    }

    // Function to display a visual effect when the collectible is collected
    public void DisplayEffect() 
    {
        // Add functionality here, like displaying a sparkle or a particle effect
        Debug.Log(name + " sparkles!");
    }

    // Function to update the properties of the collectible
    public void UpdateProperties()
    {
        // Add functionality here to update properties based on game conditions
        // For example, change color or value dynamically
        // This can be based on rarity or other factors
        Debug.Log("Updating properties of " + name);
    }


    //first function (Lesson 1/2)
    void HelloWorld()
    {
        Debug.Log(helloString);
    }


    // Start function | start is called before the first frame update
    void Start()
    {
        HelloWorld(); //call the HelloWorld() function
        isCollected = false; // Initialized as false when the object starts
        // Access the inherited member using base
        Debug.Log("Object name: " + base.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Access the inherited member using base
        Debug.Log("Object name: " + base.name);
    }
}
