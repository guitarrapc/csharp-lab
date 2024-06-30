```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.1154 ns** |  **0.3497 ns** | **0.0192 ns** |  **65.0955 ns** |  **65.1337 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1130 ns | 21.1545 ns | 1.1596 ns |  72.8085 ns |  75.0264 ns |         - |
| TryParseCidrBytes  | 1      |   3.0339 ns |  0.0154 ns | 0.0008 ns |   3.0331 ns |   3.0348 ns |         - |
| **NewFromCidrString**  | **3**      | **196.3482 ns** |  **1.7800 ns** | **0.0976 ns** | **196.2623 ns** | **196.4543 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5933 ns |  0.0115 ns | 0.0006 ns |   0.5926 ns |   0.5938 ns |         - |
| TryParseCidrString | 3      | 212.8070 ns |  9.8496 ns | 0.5399 ns | 212.4553 ns | 213.4286 ns |         - |
| TryParseCidrBytes  | 3      |   9.4397 ns |  1.7704 ns | 0.0970 ns |   9.3279 ns |   9.5016 ns |         - |
