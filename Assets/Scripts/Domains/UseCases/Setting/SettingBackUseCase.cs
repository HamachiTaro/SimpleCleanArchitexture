using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.Common.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace Domains.UseCases.Setting
{
    public class SettingBackUseCase : IInitializable, IAsyncStartable, IDisposable
    {
        private readonly ICommonBackController _backController;

        public SettingBackUseCase(
            ICommonBackController backController)
        {
            _backController = backController;
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

            // todo ローディング表示
            
            await SceneManager.LoadSceneAsync("Scenes/MainMenuScene").WithCancellation(cancellation);
        }
    }
}