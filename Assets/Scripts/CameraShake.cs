using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Feedbacks;
using PixelCrushers.DialogueSystem;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private MMPositionShaker shaker;

    void Start()
    {
        // Search for the GameObject called "GameCanvas"
        GameObject gameCanvas = GameObject.Find("GameCanvas");

        // Check if the GameCanvas object exists and has the MMPositionShaker component
        if (gameCanvas != null)
        {
            shaker = gameCanvas.GetComponent<MMPositionShaker>();

            if (shaker != null)
            {
                Debug.Log("MMPositionShaker found on GameCanvas.");
            }
            else
            {
                Debug.LogWarning("MMPositionShaker component not found on GameCanvas.");
            }
        }
        else
        {
            Debug.LogError("GameCanvas object not found in the scene");
        }

        RegisterCameraShakeLuaFunction();
    }

    public void StartShaking()
    {
        StartCoroutine(DelayedShake(1f)); // Delay of 1.5 seconds
    }

    private IEnumerator DelayedShake(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (shaker != null)
        {
            shaker.StartShaking();
        }
        else
        {
            Debug.LogWarning("Shaker not assigned");
        }
    }

    private void RegisterCameraShakeLuaFunction()
    {
        Lua.RegisterFunction("ShakeCamera", this, typeof(CameraShake).GetMethod("StartShaking"));
    }

}