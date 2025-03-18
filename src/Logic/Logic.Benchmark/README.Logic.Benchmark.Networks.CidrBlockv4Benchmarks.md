```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.7676 ns** |  **1.1608 ns** | **0.0636 ns** |  **66.7641 ns** |  **66.7058 ns** |  **66.8329 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.1085 ns |  2.7358 ns | 0.1500 ns |   0.0228 ns |   0.0210 ns |   0.2816 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  76.1885 ns |  7.6556 ns | 0.4196 ns |  75.9655 ns |  75.9275 ns |  76.6725 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7718 ns |  0.4325 ns | 0.0237 ns |   2.7588 ns |   2.7574 ns |   2.7991 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.4035 ns |  0.0554 ns | 0.0030 ns |  50.4050 ns |  50.4000 ns |  50.4055 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6252 ns |  0.1137 ns | 0.0062 ns |   0.6221 ns |   0.6210 ns |   0.6323 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5576 ns |  1.3336 ns | 0.0731 ns |  52.5402 ns |  52.4949 ns |  52.6379 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0879 ns |  0.0277 ns | 0.0015 ns |   3.0876 ns |   3.0866 ns |   3.0896 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.2513 ns** | **10.8165 ns** | **0.5929 ns** | **197.0168 ns** | **196.8116 ns** | **197.9256 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6428 ns |  0.0404 ns | 0.0022 ns |   0.6428 ns |   0.6406 ns |   0.6450 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.9672 ns |  5.1312 ns | 0.2813 ns | 211.8456 ns | 211.7672 ns | 212.2888 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2563 ns |  0.1910 ns | 0.0105 ns |   9.2560 ns |   9.2459 ns |   9.2668 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.4054 ns | 16.7948 ns | 0.9206 ns | 148.8755 ns | 148.8722 ns | 150.4684 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6240 ns |  0.0323 ns | 0.0018 ns |   0.6230 ns |   0.6229 ns |   0.6260 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.4353 ns |  4.4865 ns | 0.2459 ns | 156.4267 ns | 156.1938 ns | 156.6854 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3478 ns |  0.4005 ns | 0.0220 ns |   9.3557 ns |   9.3230 ns |   9.3647 ns |         - |
