using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.MainMenu.DataProvider;
using Domains.Interfaces.MainMenu.Presenter;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Domains.UseCases.MainMenu
{
    /// <summary>
    /// MainMenuの初期化。
    /// 必要なデータのロード、Viewの構築を行ってローディングを非表示にする。
    /// </summary>
    public class MainMenuInitializeUseCase : IInitializable, IAsyncStartable, IDisposable
    {
        private readonly IUserDataProvider _userDataProvider;
        private readonly IMainMenuUIPresenter _mainMenuUIPresenter;

        [Inject]
        public MainMenuInitializeUseCase(
            IUserDataProvider userDataProvider,
            IMainMenuUIPresenter mainMenuUIPresenter)
        {
            _userDataProvider = userDataProvider;
            _mainMenuUIPresenter = mainMenuUIPresenter;
        }

        public void Initialize()
        {
            Debug.Log("Initialize");
        }

        public void Dispose()
        {
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            var userData = await _userDataProvider.LoadDataAsync(cancellation);

            _mainMenuUIPresenter.DisplayUseName(userData.name);

            // todo loadingを非表示
        }
    }
}