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
|      **TaskDelay** |      **1** |  **11.98 ms** | **0.286 ms** | **0.016 ms** |  **11.96 ms** |  **11.99 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.14 ms | 0.155 ms | 0.008 ms |  10.13 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **119.73 ms** | **7.596 ms** | **0.416 ms** | **119.25 ms** | **120.03 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.09 ms | 0.266 ms | 0.015 ms | 101.07 ms | 101.10 ms |         - |
