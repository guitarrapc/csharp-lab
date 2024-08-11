```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | {&quot;A&quot;(...)e&quot;}} [891] | 20.04 μs | 0.500 μs | 0.027 μs | 20.02 μs | 20.07 μs | 0.0305 |   3.19 KB |
| SystemTextJsonSourceGen | {&quot;A&quot;(...)e&quot;}} [891] | 19.02 μs | 1.359 μs | 0.074 μs | 18.93 μs | 19.07 μs | 0.0305 |   3.19 KB |
