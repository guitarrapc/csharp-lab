```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **TaskDelay**      | **1**      |  **12.37 ms** |  **1.814 ms** | **0.099 ms** |  **12.28 ms** |  **12.48 ms** |     **352 B** |
| ValueTaskDelay | 1      |  10.14 ms |  0.137 ms | 0.008 ms |  10.13 ms |  10.14 ms |     192 B |
| **TaskDelay**      | **10**     | **126.27 ms** | **38.036 ms** | **2.085 ms** | **123.86 ms** | **127.53 ms** |    **2053 B** |
| ValueTaskDelay | 10     | 101.11 ms |  0.541 ms | 0.030 ms | 101.07 ms | 101.13 ms |     381 B |
