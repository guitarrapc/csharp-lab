``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **11.98 ms** | **0.310 ms** | **0.017 ms** |  **11.96 ms** |  **11.99 ms** |     **533 B** |
| **ExponentialBackoff** |     **10** | **754.04 ms** | **0.735 ms** | **0.040 ms** | **754.00 ms** | **754.08 ms** |         **-** |
