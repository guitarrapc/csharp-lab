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
| **NewFromCidrString**  | **1**      |  **51.4049 ns** |  **0.3862 ns** | **0.0212 ns** |  **51.3844 ns** |  **51.4267 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6636 ns |  1.2055 ns | 0.0661 ns |   0.6210 ns |   0.7397 ns |         - |
| TryParseCidrString | 1      |  52.6301 ns |  1.0430 ns | 0.0572 ns |  52.5645 ns |  52.6696 ns |         - |
| TryParseCidrBytes  | 1      |   3.1228 ns |  0.9972 ns | 0.0547 ns |   3.0908 ns |   3.1859 ns |         - |
| **NewFromCidrString**  | **3**      | **148.9018 ns** |  **1.8747 ns** | **0.1028 ns** | **148.8198 ns** | **149.0171 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6228 ns |  0.0582 ns | 0.0032 ns |   0.6207 ns |   0.6265 ns |         - |
| TryParseCidrString | 3      | 155.3435 ns | 18.2642 ns | 1.0011 ns | 154.7212 ns | 156.4983 ns |         - |
| TryParseCidrBytes  | 3      |   9.3111 ns |  0.7751 ns | 0.0425 ns |   9.2802 ns |   9.3596 ns |         - |
