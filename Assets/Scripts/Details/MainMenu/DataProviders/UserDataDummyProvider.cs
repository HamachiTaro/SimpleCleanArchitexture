using System.Threading;
using Cysharp.Threading.Tasks;
using Data.ValueObjects;
using Domains.Interfaces.MainMenu.DataProvider;

namespace Details.MainMenu.DataProviders
{
    /// <summary>
    /// 偽のユーザーデータ取得
    /// </summary>
    public class UserDataDummyProvider : IUserDataProvider
    {
        public async UniTask<SomeUserData> LoadDataAsync(CancellationToken cancellationToken)
        {
            await UniTask.Delay(300, cancellationToken: cancellationToken);

            var userData = new SomeUserData(27589, "Nick");
            return userData;
        }
    }
}