using System;
using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public List<GameObject> characterGameObjects;

    private void Start()
    {
        RegisterAnimationManager();
    }

    public void SetTriggerAnimation(float characterIndex, string animationTrigger)
    {
        int index = Mathf.RoundToInt(characterIndex); 

        if (index >= 0 && index < characterGameObjects.Count)
        {
            Animator animator = characterGameObjects[index].GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetTrigger(animationTrigger);
            }
            else
            {
                Debug.LogWarning($"Animator not found on {characterGameObjects[index].name}");
            }
        }
    }

    public void ReturnToIdle()
    {
        foreach(GameObject character in characterGameObjects)
        {
            Animator animator = character.GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetTrigger("ExitScene");
                animator.SetTrigger("BecomeIdle");
            }
            else
            {
                Debug.LogWarning($"Animator not found on {character.name}");
            }
        }

    }
    public void ResetToIdle()
    {
        foreach(GameObject character in characterGameObjects)
        {
            Animator animator = character.GetComponent<Animator>();

            if (animator != null)
            {
                animator.SetTrigger("Reset");
            }
            else
            {
                Debug.LogWarning($"Animator not found on {character.name}");
            }
        }

    }
    private void RegisterAnimationManager()
    {
        Lua.RegisterFunction("SetCharacterAnimation", this, typeof(AnimationManager).GetMethod("SetTriggerAnimation"));
    }
}