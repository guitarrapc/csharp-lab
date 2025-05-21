```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.1092 ns** |  **2.5885 ns** | **0.1419 ns** |  **66.0021 ns** |  **66.2701 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.2568 ns |  0.9122 ns | 0.0500 ns |   0.2028 ns |   0.3015 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.1028 ns |  1.3062 ns | 0.0716 ns |  73.0384 ns |  73.1799 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7634 ns |  0.0366 ns | 0.0020 ns |   2.7613 ns |   2.7653 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1131 ns |  0.7581 ns | 0.0416 ns |  50.0799 ns |  50.1597 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6221 ns |  0.0184 ns | 0.0010 ns |   0.6209 ns |   0.6228 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.4973 ns |  0.4282 ns | 0.0235 ns |  53.4763 ns |  53.5226 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0993 ns |  0.3298 ns | 0.0181 ns |   3.0884 ns |   3.1202 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.6883 ns** | **54.3192 ns** | **2.9774 ns** | **195.2094 ns** | **200.9908 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6414 ns |  0.0212 ns | 0.0012 ns |   0.6401 ns |   0.6423 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 209.2130 ns |  2.9788 ns | 0.1633 ns | 209.0787 ns | 209.3947 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.2691 ns |  0.6147 ns | 0.0337 ns |   9.2341 ns |   9.3013 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.3519 ns |  3.6534 ns | 0.2003 ns | 149.1530 ns | 149.5535 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6217 ns |  0.0221 ns | 0.0012 ns |   0.6206 ns |   0.6230 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.5029 ns | 16.2757 ns | 0.8921 ns | 155.7934 ns | 157.5044 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3693 ns |  1.2527 ns | 0.0687 ns |   9.2920 ns |   9.4232 ns |         - |
