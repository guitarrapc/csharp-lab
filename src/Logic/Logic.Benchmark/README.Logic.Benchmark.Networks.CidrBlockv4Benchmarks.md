```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.1935 ns** |  **0.7624 ns** | **0.0418 ns** |  **50.1534 ns** |  **50.2368 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6253 ns |  0.0670 ns | 0.0037 ns |   0.6214 ns |   0.6287 ns |         - |
| TryParseCidrString | 1      |  52.6802 ns |  0.1305 ns | 0.0072 ns |  52.6719 ns |  52.6849 ns |         - |
| TryParseCidrBytes  | 1      |   3.1042 ns |  0.3870 ns | 0.0212 ns |   3.0891 ns |   3.1284 ns |         - |
| **NewFromCidrString**  | **3**      | **149.4802 ns** | **20.2540 ns** | **1.1102 ns** | **148.8012 ns** | **150.7614 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6246 ns |  0.0767 ns | 0.0042 ns |   0.6215 ns |   0.6294 ns |         - |
| TryParseCidrString | 3      | 155.5964 ns | 10.4370 ns | 0.5721 ns | 155.1326 ns | 156.2357 ns |         - |
| TryParseCidrBytes  | 3      |   9.4341 ns |  1.2972 ns | 0.0711 ns |   9.3722 ns |   9.5117 ns |         - |
