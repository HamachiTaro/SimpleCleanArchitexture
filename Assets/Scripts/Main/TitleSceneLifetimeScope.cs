using Details.Controllers.Title;
using Domains.UseCases.Title;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class TitleSceneLifetimeScope : LifetimeScope
    {
        [SerializeField] private TitleUIController uiController;

        protected override void Configure(IContainerBuilder builder)
        {
            // アタッチされたコンポーネントからインターフェースを登録する
            builder.RegisterComponent(uiController).AsImplementedInterfaces();

            // エントリーポイント
            builder.RegisterEntryPoint<TitleMainUseCase>();
        }
    }
}