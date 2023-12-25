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
|      **TaskDelay** |      **1** |  **11.98 ms** | **0.480 ms** | **0.026 ms** |  **11.95 ms** |  **12.00 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.14 ms | 0.143 ms | 0.008 ms |  10.13 ms |  10.14 ms |     191 B |
|      **TaskDelay** |     **10** | **119.60 ms** | **6.896 ms** | **0.378 ms** | **119.17 ms** | **119.89 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.03 ms | 1.569 ms | 0.086 ms | 100.93 ms | 101.09 ms |         - |
