using FXManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace MainMenu.Functionality
{
    public class PanelUtilitysHide : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        
        [SerializeField] private GameObject utilityMenu;
        [SerializeField] private GameObject utilityMenuHider;
        [SerializeField] private FXManager fxManager;
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            utilityMenu.SetActive(true);
            utilityMenuHider.SetActive(false);
            fxManager.PlayUIFX("Open");
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            utilityMenu.SetActive(false);
            utilityMenuHider.SetActive(true);
            fxManager.PlayUIFX("Close");
        }
    }
}
