using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;

namespace Domains.Interfaces.Title.Controllers
{
    public interface ITitleUIController
    {
        /// <summary>
        /// 次のシーンへの遷移通知
        /// </summary>
        /// <returns></returns>
        public IObservable<Unit> OnNextSceneAsObservable();

        /// <summary>
        /// 次のシーンへの遷移通知.UniTask版
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public UniTask OnNextSceneAsync(CancellationToken cancellationToken);
    }
}