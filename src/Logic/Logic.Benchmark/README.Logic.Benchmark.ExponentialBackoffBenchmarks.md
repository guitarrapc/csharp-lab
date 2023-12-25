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
| **ExponentialBackoff** |      **1** |  **12.16 ms** |  **1.481 ms** | **0.081 ms** |  **12.08 ms** |  **12.24 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **757.83 ms** | **76.540 ms** | **4.195 ms** | **753.60 ms** | **761.99 ms** |         **-** |
