using System.Collections.Generic;
using UnityEngine;

public class VariableManager : MonoBehaviour
{
    // Dictionary to store all boolean variables
    private Dictionary<string, bool> variableDictionary = new Dictionary<string, bool>();

    void Start()
    {
        // Track all Interactions
        variableDictionary["MirellaInteraction"] = false;
        variableDictionary["GusInteraction"] = false;

        // Track the Dusk Clues
        variableDictionary["DuskClueA"] = false;
        variableDictionary["DuskClueB"] = false;
        variableDictionary["DuskClueC"] = false;
        variableDictionary["DuskClueD"] = false;
        variableDictionary["DuskClueE"] = false;
        variableDictionary["DuskClueF"] = false;
        variableDictionary["DuskClueG"] = false;

        // Track Mirella Clues
        variableDictionary["MirellaClueA"] = false;
        variableDictionary["MirellaClueB"] = false;
        variableDictionary["MirellaClueC"] = false;

        // Track Gus Clues
        variableDictionary["GusClueA"] = false;
        variableDictionary["GusClueB"] = false;
        variableDictionary["GusClueC"] = false;

        // Track Searches Performed in Mirella's Boutique
        variableDictionary["SearchedBoutiqueA"] = false;
        variableDictionary["SearchedBoutiqueB"] = false;
        variableDictionary["SearchedBoutiqueC"] = false;
        variableDictionary["SearchedBoutiqueD"] = false;
    }

    // Method to get a boolean value
    public bool GetBoolean(string variableName)
    {
        if (variableDictionary.ContainsKey(variableName))
        {
            Debug.Log($"[VariableManager] GetBoolean called: {variableName} = {variableDictionary[variableName]}");
            return variableDictionary[variableName];
        }
        else
        {
            Debug.LogWarning($"[VariableManager] GetBoolean called: Variable '{variableName}' not found.");
            return false;
        }
    }

    // Method to set a boolean value
    public void SetBoolean(string variableName, bool value)
    {
        if (variableDictionary.ContainsKey(variableName))
        {
            variableDictionary[variableName] = value;
            Debug.Log($"[VariableManager] SetBoolean called: {variableName} set to {value}");
        }
        else
        {
            Debug.LogWarning($"[VariableManager] SetBoolean called: Variable '{variableName}' not found in VariableManager.");
        }
    }

    // Method to count clues for a given prefix (e.g., "DuskClue")
    public int CountClues(string cluePrefix)
    {
        int count = 0;
        foreach (var variable in variableDictionary)
        {
            if (variable.Key.StartsWith(cluePrefix) && variable.Value)
            {
                count++;
            }
        }
        Debug.Log($"[VariableManager] CountClues called: {count} clues found with prefix '{cluePrefix}'");
        return count;
    }
}