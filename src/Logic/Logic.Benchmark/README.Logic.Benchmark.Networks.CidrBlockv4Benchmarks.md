```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **68.0364 ns** | **3.7621 ns** | **0.2062 ns** |  **67.8533 ns** |  **68.2598 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.3294 ns | 0.0150 ns | 0.0008 ns |   0.3287 ns |   0.3303 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.5871 ns | 1.6552 ns | 0.0907 ns |  73.4842 ns |  73.6557 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7575 ns | 0.0265 ns | 0.0015 ns |   2.7566 ns |   2.7591 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3622 ns | 3.3252 ns | 0.1823 ns |  50.2034 ns |  50.5612 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.7678 ns | 1.9286 ns | 0.1057 ns |   0.6464 ns |   0.8395 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  57.2955 ns | 4.6985 ns | 0.2575 ns |  57.0327 ns |  57.5475 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0904 ns | 0.0165 ns | 0.0009 ns |   3.0893 ns |   3.0910 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.9768 ns** | **7.6361 ns** | **0.4186 ns** | **196.6690 ns** | **197.4534 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6457 ns | 0.0943 ns | 0.0052 ns |   0.6401 ns |   0.6503 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.5713 ns | 0.3222 ns | 0.0177 ns | 210.5588 ns | 210.5915 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2652 ns | 0.1010 ns | 0.0055 ns |   9.2589 ns |   9.2696 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.9509 ns | 2.9760 ns | 0.1631 ns | 149.7903 ns | 150.1164 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6207 ns | 0.0081 ns | 0.0004 ns |   0.6202 ns |   0.6211 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.5755 ns | 9.6400 ns | 0.5284 ns | 155.0558 ns | 156.1122 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3720 ns | 0.7206 ns | 0.0395 ns |   9.3270 ns |   9.4012 ns |         - |
