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
|      **TaskDelay** |      **1** |  **12.08 ms** | **1.524 ms** | **0.084 ms** |  **11.98 ms** |  **12.14 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.13 ms | 0.179 ms | 0.010 ms |  10.13 ms |  10.14 ms |     191 B |
|      **TaskDelay** |     **10** | **120.41 ms** | **9.675 ms** | **0.530 ms** | **119.85 ms** | **120.91 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.11 ms | 0.066 ms | 0.004 ms | 101.11 ms | 101.12 ms |         - |
