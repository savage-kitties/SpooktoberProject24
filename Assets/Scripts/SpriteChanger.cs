using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This script is used to change the sprite of specific actors during dialogue sequences.

The `ChangeSprite` method takes two parameters: the actor's name and the sprite index. It locates the actor by name, 
then changes the displayed sprite to the one found at the specified index in the actor's sprite array.

To trigger the sprite change during dialogue, use a Lua command in the Dialogue System's Script field like this:
SpriteManager_ChangeSprite("ActorName", "0")
SpriteManager_ChangeSprite("NPC", "2")
SpriteManager_ChangeSprite("Player", "0")

Replace "ActorName" with the name of the actor and "0" with the desired sprite index to display.
This will dynamically change the actor's sprite based on their in-game actions or dialogue context.

------------------------------------------------------------------------------------------------------------------------------------------
Este script se utiliza para cambiar el sprite de actores específicos durante las secuencias de diálogo.

El método `ChangeSprite` toma dos parámetros: el nombre del actor y el índice del sprite. Localiza al actor por su nombre,
y luego cambia el sprite mostrado al que se encuentra en el índice especificado en el arreglo de sprites del actor.

Para activar el cambio de sprite durante el diálogo, usa un comando Lua en el campo Script del Dialogue System de esta manera:
SpriteManager_ChangeSprite("ActorName", "0")
SpriteManager_ChangeSprite("NPC", "2")
SpriteManager_ChangeSprite("Player", "0")

Reemplaza "ActorName" con el nombre del actor y "0" con el índice del sprite que deseas mostrar.
Esto cambiará dinámicamente el sprite del actor según sus acciones o el contexto del diálogo en el juego.

*/

public class SpriteChanger : MonoBehaviour
{
    [System.Serializable]
    public class Actor
    {
        public string actorName; // Name of the actor
        public Image spriteImage; // Actor's Image component
        public Sprite[] sprites;  // Actor's sprites
    }

    public Actor[] actors; // Array to hold all actors

    public void ChangeSprite(string actorName, string index)
    {
        foreach (Actor actor in actors)
        {
            if (actor.actorName == actorName) // Find the actor by name
            {
                int spriteIndex = int.Parse(index); 
                if (spriteIndex >= 0 && spriteIndex < actor.sprites.Length)
                {
                    actor.spriteImage.sprite = actor.sprites[spriteIndex];
                }
                else
                {
                    Debug.LogWarning("Invalid sprite index: " + index);
                }
                return; // Exit after finding the actor
            }
        }
        Debug.LogWarning("Actor not found: " + actorName);
    }
}