using Details.Common.Controllers;
using Details.Common.Presenters;
using Domains.UseCases.Common;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class SettingLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // ヒエラルキーにインスタンスがある場合の登録。
            builder.RegisterComponentInHierarchy<CommonBackController>().AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<CommonLoadingPresenter>().AsImplementedInterfaces();

            // エントリーポイント
            builder.RegisterEntryPoint<CommonBackMainMenuUseCase>();
        }
    }
}