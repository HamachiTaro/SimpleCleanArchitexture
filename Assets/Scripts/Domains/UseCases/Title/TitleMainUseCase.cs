using System;
using System.Threading;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UniRx;
using VContainer;
using VContainer.Unity;
using Domains.Interfaces.Title.Controllers;
using UnityEngine.SceneManagement;

namespace Domains.UseCases.Title
{
    /// <summary>
    /// ユーザーからの入力を受け取ったら次のシーンに遷移するためのユースケース
    /// ここに書くことが多くなった場合は別のユースケースにわけることを考える。
    /// </summary>
    public class TitleMainUseCase : IInitializable, IAsyncStartable, IDisposable
    {
        private readonly ITitleUIController _uiController;

        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        [Inject]
        public TitleMainUseCase(
            ITitleUIController uiController)
        {
            _uiController = uiController;
        }

        public void Initialize()
        {
            Debug.Log("Initialize...");
        }

        public void Dispose()
        {
            _disposable.Dispose();
        }

        public async UniTask StartAsync(CancellationToken cancellation)
        {
            // todo loadingを消去する

            await _uiController.OnNextSceneAsync(cancellation);

            //await SceneManager.LoadSceneAsync("").WithCancellation(cancellation);
            Debug.Log("シーン遷移");

            // todo loadingを表示する
        }
    }
}