# Sample HybridWevView

.NET 9 から追加された HybridWebView を利用したサンプルプロジェクトです。

公式ドキュメントの流れに沿った内容となっています。
https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/hybridwebview?view=net-maui-9.0

また、.NET 9 RC 1 時点で、macOS Sequoia で動作させるための Workaround が追加されています。

.NET 9 RC 1 のリリース時点の Control などに準拠しています。

## Requirements

- .NET 9 RC 1 以降
- .NET MAUI Workload

## Running the Sample

```bash
# if macOS
$ dotnet build -t:Run -f net9.0-maccatalyst
# if windows
$ dotnet build -t:Run -f net9.0-windows10.0.19041.0
```
