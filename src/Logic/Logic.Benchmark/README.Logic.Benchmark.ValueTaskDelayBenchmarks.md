```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.31 ms** |  **2.507 ms** | **0.137 ms** |  **12.21 ms** |  **12.47 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.120 ms | 0.007 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **124.12 ms** | **31.203 ms** | **1.710 ms** | **122.53 ms** | **125.93 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.11 ms |  0.402 ms | 0.022 ms | 101.09 ms | 101.13 ms |     381 B |
