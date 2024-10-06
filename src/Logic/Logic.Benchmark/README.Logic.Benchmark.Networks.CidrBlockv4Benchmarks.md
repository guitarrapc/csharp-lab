```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.4954 ns** |  **1.3761 ns** | **0.0754 ns** |  **67.4092 ns** |  **67.5493 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0230 ns |  0.0243 ns | 0.0013 ns |   0.0215 ns |   0.0240 ns |         - |
| TryParseCidrString | 1      |  73.5878 ns |  0.5750 ns | 0.0315 ns |  73.5520 ns |  73.6112 ns |         - |
| TryParseCidrBytes  | 1      |   2.7594 ns |  0.0280 ns | 0.0015 ns |   2.7584 ns |   2.7612 ns |         - |
| **NewFromCidrString**  | **3**      | **195.9298 ns** | **24.9515 ns** | **1.3677 ns** | **195.0755 ns** | **197.5072 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6429 ns |  0.0500 ns | 0.0027 ns |   0.6413 ns |   0.6461 ns |         - |
| TryParseCidrString | 3      | 229.0503 ns | 10.7353 ns | 0.5884 ns | 228.5469 ns | 229.6972 ns |         - |
| TryParseCidrBytes  | 3      |   9.4006 ns |  0.7998 ns | 0.0438 ns |   9.3525 ns |   9.4383 ns |         - |
