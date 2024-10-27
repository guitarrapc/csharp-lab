```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.0118 ns** | **33.9172 ns** | **1.8591 ns** |  **65.7104 ns** |  **69.1410 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0234 ns |  0.0336 ns | 0.0018 ns |   0.0216 ns |   0.0252 ns |         - |
| TryParseCidrString | 1      |  73.1433 ns |  4.9464 ns | 0.2711 ns |  72.8796 ns |  73.4213 ns |         - |
| TryParseCidrBytes  | 1      |   2.7596 ns |  0.1519 ns | 0.0083 ns |   2.7500 ns |   2.7653 ns |         - |
| **NewFromCidrString**  | **3**      | **195.6571 ns** | **13.5960 ns** | **0.7452 ns** | **195.1637 ns** | **196.5144 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6386 ns |  0.0593 ns | 0.0033 ns |   0.6364 ns |   0.6423 ns |         - |
| TryParseCidrString | 3      | 208.6554 ns |  7.3148 ns | 0.4009 ns | 208.1969 ns | 208.9401 ns |         - |
| TryParseCidrBytes  | 3      |   9.2962 ns |  1.6060 ns | 0.0880 ns |   9.1991 ns |   9.3708 ns |         - |
