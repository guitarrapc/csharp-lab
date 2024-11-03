```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | 1      | 12.50 ms | 2.733 ms | 0.150 ms | 12.40 ms | 12.67 ms |     352 B |
| ValueTaskDelay | 1      | 10.13 ms | 0.040 ms | 0.002 ms | 10.13 ms | 10.14 ms |     128 B |
