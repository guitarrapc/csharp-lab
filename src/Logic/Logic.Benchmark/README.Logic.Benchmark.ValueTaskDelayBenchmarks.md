```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | 1      | 12.24 ms | 3.196 ms | 0.175 ms | 12.06 ms | 12.41 ms |     352 B |
| ValueTaskDelay | 1      | 10.14 ms | 0.145 ms | 0.008 ms | 10.13 ms | 10.15 ms |     192 B |
