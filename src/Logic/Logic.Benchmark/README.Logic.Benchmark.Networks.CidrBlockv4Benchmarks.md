```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.2937 ns** |  **1.6258 ns** | **0.0891 ns** |  **65.1953 ns** |  **65.3688 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0225 ns |  0.0427 ns | 0.0023 ns |   0.0211 ns |   0.0252 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.0580 ns |  0.2225 ns | 0.0122 ns |  73.0479 ns |  73.0715 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7727 ns |  0.3004 ns | 0.0165 ns |   2.7585 ns |   2.7907 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3532 ns |  0.6163 ns | 0.0338 ns |  50.3195 ns |  50.3870 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6218 ns |  0.0229 ns | 0.0013 ns |   0.6204 ns |   0.6227 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.6366 ns |  5.3592 ns | 0.2938 ns |  52.4560 ns |  52.9756 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0878 ns |  0.0325 ns | 0.0018 ns |   3.0859 ns |   3.0895 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **196.9306 ns** |  **0.5971 ns** | **0.0327 ns** | **196.8929 ns** | **196.9518 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.3626 ns |  0.1424 ns | 0.0078 ns |   0.3537 ns |   0.3683 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 209.0218 ns |  1.8748 ns | 0.1028 ns | 208.9047 ns | 209.0968 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.1804 ns |  0.5003 ns | 0.0274 ns |   9.1593 ns |   9.2114 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.7348 ns |  1.8326 ns | 0.1004 ns | 149.6336 ns | 149.8344 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6244 ns |  0.0519 ns | 0.0028 ns |   0.6215 ns |   0.6272 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.0091 ns | 23.1465 ns | 1.2687 ns | 155.2722 ns | 157.4741 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2746 ns |  0.6837 ns | 0.0375 ns |   9.2368 ns |   9.3117 ns |         - |
