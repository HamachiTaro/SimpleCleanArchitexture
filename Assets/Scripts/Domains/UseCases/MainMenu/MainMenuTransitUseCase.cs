using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.MainMenu.Controller;
using UniRx;
using UnityEngine.SceneManagement;
using VContainer;
using VContainer.Unity;

namespace Domains.UseCases.MainMenu
{
    /// <summary>
    /// メインメニューのシーン遷移を管理するユースケース
    /// </summary>
    public class MainMenuTransitUseCase : IStartable, IDisposable
    {
        private const string SettingScene = "Scenes/SettingScene";
        private const string InGameScene = "Scenes/InGameScene";
        
        private readonly IMainMenuUIController _uiController;

        private readonly CompositeDisposable _disposable;
        private readonly CancellationTokenSource _cts;

        [Inject]
        public MainMenuTransitUseCase(
            IMainMenuUIController uiController)
        {
            _uiController = uiController;
            
            _disposable = new CompositeDisposable();
            _cts = new CancellationTokenSource();
        }

        public void Start()
        {
            var token = _cts.Token;
            
            _uiController.OnTransitSettingAsObservable()
                .Subscribe(_ => TransitAsync(SettingScene, token).Forget())
                .AddTo(_disposable);

            _uiController.OnTransitInGameAsObservable()
                .Subscribe(_ => TransitAsync(InGameScene, token).Forget())
                .AddTo(_disposable);
        }

        public void Dispose()
        {
            _disposable.Dispose();
            _cts.Cancel();
            _cts.Dispose();
        }

        private async UniTaskVoid TransitAsync(string sceneName, CancellationToken token)
        {
            // todo ローディング表示

            await SceneManager.LoadSceneAsync(sceneName).WithCancellation(token);
        }
    }
}