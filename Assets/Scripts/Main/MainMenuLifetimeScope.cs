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
            
            // エントリーポイント
            builder.RegisterEntryPoint<MainMenuInitializeUseCase>();
        }
    }
}