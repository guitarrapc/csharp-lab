``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **11.98 ms** | **0.915 ms** | **0.050 ms** |  **11.92 ms** |  **12.02 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.15 ms | 0.032 ms | 0.002 ms |  10.15 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **119.57 ms** | **6.754 ms** | **0.370 ms** | **119.26 ms** | **119.98 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.11 ms | 0.493 ms | 0.027 ms | 101.08 ms | 101.14 ms |         - |
