```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2397 ns** | **0.4794 ns** | **0.0263 ns** |  **65.2136 ns** |  **65.2662 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0238 ns | 0.0815 ns | 0.0045 ns |   0.0200 ns |   0.0287 ns |         - |
| TryParseCidrString | 1      |  72.5425 ns | 1.7478 ns | 0.0958 ns |  72.4785 ns |  72.6527 ns |         - |
| TryParseCidrBytes  | 1      |   2.7623 ns | 0.0886 ns | 0.0049 ns |   2.7594 ns |   2.7679 ns |         - |
| **NewFromCidrString**  | **3**      | **195.6776 ns** | **2.2829 ns** | **0.1251 ns** | **195.5341 ns** | **195.7639 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6416 ns | 0.0567 ns | 0.0031 ns |   0.6395 ns |   0.6451 ns |         - |
| TryParseCidrString | 3      | 211.7398 ns | 4.4315 ns | 0.2429 ns | 211.4923 ns | 211.9778 ns |         - |
| TryParseCidrBytes  | 3      |   9.4416 ns | 1.7872 ns | 0.0980 ns |   9.3808 ns |   9.5546 ns |         - |
