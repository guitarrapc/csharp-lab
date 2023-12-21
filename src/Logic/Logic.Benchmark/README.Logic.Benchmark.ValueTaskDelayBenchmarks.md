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
|      **TaskDelay** |      **1** |  **12.33 ms** |  **2.249 ms** | **0.123 ms** |  **12.24 ms** |  **12.47 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.008 ms | 0.000 ms |  10.15 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **122.81 ms** | **20.555 ms** | **1.127 ms** | **121.72 ms** | **123.97 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.10 ms |  0.371 ms | 0.020 ms | 101.09 ms | 101.13 ms |         - |
