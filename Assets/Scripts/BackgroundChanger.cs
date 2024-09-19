using UnityEngine;
using UnityEngine.UI;

/*
This script is used to change the background image during specific points in the dialogue by utilizing 
Lua commands in the Dialogue System by Pixel Crushers. 

The method ChangeBackground is called with an index passed as a string to select the corresponding background from an array of images. 
To trigger the background change during dialogue progression, use the Lua command in Dialogue Entry Sequence Field: 
SendMessage(ChangeBackground, 0, GameCanvas/Background)

------------------------------------------------------------------------------------------------------------------------------------------
Este script se utiliza para cambiar la imagen de fondo en puntos específicos del diálogo utilizando 
comandos Lua en el Dialogue System de Pixel Crushers.

El método ChangeBackground se llama con un índice pasado como cadena para seleccionar el fondo correspondiente de una matriz de imágenes. 
Para activar el cambio de fondo durante la progresión del diálogo, utiliza el comando Lua en el campo Dialogue Entry Sequence: 
SendMessage(ChangeBackground, 0, GameCanvas/Background)
*/

public class BackgroundChanger : MonoBehaviour
{
    public Image backgroundImage;
    public Sprite[] backgrounds;  

    public void ChangeBackground(string index) 
    {
        int bgIndex = int.Parse(index); 
        if (bgIndex >= 0 && bgIndex < backgrounds.Length)
        {
            backgroundImage.sprite = backgrounds[bgIndex];
        }
        else
        {
            Debug.LogWarning("Invalid background index: " + index);
        }
    }
}