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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.9487 ns** |  **4.8704 ns** | **0.2670 ns** |  **65.7906 ns** |  **66.2569 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0252 ns |  0.0936 ns | 0.0051 ns |   0.0214 ns |   0.0310 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.4423 ns |  2.3140 ns | 0.1268 ns |  73.3332 ns |  73.5815 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7701 ns |  0.4163 ns | 0.0228 ns |   2.7563 ns |   2.7965 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1694 ns |  2.6616 ns | 0.1459 ns |  50.0639 ns |  50.3359 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6262 ns |  0.1713 ns | 0.0094 ns |   0.6204 ns |   0.6370 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.1783 ns |  7.8013 ns | 0.4276 ns |  52.7972 ns |  53.6407 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0883 ns |  0.0113 ns | 0.0006 ns |   3.0875 ns |   3.0887 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.0480 ns** |  **1.7437 ns** | **0.0956 ns** | **196.9467 ns** | **197.1366 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6419 ns |  0.1091 ns | 0.0060 ns |   0.6377 ns |   0.6488 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.8721 ns |  3.2095 ns | 0.1759 ns | 211.7075 ns | 212.0575 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2803 ns |  0.1345 ns | 0.0074 ns |   9.2719 ns |   9.2857 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.0426 ns | 12.9164 ns | 0.7080 ns | 148.3795 ns | 149.7882 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6300 ns |  0.1377 ns | 0.0075 ns |   0.6225 ns |   0.6375 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.8270 ns |  8.2039 ns | 0.4497 ns | 155.4138 ns | 156.3059 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3708 ns |  0.8501 ns | 0.0466 ns |   9.3314 ns |   9.4222 ns |         - |
