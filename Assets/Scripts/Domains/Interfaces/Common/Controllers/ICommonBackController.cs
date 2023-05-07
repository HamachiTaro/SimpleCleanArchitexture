using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;

namespace Domains.Interfaces.Common.Controllers
{
    public interface ICommonBackController
    {
        /// <summary>
        /// 戻る。UniRx版
        /// </summary>
        /// <returns></returns>
        IObservable<Unit> OnBackAsObservable();

        /// <summary>
        /// 戻る。UniTask版
        /// </summary>
        /// <returns></returns>
        UniTask BackAsync(CancellationToken cancellationToken);
    }
}