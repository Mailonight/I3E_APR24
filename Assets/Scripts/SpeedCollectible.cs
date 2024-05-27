using UnityEngine;

public class SpeedCollectible : Collectible
{
    public float speedIncreaseAmount = 2f; // Adjust as needed

    public override void Collected()
    {
        Debug.Log("Speed collectible collected."); // Check if this log is shown
        // Find the FirstPersonController attached to the player
        var playerController = FindObjectOfType<StarterAssets.FirstPersonController>();
        if (playerController != null)
        {
            Debug.Log("Player controller found."); // Check if this log is shown
                                                   // Increase player's movement speed
            playerController.MoveSpeed *= speedIncreaseAmount;
            playerController.SprintSpeed *= speedIncreaseAmount;

            Debug.Log("Player's speed increased!");
        }
        else
        {
            Debug.LogError("Player controller not found!"); // Check if this log is shown
        }
    }
}
