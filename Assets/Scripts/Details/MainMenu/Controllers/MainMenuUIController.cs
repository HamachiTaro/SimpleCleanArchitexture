using System;
using Domains.Interfaces.MainMenu.Controller;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Details.MainMenu.Controllers
{
    public class MainMenuUIController : MonoBehaviour, IMainMenuUIController
    {
        [SerializeField] private Button buttonSetting;

        [SerializeField] private Button buttonInGame;

        public IObservable<Unit> OnTransitSettingAsObservable() => buttonSetting.OnClickAsObservable();

        public IObservable<Unit> OnTransitInGameAsObservable() => buttonInGame.OnClickAsObservable();
    }
}