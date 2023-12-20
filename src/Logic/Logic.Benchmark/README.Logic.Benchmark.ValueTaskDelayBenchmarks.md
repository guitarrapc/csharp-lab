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
|      **TaskDelay** |      **1** |  **11.98 ms** | **0.358 ms** | **0.020 ms** |  **11.96 ms** |  **11.99 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.13 ms | 0.018 ms | 0.001 ms |  10.13 ms |  10.13 ms |     191 B |
|      **TaskDelay** |     **10** | **119.69 ms** | **7.178 ms** | **0.393 ms** | **119.29 ms** | **120.08 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.04 ms | 1.261 ms | 0.069 ms | 100.96 ms | 101.09 ms |         - |
