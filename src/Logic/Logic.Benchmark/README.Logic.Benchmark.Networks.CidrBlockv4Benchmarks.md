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
| **NewFromCidrString**  | **.NET 8.0** | **1**      | **104.2935 ns** | **10.8901 ns** | **0.5969 ns** | **103.9198 ns** | **104.9820 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0258 ns |  0.0384 ns | 0.0021 ns |   0.0237 ns |   0.0279 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.2848 ns |  0.9128 ns | 0.0500 ns |  73.2339 ns |  73.3340 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7634 ns |  0.1647 ns | 0.0090 ns |   2.7572 ns |   2.7738 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.4984 ns |  2.1531 ns | 0.1180 ns |  50.4001 ns |  50.6293 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6204 ns |  0.0189 ns | 0.0010 ns |   0.6195 ns |   0.6215 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5405 ns |  2.2818 ns | 0.1251 ns |  52.3965 ns |  52.6226 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0937 ns |  0.1064 ns | 0.0058 ns |   3.0872 ns |   3.0984 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.1657 ns** |  **3.4203 ns** | **0.1875 ns** | **197.0006 ns** | **197.3695 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6537 ns |  0.2404 ns | 0.0132 ns |   0.6410 ns |   0.6673 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 213.3173 ns | 65.5354 ns | 3.5922 ns | 209.1695 ns | 215.4167 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3105 ns |  0.3182 ns | 0.0174 ns |   9.2904 ns |   9.3218 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.7547 ns |  7.2768 ns | 0.3989 ns | 148.2997 ns | 149.0439 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6247 ns |  0.0625 ns | 0.0034 ns |   0.6222 ns |   0.6286 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.9109 ns |  1.4309 ns | 0.0784 ns | 154.8569 ns | 155.0008 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4140 ns |  0.3769 ns | 0.0207 ns |   9.3921 ns |   9.4331 ns |         - |
