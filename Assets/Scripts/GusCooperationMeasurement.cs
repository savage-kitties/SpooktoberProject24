using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GusCooperationMeasurement : MonoBehaviour
{
    public int cooperationLevel = 0;  // Initial cooperation level
    private const int minCooperation = -2;
    private const int maxCooperation = 2;

    // Function to change the cooperation level
    public void ChangeCooperationLevel(float change)
    {
    // Cast float to int 
    int intChange = Mathf.RoundToInt(change);
    cooperationLevel += intChange;

    // Clamp the value between -2 and 2
    cooperationLevel = Mathf.Clamp(cooperationLevel, -2, 2);
    Debug.Log("Gus Cooperation Level: " + cooperationLevel);
    }

    // Function to get the cooperation level
    public int GetCooperationLevel()
    {
        Debug.Log("Gus's cooperation level: " + cooperationLevel);
        return cooperationLevel;
    }
}
