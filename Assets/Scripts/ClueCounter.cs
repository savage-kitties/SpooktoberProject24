using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class ClueCounter : MonoBehaviour
{
     public int GetClueCount()
    {
        int count = 0;

        // Check each clue using Dialogue System variables
        if (DialogueLua.GetVariable("DuskClueA").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueB").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueC").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueD").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueE").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueF").AsBool) count++;
        if (DialogueLua.GetVariable("DuskClueG").AsBool) count++;

        return count;
    }
}
