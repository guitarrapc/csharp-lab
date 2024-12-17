```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **49.7772 ns** |  **0.0885 ns** | **0.0049 ns** |  **49.7725 ns** |  **49.7822 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.3122 ns |  0.0478 ns | 0.0026 ns |   0.3098 ns |   0.3150 ns |         - |
| TryParseCidrString | 1      |  57.5591 ns |  2.9709 ns | 0.1628 ns |  57.4297 ns |  57.7420 ns |         - |
| TryParseCidrBytes  | 1      |   3.0214 ns |  0.0743 ns | 0.0041 ns |   3.0179 ns |   3.0259 ns |         - |
| **NewFromCidrString**  | **3**      | **148.7672 ns** |  **1.8206 ns** | **0.0998 ns** | **148.6674 ns** | **148.8670 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6205 ns |  0.0485 ns | 0.0027 ns |   0.6185 ns |   0.6235 ns |         - |
| TryParseCidrString | 3      | 155.5917 ns | 14.0463 ns | 0.7699 ns | 155.1178 ns | 156.4800 ns |         - |
| TryParseCidrBytes  | 3      |   8.8771 ns |  0.4780 ns | 0.0262 ns |   8.8468 ns |   8.8936 ns |         - |
