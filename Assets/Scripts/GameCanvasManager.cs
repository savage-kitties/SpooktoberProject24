using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

/*
This script is attached to the GameCanvas gameObject. 
The script registers custom scripts with Lua at start(), allowing us to change sprites and manage cooperation levels for Gus and Mirella.
*/

public class GameCanvasManager : MonoBehaviour
{
    private SpriteChanger spriteChangerInstance;
    private GusCooperationMeasurement gusCooperationInstance;
    private MirellaCooperationMeasurement mirellaCooperationInstance;
    private SearchManager searchManagerInstance;

    void Start()
    {
        // Register the SpriteManager with Lua
        RegisterSpriteManager();

        // Register Gus and Mirella cooperation measurements with Lua
        RegisterGusCooperationMeasurement();
        RegisterMirellaCooperationMeasurement();

        // Register SearchManager with Lua
        RegisterSearchManager();

        
    }

    // Method to register SpriteManager functions to Lua
    private void RegisterSpriteManager()
    {
        GameObject spriteManagerObject = GameObject.Find("SpriteManager");

        if (spriteManagerObject != null)
        {
            spriteChangerInstance = spriteManagerObject.GetComponent<SpriteChanger>();

            if (spriteChangerInstance != null)
            {
                Lua.RegisterFunction("SpriteManager_ChangeSprite", spriteChangerInstance, typeof(SpriteChanger).GetMethod("ChangeSprite"));
            }
            else
            {
                Debug.LogError("SpriteChanger component not found on SpriteManager object!");
            }
        }
        else
        {
            Debug.LogError("SpriteManager GameObject not found!");
        }
    }

    // Method to register GusCooperationMeasurement functions to Lua
    private void RegisterGusCooperationMeasurement()
    {
        GameObject gusObject = GameObject.Find("SpriteManager/Gus");

        if (gusObject != null)
        {
            gusCooperationInstance = gusObject.GetComponent<GusCooperationMeasurement>();

            if (gusCooperationInstance != null)
            {
                Lua.RegisterFunction("ChangeGusCooperationLevel", gusCooperationInstance, typeof(GusCooperationMeasurement).GetMethod("ChangeCooperationLevel"));
                Lua.RegisterFunction("GetGusCooperationLevel", gusCooperationInstance, typeof(GusCooperationMeasurement).GetMethod("GetCooperationLevel"));
            }
            else
            {
                Debug.LogError("GusCooperationMeasurement component not found on Gus object!");
            }
        }
        else
        {
            Debug.LogError("Gus GameObject not found!");
        }
    }

    // Method to register MirellaCooperationMeasurement functions to Lua
    private void RegisterMirellaCooperationMeasurement()
    {
        GameObject mirellaObject = GameObject.Find("SpriteManager/Mirella");

        if (mirellaObject != null)
        {
            mirellaCooperationInstance = mirellaObject.GetComponent<MirellaCooperationMeasurement>();

            if (mirellaCooperationInstance != null)
            { 
                Lua.RegisterFunction("ChangeMirellaCooperationLevel", mirellaCooperationInstance, typeof(MirellaCooperationMeasurement).GetMethod("ChangeCooperationLevel"));
                Lua.RegisterFunction("GetMirellaCooperationLevel", mirellaCooperationInstance, typeof(MirellaCooperationMeasurement).GetMethod("GetCooperationLevel"));
            }
            else
            {
                Debug.LogError("MirellaCooperationMeasurement component not found on Mirella object!");
            }
        }
        else
        {
            Debug.LogError("Mirella GameObject not found!");
        }
    }

    private void RegisterSearchManager()
    {
        GameObject searchManagerObject = GameObject.Find("SpriteManager/Mirella");

        if (searchManagerObject != null)
        {
            searchManagerInstance = searchManagerObject.GetComponent<SearchManager>();

            if (searchManagerInstance != null)
            {
                Lua.RegisterFunction("SetAllowedSearches", searchManagerInstance, typeof(SearchManager).GetMethod("SetAllowedSearches"));
                Lua.RegisterFunction("ReduceAllowedSearches", searchManagerInstance, typeof(SearchManager).GetMethod("ReduceAllowedSearches"));
                Lua.RegisterFunction("HasSearchesLeft", searchManagerInstance, typeof(SearchManager).GetMethod("HasSearchesLeft"));
            }
            else
            {
                Debug.LogError("SearchManager component not found on SearchManager object!");
            }
        }
        else
        {
            Debug.LogError("SearchManager GameObject not found!");
        }
    }
}