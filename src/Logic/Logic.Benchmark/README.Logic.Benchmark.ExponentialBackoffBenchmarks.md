``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.48 ms** |   **1.611 ms** | **0.088 ms** |  **12.38 ms** |  **12.55 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **761.94 ms** | **128.589 ms** | **7.048 ms** | **757.82 ms** | **770.08 ms** |         **-** |
