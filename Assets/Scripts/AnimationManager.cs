using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public List<GameObject> characterGameObjects;

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
}