using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenu.Functionality
{
    public class SaveSlotMgr : MonoBehaviour
    {
        private Image _button;
        private SceneController _sceneController;
        [SerializeField] private int slotNumber;
        [SerializeField] private TextMeshProUGUI text;

        private void Start()
        {
            _button= GetComponent<Image>();
            _sceneController = GameObject.Find("CanvasSceneMngr").GetComponent<SceneController>();
            SetSlotStatus();
        }

        private void SetSlotStatus()
        {
            if (_sceneController.GetSlotOccupancy(slotNumber))
            {
                _button.color = new Color(0.5764f,0.5098f,0.4980f);
                text.text = _sceneController.GetSlotSceneName(slotNumber);
            }
            else
            {
                _button.color = Color.white;
                text.text = "Empty Slot";
            }
        }
    }
}
