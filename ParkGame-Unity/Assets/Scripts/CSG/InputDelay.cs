using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDelay : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DelayEnablePlayerInput());
    }

    IEnumerator DelayEnablePlayerInput()
    {
        // Log when the coroutine starts
        Debug.Log("Starting coroutine to disable PlayerInput");

        var playerInput = FindObjectOfType<PlayerInput>();

        // Check if PlayerInput was found
        if (playerInput != null)
        {
            Debug.Log("PlayerInput found, disabling...");
            playerInput.enabled = false;

            // Wait for a short period to allow other UI inputs
            yield return new WaitForSeconds(0.1f);  

            Debug.Log("Re-enabling PlayerInput...");
            playerInput.enabled = true;  
        }
        else
        {
            Debug.LogError("PlayerInput component not found in the scene!");
        }//end if(playerInput != null)
    }//end DelayEnablePlayerInput()
}//end 