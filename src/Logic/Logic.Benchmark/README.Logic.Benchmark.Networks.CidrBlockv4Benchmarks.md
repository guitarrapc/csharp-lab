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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.0856 ns** |  **1.7355 ns** | **0.0951 ns** |  **64.9977 ns** |  **65.1866 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0214 ns |  0.0127 ns | 0.0007 ns |   0.0206 ns |   0.0219 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.0934 ns |  4.1842 ns | 0.2293 ns |  72.8963 ns |  73.3451 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7619 ns |  0.1073 ns | 0.0059 ns |   2.7584 ns |   2.7687 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1722 ns |  4.8565 ns | 0.2662 ns |  49.9314 ns |  50.4581 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6221 ns |  0.0298 ns | 0.0016 ns |   0.6206 ns |   0.6238 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.8005 ns |  2.8379 ns | 0.1556 ns |  52.6954 ns |  52.9792 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0314 ns |  0.0291 ns | 0.0016 ns |   3.0296 ns |   3.0327 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.8466 ns** | **55.6582 ns** | **3.0508 ns** | **195.4375 ns** | **201.2770 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6423 ns |  0.0289 ns | 0.0016 ns |   0.6407 ns |   0.6438 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.5990 ns |  4.5598 ns | 0.2499 ns | 211.4309 ns | 211.8862 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4066 ns |  1.5023 ns | 0.0823 ns |   9.3424 ns |   9.4995 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.5858 ns | 10.9386 ns | 0.5996 ns | 149.0066 ns | 150.2039 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6231 ns |  0.0837 ns | 0.0046 ns |   0.6198 ns |   0.6283 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.7882 ns | 16.0374 ns | 0.8791 ns | 155.7852 ns | 157.4248 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2179 ns |  2.1486 ns | 0.1178 ns |   9.1377 ns |   9.3531 ns |         - |
