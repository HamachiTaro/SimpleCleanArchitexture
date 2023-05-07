using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.Common.Controllers;
using Domains.Interfaces.Common.Presenters;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace Domains.UseCases.Common
{
    public class CommonBackMainMenuUseCase : IInitializable, IAsyncStartable, IDisposable
    {
        private readonly ICommonBackController _backController;
        private readonly ICommonLoadingPresenter _commonLoadingPresenter;

        public CommonBackMainMenuUseCase(
            ICommonBackController backController,
            ICommonLoadingPresenter commonLoadingPresenter)
        {
            _backController = backController;
            _commonLoadingPresenter = commonLoadingPresenter;
        }

        public void Dispose()
        {
            Debug.Log($"{this}.Dispose");
        }

        public void Initialize()
        {
            Debug.Log($"{this}.Initialize");
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            await _backController.BackAsync(cancellation);
            
            await _commonLoadingPresenter.ShowAsync(cancellation);
            
            await SceneManager.LoadSceneAsync("Scenes/MainMenuScene").WithCancellation(cancellation);
        }
    }
}