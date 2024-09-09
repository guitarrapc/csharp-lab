```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | 1      | 11.98 ms | 0.277 ms | 0.015 ms | 11.97 ms | 12.00 ms |     352 B |
| ValueTaskDelay | 1      | 10.14 ms | 0.159 ms | 0.009 ms | 10.13 ms | 10.15 ms |     128 B |
