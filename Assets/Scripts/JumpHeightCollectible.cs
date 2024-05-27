using StarterAssets;
using UnityEngine;

public class JumpHeightCollectible : Collectible
{
    public float jumpHeightIncreaseAmount = 1.0f; // Adjust as needed

    public override void Collected()
    {
        // Find the FirstPersonController attached to the player
        FirstPersonController playerController = FindObjectOfType<FirstPersonController>();

        // Increase player's jump height
        if (playerController != null)
        {
            // Adjust jump height
            playerController.JumpHeight += jumpHeightIncreaseAmount;
        }
    }
}
