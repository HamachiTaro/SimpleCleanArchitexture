using Domains.Interfaces.MainMenu.Presenter;
using TMPro;
using UnityEngine;

namespace Details.MainMenu.Presenters
{
    public class MainMenuUIPresenter : MonoBehaviour, IMainMenuUIPresenter
    {
        [SerializeField] private TextMeshProUGUI textUserName;

        public void DisplayUseName(string name)
        {
            textUserName.text = $"UserName : {name}";
        }
    }
}