using System;
using UniRx;

namespace Domains.Interfaces.MainMenu.Controller
{
    public interface IMainMenuUIController
    {
        /// <summary>
        /// 設定シーンへの遷移通知
        /// </summary>
        /// <returns></returns>
        public IObservable<Unit> OnTransitSettingAsObservable();

        /// <summary>
        /// インゲームへの遷移通知
        /// </summary>
        /// <returns></returns>
        public IObservable<Unit> OnTransitInGameAsObservable();
    }
}