using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

/*
This script is attached to the GameCanvas gameObject. 
The script registers a custom scirpt with Lua at start(), allowing us to change sprites
*/
public class GameCanvasManager : MonoBehaviour
{
     private SpriteChanger spriteChangerInstance;

    void Start()
    {
        // Find the GameObject with the SpriteChanger script attached
        GameObject spriteManagerObject = GameObject.Find("SpriteManager");
        
        if (spriteManagerObject != null)
        {
            spriteChangerInstance = spriteManagerObject.GetComponent<SpriteChanger>();

            if (spriteChangerInstance != null)
            {
                // Register the ChangeSprite method with Lua
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
}
