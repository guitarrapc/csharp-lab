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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.3179 ns** |  **5.4887 ns** | **0.3009 ns** |  **66.0631 ns** |  **66.6498 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0225 ns |  0.0657 ns | 0.0036 ns |   0.0199 ns |   0.0267 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.9673 ns |  7.3189 ns | 0.4012 ns |  72.7192 ns |  73.4302 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7583 ns |  0.0282 ns | 0.0015 ns |   2.7568 ns |   2.7599 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1297 ns |  0.7999 ns | 0.0438 ns |  50.0797 ns |  50.1614 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6217 ns |  0.0052 ns | 0.0003 ns |   0.6214 ns |   0.6219 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.6226 ns |  0.4298 ns | 0.0236 ns |  52.5960 ns |  52.6408 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0350 ns |  0.0361 ns | 0.0020 ns |   3.0337 ns |   3.0373 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.7296 ns** | **12.6559 ns** | **0.6937 ns** | **197.0655 ns** | **198.4496 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6467 ns |  0.0220 ns | 0.0012 ns |   0.6453 ns |   0.6474 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.0053 ns |  5.2737 ns | 0.2891 ns | 211.8363 ns | 212.3391 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3301 ns |  0.9837 ns | 0.0539 ns |   9.2934 ns |   9.3920 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.6681 ns |  2.8463 ns | 0.1560 ns | 149.5171 ns | 149.8287 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.4937 ns |  0.0127 ns | 0.0007 ns |   0.4932 ns |   0.4945 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 160.5616 ns | 28.6077 ns | 1.5681 ns | 159.3527 ns | 162.3334 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.0116 ns |  0.2643 ns | 0.0145 ns |   8.9958 ns |   9.0242 ns |         - |
