using UnityEngine;

public class SpeedCollectible : Collectible
{
    public float speedIncreaseAmount = 2f; // Adjust as needed

    public override void Collected()
    {
        // Find the FirstPersonController attached to the player
        var playerController = FindObjectOfType<StarterAssets.FirstPersonController>();
        if (playerController != null)
        {
            // Increase player's movement speed
            playerController.MoveSpeed *= speedIncreaseAmount;
            playerController.SprintSpeed *= speedIncreaseAmount;

            Debug.Log("Player's speed increased!");
        }
    }
}
