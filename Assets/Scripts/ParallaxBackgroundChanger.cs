using UnityEngine;

/*
This script is used to change the background GameObject during specific points in the dialogue 
by utilizing Lua commands in the Dialogue System by Pixel Crushers.

The method ChangeBackground is called with an index passed as a string to select the corresponding background 
from an array of GameObjects. 

To trigger the background change during dialogue progression, use the Lua command in the Dialogue Entry Sequence Field: 
SendMessage(ChangeBackground, 0, GameCanvas/ParallaxBackground)

------------------------------------------------------------------------------------------------------------------------------------
Este script se utiliza para cambiar el GameObject de fondo en puntos específicos del diálogo 
utilizando comandos Lua en el Dialogue System de Pixel Crushers.

El método ChangeBackground se llama con un índice pasado como cadena para seleccionar el fondo correspondiente de una matriz de GameObjects. 
Para activar el cambio de fondo durante la progresión del diálogo, utiliza el comando Lua en el campo Dialogue Entry Sequence: 
SendMessage(ChangeBackground, 0, GameCanvas/ParallaxBackground)
*/

public class ParallaxBackgroundChanger : MonoBehaviour
{
    public GameObject[] backgrounds;

    public void ChangeBackground(string index) 
    {
        int bgIndex = int.Parse(index); 
        if (bgIndex >= 0 && bgIndex < backgrounds.Length)
        {
            // Disable any active background
            foreach (GameObject bg in backgrounds)
            {
                bg.SetActive(false);
            }
            
            // Activate the selected background
            backgrounds[bgIndex].SetActive(true);
        }
        else
        {
            Debug.LogWarning("Invalid parallax background index: " + index);
        }
    }
}