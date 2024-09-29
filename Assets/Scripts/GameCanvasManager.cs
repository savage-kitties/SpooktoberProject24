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
    private VariableManager variableManagerInstance;
    private AnimationManager animationManagerInstance;
    
    void Start()
    {
        RegisterSpriteManager();
        RegisterGusCooperationMeasurement();
        RegisterMirellaCooperationMeasurement();
        RegisterSearchManager();
        RegisterVariableManager();
        RegisterAnimationManager();
        
    }

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

    private void RegisterVariableManager()
{
    GameObject variableManagerObject = GameObject.Find("Conversation");

    if (variableManagerObject != null)
    {
        variableManagerInstance = variableManagerObject.GetComponent<VariableManager>();

        if (variableManagerInstance != null)
        {
            Lua.RegisterFunction("GetBoolean", variableManagerInstance, typeof(VariableManager).GetMethod("GetBoolean"));
            Lua.RegisterFunction("SetBoolean", variableManagerInstance, typeof(VariableManager).GetMethod("SetBoolean"));
            Lua.RegisterFunction("CountClues", variableManagerInstance, typeof(VariableManager).GetMethod("CountClues"));
            //Debug.Log("GetBoolean and SetBoolean functions registered successfully.");
        }
        else
        {
            Debug.LogError("VariableManager component not found on VariableManager object!");
        }
    }
    else
    {
        Debug.LogError("VariableManager GameObject not found!");
    }
}
   
   private void RegisterAnimationManager()
    {
        GameObject animationManagerObject = GameObject.Find("SpriteManager");

        if (animationManagerObject != null)
        {
            animationManagerInstance = animationManagerObject.GetComponent<AnimationManager>();

            if (animationManagerInstance != null)
            {
                // Register the SetTriggerAnimation function for Lua
                Lua.RegisterFunction("SetCharacterAnimation", animationManagerInstance, typeof(AnimationManager).GetMethod("SetTriggerAnimation"));
            }
            else
            {
                Debug.LogError("AnimationManager component not found on AnimationManagerObject!");
            }
        }
        else
        {
            Debug.LogError("AnimationManager GameObject not found!");
        }
    }
}