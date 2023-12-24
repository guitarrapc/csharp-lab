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
|      **TaskDelay** |      **1** |  **12.34 ms** |  **2.033 ms** | **0.111 ms** |  **12.21 ms** |  **12.41 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.14 ms |  0.130 ms | 0.007 ms |  10.13 ms |  10.14 ms |     191 B |
|      **TaskDelay** |     **10** | **124.72 ms** | **18.871 ms** | **1.034 ms** | **123.53 ms** | **125.36 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.08 ms |  0.372 ms | 0.020 ms | 101.06 ms | 101.10 ms |         - |
