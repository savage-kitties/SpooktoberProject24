using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu.Functionality
{
    public class SceneController : MonoBehaviour
    {
        [SerializeField] private GameObject pnlUtilityMenu;
        [SerializeField] private string firstSceneName;
        public string currentScene;
        public int currentSlot=0;
        string filename
        {
            get { return "SaveFile" + currentSlot + ".es3"; }
        }
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
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
        
        }

        public void SaveInCurrentSlot()
        {
            ES3.Save("Slot",currentSlot,filename);
            currentScene = SceneManager.GetActiveScene().name;
            ES3.Save("CurrentScene",currentScene,filename);
        }

        public void LoadSlot(int slotNumber)
        {
            currentSlot = slotNumber;
            if(!ES3.KeyExists("Slot", filename))
                return;
            currentScene=ES3.Load<string>("CurrentScene", filename);
            LoadNextScene(currentScene); 
        }

        public void SetUtilityMenuActive(bool active)
        {
            pnlUtilityMenu.SetActive(active);
        }
        
    }
}
