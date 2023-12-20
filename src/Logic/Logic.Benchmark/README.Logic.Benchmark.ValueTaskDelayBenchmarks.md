``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.10 ms** |  **1.264 ms** | **0.069 ms** |  **12.03 ms** |  **12.16 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.021 ms | 0.001 ms |  10.15 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **120.72 ms** | **14.339 ms** | **0.786 ms** | **120.16 ms** | **121.62 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.13 ms |  0.474 ms | 0.026 ms | 101.11 ms | 101.16 ms |         - |
