```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | 1      | 12.44 ms | 2.444 ms | 0.134 ms | 12.36 ms | 12.60 ms |     352 B |
| ValueTaskDelay | 1      | 10.13 ms | 0.149 ms | 0.008 ms | 10.13 ms | 10.14 ms |     128 B |
