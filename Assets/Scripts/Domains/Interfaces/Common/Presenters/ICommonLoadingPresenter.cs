using System.Threading;
using Cysharp.Threading.Tasks;

namespace Domains.Interfaces.Common.Presenters
{
    public interface ICommonLoadingPresenter
    {
        /// <summary>
        /// ローディングを表示。非同期版。
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        UniTask ShowAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// ローディングを隠す。非同期版
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        UniTask HideAsync(CancellationToken cancellationToken);

        /// <summary>
        /// ローディングを表示。
        /// </summary>
        void Show();
        
        /// <summary>
        /// ローディングを非表示。
        /// </summary>
        void Hide();
    }
}