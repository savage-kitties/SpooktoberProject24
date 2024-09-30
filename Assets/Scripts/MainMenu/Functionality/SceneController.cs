using System;
using FXManagement;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu.Functionality
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private GameObject pnlUtilityMenu;
        [SerializeField] private string firstSceneName;
        [SerializeField] private GameObject panelExitGame;
        [SerializeField] private GameObject utilityMenu;
        [SerializeField] private GameObject utilityMenuHider;
        [SerializeField] private GameObject vfxs;
        [SerializeField] private GameObject vfxCamera;
        [SerializeField] private VariableManager variableManager;
        [SerializeField] private  GameObject gameCanvasUi;
        [SerializeField] private AnimationManager animationManager;
        public string currentScene;
        public int currentSlot=0;
        private FXManager _fxManager; 
        string filename
        {
            get { return "SaveFile" + currentSlot + ".es3"; }
        }
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(vfxs);
            DontDestroyOnLoad(vfxCamera);
            DontDestroyOnLoad(gameCanvasUi);
        }

        private void Start()
        {
            SetUtilityMenuActive(false);
            _fxManager = GetComponent<FXManager>();
            _fxManager.StopVFX("all");
            _fxManager.StopAmbientFX();
            _fxManager.StopImpactFX();
            _fxManager.StopSFX(); 
            _fxManager.StopStepsFX();
            _fxManager = GetComponent<FXManager>();
            _fxManager.PlayAmbientFX("Leaves");
            _fxManager.PlayStepsFX("Forest");
            _fxManager.PlayVFX("inicio");
            RegisterLoadMainMenu();
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void LoadNextScene(string sceneName)
        {
       
            SceneManager.LoadScene(sceneName);
        
        }
        public void LoadFirstScene(int slotNumber)
        {
       
            SceneManager.LoadScene(firstSceneName);
            currentSlot = slotNumber;
            
        }
        public void LoadMainMenu()
        {
            Destroy(GameObject.Find("Dialogue Manager"));
            SetUtilityMenuActive(false);
            SceneManager.LoadScene("MainMenu");
            
            Destroy(vfxs);
            Destroy(vfxCamera);
            Destroy(gameCanvasUi);
            Destroy(this.gameObject); 
        
        }

        public void SaveInCurrentSlot()
        {
            ES3.Save("Slot",currentSlot,filename);
            currentScene = SceneManager.GetActiveScene().name;
            ES3.Save("CurrentScene",currentScene,filename);
            
            ES3.Save("MirellaInteraction",variableManager.GetBoolean("MirellaInteraction"),filename);
            ES3.Save("GusInteraction",variableManager.GetBoolean("GusInteraction"),filename);
             
            ES3.Save("DuskClueA",variableManager.GetBoolean("DuskClueA"),filename);
            ES3.Save("DuskClueB",variableManager.GetBoolean("DuskClueB"),filename);
            ES3.Save("DuskClueC",variableManager.GetBoolean("DuskClueC"),filename);
            ES3.Save("DuskClueD",variableManager.GetBoolean("DuskClueD"),filename);
            ES3.Save("DuskClueE",variableManager.GetBoolean("DuskClueE"),filename);
            ES3.Save("DuskClueF",variableManager.GetBoolean("DuskClueF"),filename);
            ES3.Save("DuskClueG",variableManager.GetBoolean("DuskClueG"),filename);

            

            // Track Mirella Clues
            ES3.Save("MirellaClueA",variableManager.GetBoolean("MirellaClueA"),filename);
            ES3.Save("MirellaClueB",variableManager.GetBoolean("MirellaClueB"),filename);
            ES3.Save("MirellaClueC",variableManager.GetBoolean("MirellaClueC"),filename);
     


            // Track Gus Clues
            ES3.Save("GusClueA",variableManager.GetBoolean("GusClueA"),filename);
            ES3.Save("GusClueB",variableManager.GetBoolean("GusClueB"),filename);
            ES3.Save("GusClueC",variableManager.GetBoolean("GusClueC"),filename);

            // Track Searches Performed in Mirella's Boutique
            ES3.Save("SearchedBoutiqueA",variableManager.GetBoolean("SearchedBoutiqueA"),filename);
            ES3.Save("SearchedBoutiqueB",variableManager.GetBoolean("SearchedBoutiqueB"),filename);
            ES3.Save("SearchedBoutiqueC",variableManager.GetBoolean("SearchedBoutiqueC"),filename);
            ES3.Save("SearchedBoutiqueD",variableManager.GetBoolean("SearchedBoutiqueD"),filename);
        }

        public void LoadSlot(int slotNumber)
        {
            currentSlot = slotNumber;
            if(!ES3.KeyExists("Slot", filename))
                return;
            currentScene=ES3.Load<string>("CurrentScene", filename);
            variableManager.SetBoolean("MirellaInteraction",ES3.Load<bool>("MirellaInteraction",filename));
            variableManager.SetBoolean("GusInteraction",ES3.Load<bool>("GusInteraction",filename));
            variableManager.SetBoolean("DuskClueA",ES3.Load<bool>("DuskClueA",filename));
            variableManager.SetBoolean("DuskClueB",ES3.Load<bool>("DuskClueB",filename));
            variableManager.SetBoolean("DuskClueC",ES3.Load<bool>("DuskClueC",filename));
            variableManager.SetBoolean("DuskClueD",ES3.Load<bool>("DuskClueD",filename));
            variableManager.SetBoolean("DuskClueE",ES3.Load<bool>("DuskClueE",filename));
            variableManager.SetBoolean("DuskClueF",ES3.Load<bool>("DuskClueF",filename));
            variableManager.SetBoolean("DuskClueG",ES3.Load<bool>("DuskClueG",filename));

            

            variableManager.SetBoolean("MirellaClueA",ES3.Load<bool>("MirellaClueA",filename));
            variableManager.SetBoolean("MirellaClueB",ES3.Load<bool>("MirellaClueB",filename));
            variableManager.SetBoolean("MirellaClueC",ES3.Load<bool>("MirellaClueC",filename));
     


            variableManager.SetBoolean("GusClueA",ES3.Load<bool>("GusClueA",filename));
            variableManager.SetBoolean("GusClueB",ES3.Load<bool>("GusClueB",filename));
            variableManager.SetBoolean("GusClueC",ES3.Load<bool>("GusClueC",filename));
     

            variableManager.SetBoolean("SearchedBoutiqueA",ES3.Load<bool>("SearchedBoutiqueA",filename));
            variableManager.SetBoolean("SearchedBoutiqueB",ES3.Load<bool>("SearchedBoutiqueB",filename));
            variableManager.SetBoolean("SearchedBoutiqueC",ES3.Load<bool>("SearchedBoutiqueC",filename));
            variableManager.SetBoolean("SearchedBoutiqueD",ES3.Load<bool>("SearchedBoutiqueD",filename));
            LoadNextScene(currentScene); 
            
        }

        public void LoadLastCheckpoint()
        {
            LoadSlot(currentSlot);
        }

        public bool GetSlotOccupancy(int slotNumber)
        {
            currentSlot = slotNumber;
            if (ES3.KeyExists("Slot", filename))
            {
                return true;
            }

            return false;
        }
        public string GetSlotSceneName(int slotNumber)
        {
            currentSlot = slotNumber;
            return (ES3.Load<string>("CurrentScene", filename));
        }
        public void SetUtilityMenuActive(bool active)
        {
            panelExitGame.SetActive(false);
            utilityMenu.SetActive(false);
            utilityMenuHider.SetActive(true);
            pnlUtilityMenu.SetActive(active);
            
        }
        private void RegisterLoadMainMenu()
        {
            Lua.RegisterFunction("LoadMainMenu", this, typeof(SceneController).GetMethod("LoadMainMenu"));
        }

        public void ReturnToIdle()
        {
            animationManager.ReturnToIdle();
        }
    }
}
