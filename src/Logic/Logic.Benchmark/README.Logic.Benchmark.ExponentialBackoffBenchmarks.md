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
| **ExponentialBackoff** |      **1** |  **12.56 ms** |   **4.573 ms** | **0.251 ms** |  **12.28 ms** |  **12.74 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **760.86 ms** | **152.528 ms** | **8.361 ms** | **754.17 ms** | **770.23 ms** |         **-** |
