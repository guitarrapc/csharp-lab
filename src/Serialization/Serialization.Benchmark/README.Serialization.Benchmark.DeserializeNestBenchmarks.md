```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | {&quot;A&quot;(...)e&quot;}} [891] | 19.51 μs | 0.923 μs | 0.051 μs | 19.48 μs | 19.57 μs | 0.0305 |   3.22 KB |
| SystemTextJsonSourceGen | {&quot;A&quot;(...)e&quot;}} [891] | 19.02 μs | 1.726 μs | 0.095 μs | 18.97 μs | 19.13 μs | 0.0305 |   3.22 KB |
