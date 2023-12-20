``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.28 ms** |  **3.462 ms** | **0.190 ms** |  **12.10 ms** |  **12.48 ms** |     **585 B** |
| **ExponentialBackoff** |     **10** | **760.09 ms** | **37.887 ms** | **2.077 ms** | **758.05 ms** | **762.20 ms** |   **4,696 B** |
