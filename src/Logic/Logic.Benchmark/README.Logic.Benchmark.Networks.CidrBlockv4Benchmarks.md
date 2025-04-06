```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.0833 ns** | **2.4019 ns** | **0.1317 ns** |  **65.9925 ns** |  **66.2343 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0237 ns | 0.0457 ns | 0.0025 ns |   0.0222 ns |   0.0266 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.3904 ns | 3.3309 ns | 0.1826 ns |  72.2498 ns |  72.5968 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7713 ns | 0.3031 ns | 0.0166 ns |   2.7563 ns |   2.7891 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1557 ns | 1.7514 ns | 0.0960 ns |  50.0988 ns |  50.2665 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6240 ns | 0.1125 ns | 0.0062 ns |   0.6198 ns |   0.6311 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.7361 ns | 1.4494 ns | 0.0794 ns |  52.6468 ns |  52.7991 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0918 ns | 0.0861 ns | 0.0047 ns |   3.0875 ns |   3.0969 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **202.8980 ns** | **2.8731 ns** | **0.1575 ns** | **202.7555 ns** | **203.0671 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6395 ns | 0.0274 ns | 0.0015 ns |   0.6386 ns |   0.6413 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.7346 ns | 3.3997 ns | 0.1863 ns | 211.5447 ns | 211.9171 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4168 ns | 1.0859 ns | 0.0595 ns |   9.3487 ns |   9.4587 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.5778 ns | 1.8708 ns | 0.1025 ns | 148.4596 ns | 148.6427 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6237 ns | 0.0499 ns | 0.0027 ns |   0.6210 ns |   0.6265 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.3553 ns | 6.5332 ns | 0.3581 ns | 154.9499 ns | 155.6285 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3520 ns | 0.6644 ns | 0.0364 ns |   9.3155 ns |   9.3883 ns |         - |
