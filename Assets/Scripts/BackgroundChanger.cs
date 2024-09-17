using UnityEngine;
using UnityEngine.UI;

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