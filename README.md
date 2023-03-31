# SimpleCleanArchitexture

DomainとDetailのみのクリーンアーキテクチャ。

- DomainはUseCasesとInterfaceのみ。
- UseCaseに実現したいことを記述。
- UseCaseの実現のために必要な機能をInterfaceに定義。
- DetailでDomain.Interfaceを実装する。

# 使用アセット
以下を使用しているのでインストールが必要。
- UniTask
- UniRx
- VContainer
