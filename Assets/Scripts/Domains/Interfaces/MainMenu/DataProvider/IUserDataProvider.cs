using System.Threading;
using Cysharp.Threading.Tasks;
using Data.ValueObjects;

namespace Domains.Interfaces.MainMenu.DataProvider
{
    /// <summary>
    /// ユーザーデータ取得
    /// </summary>
    public interface IUserDataProvider
    {
        UniTask<SomeUserData> LoadDataAsync(CancellationToken cancellationToken);
    }
}