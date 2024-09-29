using System;
using System.Collections;
using System.Collections.Generic;
using FXManagement;
using UnityEngine;

public class MirellaCooperationMeasurement : MonoBehaviour
{
    public int cooperationLevel = 0;  // Initial cooperation level
    private const int minCooperation = -2;
    private const int maxCooperation = 2;
    private FXManager _fxManager;

    private void Start()
    {
        _fxManager = GameObject.Find("CanvasSceneMngr").GetComponent<FXManager>();
    }

    // Function to change the cooperation level
     public void ChangeCooperationLevel(float change)
    {
    // Cast float to int 
    int intChange = Mathf.RoundToInt(change);
    cooperationLevel += intChange;

    // Clamp the value between -2 and 2
    cooperationLevel = Mathf.Clamp(cooperationLevel, -2, 2);
    Debug.Log("Mirella Cooperation Level: " + cooperationLevel);
    if (_fxManager)
    {
        if (change > 0)
        {
            _fxManager.PlayVFX("moreCooperation");
            _fxManager.PlayUIFX("Positive");
        }
        else if (change < 0)
        {
            _fxManager.PlayVFX("lessCooperation");
            _fxManager.PlayUIFX("Negative");
        }
    }
    }

    // Function to get the cooperation level
    public int GetCooperationLevel()
    {
        Debug.Log("Mirella Cooperation Level: " + cooperationLevel);
        return cooperationLevel;
    }
}
