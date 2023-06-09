using Details.Common.Presenters;
using Details.MainMenu.Controllers;
using Details.MainMenu.DataProviders;
using Details.MainMenu.Presenters;
using Domains.Interfaces.MainMenu.DataProvider;
using Domains.UseCases.MainMenu;
using VContainer;
using VContainer.Unity;

namespace Main
{
    public class MainMenuLifetimeScope : LifetimeScope
    {
        
        protected override void Configure(IContainerBuilder builder)
        {
            // ヒエラルキー上にインスタンスがない場合の登録。
            builder.Register<IUserDataProvider, UserDataDummyProvider>(Lifetime.Singleton);
            
            // ヒエラルキーにインスタンスがある場合の登録。
            builder.RegisterComponentInHierarchy<MainMenuUIPresenter>().AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<MainMenuUIController>().AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<CommonLoadingPresenter>().AsImplementedInterfaces();
            
            // エントリーポイント
            builder.RegisterEntryPoint<MainMenuInitializeUseCase>();
            builder.RegisterEntryPoint<MainMenuTransitUseCase>();
        }
    }
}