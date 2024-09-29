using System;
using FXManagement;
using UnityEngine;

namespace MainMenu.Functionality
{
    public class CurrentSceneMgr : MonoBehaviour
    {
        private SceneController _mainSceneController;
        private FXManager _fxManager;
        private void Awake()
        {
            _mainSceneController = GameObject.Find("CanvasSceneMngr").GetComponent<SceneController>();
            _mainSceneController.SetUtilityMenuActive(true);
            _mainSceneController.SaveInCurrentSlot();
            _fxManager.StopVFX("all");
            _fxManager.StopAmbientFX();
            _fxManager.StopImpactFX();
            _fxManager.StopSFX(); 
            _fxManager.StopStepsFX();
        }
    }
}
