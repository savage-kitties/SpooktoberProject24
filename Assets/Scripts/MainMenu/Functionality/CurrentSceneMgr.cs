using System;
using UnityEngine;

namespace MainMenu.Functionality
{
    public class CurrentSceneMgr : MonoBehaviour
    {
        private SceneController _mainSceneController;
        private void Awake()
        {
            _mainSceneController = GameObject.Find("CanvasSceneMngr").GetComponent<SceneController>();
            _mainSceneController.SetUtilityMenuActive(true);
            _mainSceneController.SaveInCurrentSlot();
        }
    }
}
