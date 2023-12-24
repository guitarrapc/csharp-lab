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
|      **TaskDelay** |      **1** |  **12.08 ms** | **1.040 ms** | **0.057 ms** |  **12.02 ms** |  **12.12 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.13 ms | 0.015 ms | 0.001 ms |  10.13 ms |  10.13 ms |     191 B |
|      **TaskDelay** |     **10** | **120.66 ms** | **9.078 ms** | **0.498 ms** | **120.36 ms** | **121.23 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.09 ms | 0.176 ms | 0.010 ms | 101.08 ms | 101.10 ms |         - |
