```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJsonSourceGen | {&quot;A&quot;(...)b&quot;}} [889] | 18.89 μs | 2.119 μs | 0.116 μs | 18.80 μs | 19.02 μs | 0.0305 |   3.19 KB |
| SystemTextJson          | {&quot;A&quot;(...)b&quot;}} [889] | 19.88 μs | 1.152 μs | 0.063 μs | 19.81 μs | 19.93 μs | 0.0305 |   3.19 KB |
