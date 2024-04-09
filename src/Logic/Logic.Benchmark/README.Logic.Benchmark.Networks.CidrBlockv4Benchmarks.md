```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.4617 ns** |  **1.2734 ns** | **0.0698 ns** |  **65.3822 ns** |  **65.5129 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8446 ns |  5.5803 ns | 0.3059 ns |  73.6034 ns |  74.1886 ns |         - |
| TryParseCidrBytes  | 1      |   3.0490 ns |  0.3992 ns | 0.0219 ns |   3.0352 ns |   3.0743 ns |         - |
| **NewFromCidrString**  | **3**      | **195.2698 ns** |  **7.3578 ns** | **0.4033 ns** | **194.8957 ns** | **195.6970 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6060 ns |  0.2409 ns | 0.0132 ns |   0.5946 ns |   0.6204 ns |         - |
| TryParseCidrString | 3      | 214.7622 ns | 45.3802 ns | 2.4874 ns | 213.2251 ns | 217.6320 ns |         - |
| TryParseCidrBytes  | 3      |   9.4472 ns |  6.4177 ns | 0.3518 ns |   9.2009 ns |   9.8501 ns |         - |
