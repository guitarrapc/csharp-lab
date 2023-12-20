``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **12.33 ms** |  **2.118 ms** | **0.116 ms** |  **12.23 ms** |  **12.46 ms** |     **401 B** |
| ValueTaskDelay |      1 |  10.15 ms |  0.109 ms | 0.006 ms |  10.14 ms |  10.15 ms |     209 B |
|      **TaskDelay** |     **10** | **123.43 ms** | **44.157 ms** | **2.420 ms** | **121.04 ms** | **125.88 ms** |   **2,405 B** |
| ValueTaskDelay |     10 | 101.21 ms |  0.421 ms | 0.023 ms | 101.18 ms | 101.23 ms |     413 B |
