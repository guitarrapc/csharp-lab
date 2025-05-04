```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9254 ns** | **10.7396 ns** | **0.5887 ns** |  **65.4596 ns** |  **66.5870 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0236 ns |  0.0669 ns | 0.0037 ns |   0.0210 ns |   0.0278 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.4751 ns |  4.3879 ns | 0.2405 ns |  72.2813 ns |  72.7443 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7694 ns |  0.3171 ns | 0.0174 ns |   2.7581 ns |   2.7894 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.5181 ns |  1.9682 ns | 0.1079 ns |  50.3951 ns |  50.5968 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6231 ns |  0.0373 ns | 0.0020 ns |   0.6216 ns |   0.6254 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.9483 ns |  2.8397 ns | 0.1557 ns |  52.8530 ns |  53.1280 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0386 ns |  0.1417 ns | 0.0078 ns |   3.0328 ns |   3.0474 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **199.1458 ns** |  **3.9697 ns** | **0.2176 ns** | **198.8972 ns** | **199.3019 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6468 ns |  0.0905 ns | 0.0050 ns |   0.6417 ns |   0.6516 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.9468 ns | 16.1076 ns | 0.8829 ns | 210.4140 ns | 211.9659 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.5549 ns |  1.1562 ns | 0.0634 ns |   9.4818 ns |   9.5938 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.1599 ns |  3.5396 ns | 0.1940 ns | 148.9776 ns | 149.3638 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6208 ns |  0.0155 ns | 0.0009 ns |   0.6198 ns |   0.6215 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.1750 ns |  4.1197 ns | 0.2258 ns | 154.9976 ns | 155.4292 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3489 ns |  1.6991 ns | 0.0931 ns |   9.2571 ns |   9.4433 ns |         - |
