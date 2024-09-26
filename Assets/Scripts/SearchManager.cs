using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class SearchManager : MonoBehaviour
{
    // Reference to the MirellaCooperationMeasurement script
    public MirellaCooperationMeasurement mirellaCooperation;

    // Variable to track the allowed searches
    private int allowedSearches = 0;

    void Start()
    {
        SetAllowedSearches();
    }

    // Function to set allowed searches based on Mirella's cooperation level
    public void SetAllowedSearches()
    {
        int cooperationLevel = mirellaCooperation.GetCooperationLevel();

        if (cooperationLevel >= 1)
        {
            allowedSearches = 3;  // Positive cooperation level: 3 searches allowed
        }
        else if (cooperationLevel == 0)
        {
            allowedSearches = 2;  // Neutral cooperation level: 2 searches allowed
        }
        else
        {
            allowedSearches = 1;  // Negative cooperation level: 1 search allowed
        }
        DialogueLua.SetVariable("AllowedSearches", allowedSearches);
        Debug.Log("Allowed Searches: " + allowedSearches);
    }

    // Function to reduce the allowed searches after each search
    public void ReduceAllowedSearches()
    {
        allowedSearches = Mathf.Max(allowedSearches - 1, 0); // Ensure it doesn't go below 0
        DialogueLua.SetVariable("AllowedSearches", allowedSearches);
        Debug.Log("Remaining Searches: " + allowedSearches);
    }

    // Function to check if there are any allowed searches left
    public bool HasSearchesLeft()
    {
        //Debug.Log("Remaining Searches: " + allowedSearches);
        return allowedSearches > 0;
    }
}