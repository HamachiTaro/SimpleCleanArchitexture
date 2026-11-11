using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Main
{
    /// <summary>
    /// 各シーンのLifetimeScopeの基底クラス。
    /// エントリーポイントの例外ハンドラーを共通で登録する。
    /// </summary>
    public abstract class SceneLifetimeScope : LifetimeScope
    {
        protected sealed override void Configure(IContainerBuilder builder)
        {
            // RegisterEntryPointより前に登録しないと、VContainer標準のハンドラーが登録されてしまう。
            builder.RegisterEntryPointExceptionHandler(HandleEntryPointException);

            ConfigureScene(builder);
        }

        /// <summary>
        /// シーンごとの登録。
        /// </summary>
        protected abstract void ConfigureScene(IContainerBuilder builder);

        private static void HandleEntryPointException(Exception exception)
        {
            // スコープ破棄(シーン遷移・再生終了)によるキャンセルは正常終了として扱う。
            if (exception is OperationCanceledException) return;

            Debug.LogException(exception);
        }
    }
}
