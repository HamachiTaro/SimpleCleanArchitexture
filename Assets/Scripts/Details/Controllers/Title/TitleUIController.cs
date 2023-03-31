using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.Title.Controllers;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Details.Controllers.Title
{
    public class TitleUIController : MonoBehaviour, ITitleUIController
    {
        [SerializeField] private Button buttonStart;

        public IObservable<Unit> OnNextSceneAsObservable() => buttonStart.OnClickAsObservable();

        public UniTask OnNextSceneAsync(CancellationToken cancellationToken) =>
            buttonStart.OnClickAsync(cancellationToken);
    }
}