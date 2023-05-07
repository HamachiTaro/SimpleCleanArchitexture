using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.Common.Controllers;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Details.Common.Controllers
{
    public class CommonBackController : MonoBehaviour, ICommonBackController
    {
        [SerializeField] private Button backButton;

        public IObservable<Unit> OnBackAsObservable() => backButton.OnClickAsObservable();

        public async UniTask BackAsync(CancellationToken cancellationToken)
        {
            await backButton.OnClickAsync(cancellationToken);
        }
    }
}