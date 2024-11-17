```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.5523 ns** | **0.5423 ns** | **0.0297 ns** |  **65.5342 ns** |  **65.5866 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0176 ns | 0.0474 ns | 0.0026 ns |   0.0146 ns |   0.0191 ns |         - |
| TryParseCidrString | 1      |  72.6708 ns | 3.8064 ns | 0.2086 ns |  72.4683 ns |  72.8851 ns |         - |
| TryParseCidrBytes  | 1      |   2.7508 ns | 0.2596 ns | 0.0142 ns |   2.7416 ns |   2.7672 ns |         - |
| **NewFromCidrString**  | **3**      | **198.7043 ns** | **8.1962 ns** | **0.4493 ns** | **198.1994 ns** | **199.0598 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6417 ns | 0.1348 ns | 0.0074 ns |   0.6373 ns |   0.6502 ns |         - |
| TryParseCidrString | 3      | 209.3537 ns | 5.9105 ns | 0.3240 ns | 208.9838 ns | 209.5872 ns |         - |
| TryParseCidrBytes  | 3      |   9.2784 ns | 1.1850 ns | 0.0650 ns |   9.2035 ns |   9.3192 ns |         - |
