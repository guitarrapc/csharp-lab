```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.3871 ns** |  **1.5352 ns** | **0.0842 ns** |  **65.4225 ns** |  **65.2911 ns** |  **65.4478 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.1925 ns |  2.6933 ns | 0.1476 ns |   0.2755 ns |   0.0221 ns |   0.2800 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.8225 ns |  4.3325 ns | 0.2375 ns |  73.9462 ns |  73.5487 ns |  73.9727 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7733 ns |  0.3957 ns | 0.0217 ns |   2.7622 ns |   2.7594 ns |   2.7983 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  51.8603 ns |  4.2427 ns | 0.2326 ns |  51.8412 ns |  51.6378 ns |  52.1018 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6246 ns |  0.0830 ns | 0.0046 ns |   0.6229 ns |   0.6213 ns |   0.6298 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5671 ns |  1.3280 ns | 0.0728 ns |  52.5866 ns |  52.4866 ns |  52.6282 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0938 ns |  0.2235 ns | 0.0122 ns |   3.0867 ns |   3.0867 ns |   3.1079 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **219.3323 ns** |  **7.3335 ns** | **0.4020 ns** | **219.1931 ns** | **219.0184 ns** | **219.7853 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6455 ns |  0.0973 ns | 0.0053 ns |   0.6429 ns |   0.6419 ns |   0.6516 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.9772 ns |  0.6706 ns | 0.0368 ns | 210.9668 ns | 210.9467 ns | 211.0180 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4707 ns |  2.2661 ns | 0.1242 ns |   9.4241 ns |   9.3765 ns |   9.6114 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.8154 ns | 15.5934 ns | 0.8547 ns | 150.2438 ns | 148.8312 ns | 150.3712 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6283 ns |  0.1315 ns | 0.0072 ns |   0.6313 ns |   0.6200 ns |   0.6334 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.7458 ns |  2.8252 ns | 0.1549 ns | 155.7706 ns | 155.5801 ns | 155.8868 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.5253 ns |  1.6486 ns | 0.0904 ns |   9.4827 ns |   9.4641 ns |   9.6291 ns |         - |
