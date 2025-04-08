```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.3690 ns** |  **6.8422 ns** | **0.3750 ns** |  **65.1474 ns** |  **65.8021 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0255 ns |  0.0958 ns | 0.0053 ns |   0.0216 ns |   0.0314 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.3450 ns |  0.6189 ns | 0.0339 ns |  72.3059 ns |  72.3668 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7712 ns |  0.3457 ns | 0.0189 ns |   2.7602 ns |   2.7931 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.0923 ns |  1.2916 ns | 0.0708 ns |  50.0112 ns |  50.1418 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6231 ns |  0.0196 ns | 0.0011 ns |   0.6223 ns |   0.6243 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.0998 ns |  9.1673 ns | 0.5025 ns |  52.6966 ns |  53.6627 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0957 ns |  0.2392 ns | 0.0131 ns |   3.0869 ns |   3.1108 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.6774 ns** |  **5.1906 ns** | **0.2845 ns** | **197.4459 ns** | **197.9950 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6415 ns |  0.0030 ns | 0.0002 ns |   0.6413 ns |   0.6416 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.2424 ns |  4.3990 ns | 0.2411 ns | 209.9808 ns | 210.4558 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2754 ns |  0.0862 ns | 0.0047 ns |   9.2716 ns |   9.2807 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.3615 ns | 25.0683 ns | 1.3741 ns | 148.5585 ns | 150.9481 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6226 ns |  0.0304 ns | 0.0017 ns |   0.6208 ns |   0.6240 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.7906 ns |  5.3315 ns | 0.2922 ns | 154.5145 ns | 155.0967 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2554 ns |  0.8868 ns | 0.0486 ns |   9.1998 ns |   9.2897 ns |         - |
