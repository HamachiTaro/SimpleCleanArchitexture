using System.Threading;
using Cysharp.Threading.Tasks;
using Domains.Interfaces.Common.Presenters;
using UnityEngine;

namespace Details.Common.Presenters
{
    public class CommonLoadingPresenter : MonoBehaviour, ICommonLoadingPresenter
    {
        [SerializeField] private CanvasGroup loadingCanvasGroup;
        
        public async UniTask ShowAsync(CancellationToken cancellationToken)
        {
            gameObject.SetActive(true);

            float value = 0f;
            while (true)
            {
                if (value >= 1f)
                {
                    loadingCanvasGroup.alpha = 1f;
                    break;
                }

                value += 0.01f;
                loadingCanvasGroup.alpha = value;
                await UniTask.Delay(10, cancellationToken: cancellationToken);
            }
        }

        public async UniTask HideAsync(CancellationToken cancellationToken)
        {
            float value = 1.0f;
            while (true)
            {
                if (value < 0f)
                {
                    loadingCanvasGroup.alpha = 0f;
                    break;
                }

                value -= 0.01f;
                loadingCanvasGroup.alpha = value;
                await UniTask.Delay(10, cancellationToken: cancellationToken);
            }

            gameObject.SetActive(false);
        }

        public void Show()
        {
            loadingCanvasGroup.alpha = 1f;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            loadingCanvasGroup.alpha = 0f;
            gameObject.SetActive(false);
        }
    }
}