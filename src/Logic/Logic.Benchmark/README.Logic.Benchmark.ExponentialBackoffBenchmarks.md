``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **12.27 ms** |  **2.615 ms** | **0.143 ms** |  **12.12 ms** |  **12.41 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **759.25 ms** | **41.367 ms** | **2.267 ms** | **757.88 ms** | **761.86 ms** |         **-** |
