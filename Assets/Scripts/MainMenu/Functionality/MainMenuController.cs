using FXManagement;
using UnityEngine;

namespace MainMenu.Functionality
{
    public class MainMenuController : MonoBehaviour
    {
        private GameObject sceneMngr;
        private void Start()
        {
            sceneMngr = GameObject.Find("CanvasSceneMngr");
            
        }
        public void SelectSound()
        {
            FXManager fxManager = sceneMngr.GetComponent<FXManager>();
            fxManager.PlayUIFX("Select"); 
        }
        public void ClickSound()
        {
           FXManager fxManager = sceneMngr.GetComponent<FXManager>();
           fxManager.PlayUIFX("Open"); 
        }
        public void ReturnSound()
        {
            FXManager fxManager = sceneMngr.GetComponent<FXManager>();
            fxManager.PlayUIFX("Close"); 
        }
        public void ExitSound()
        {
            FXManager fxManager = sceneMngr.GetComponent<FXManager>();
            fxManager.PlayUIFX("Exit"); 
        }
        public void CreditsSound()
        {
            FXManager fxManager = sceneMngr.GetComponent<FXManager>();
            fxManager.StopVFX("all");
            fxManager.StopAmbientFX();
            fxManager.StopImpactFX();
            fxManager.StopSFX(); 
            fxManager.StopStepsFX();
            fxManager.PlayUIFX("Open");
        }
        public void ReturnFromCreditsSound()
        {
            FXManager fxManager = sceneMngr.GetComponent<FXManager>();
            fxManager.PlayAmbientFX("Leaves");
            fxManager.PlayStepsFX("Forest");
            fxManager.PlayVFX("inicio");
            fxManager.PlayUIFX("Close");
        }

        public void LoadFromStart(int slot)
        {
            SceneController sceneController = sceneMngr.GetComponent<SceneController>();
            sceneController.LoadFirstScene(slot);
        }
        public void LoadFromSlot(int slot)
        {
            SceneController sceneController = sceneMngr.GetComponent<SceneController>();
            sceneController.LoadSlot(slot);
        }

        public void ExitGame()
        {
            SceneController sceneController = sceneMngr.GetComponent<SceneController>();
            sceneController.ExitGame();
        }
    }
}
