using Details.Common.Controllers;
using Domains.UseCases.Common;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class InGameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // ヒエラルキーにインスタンスがある場合の登録。
            builder.RegisterComponentInHierarchy<CommonBackController>().AsImplementedInterfaces();

            // エントリーポイント
            builder.RegisterEntryPoint<CommonBackMainMenuUseCase>();
        }
    }
}