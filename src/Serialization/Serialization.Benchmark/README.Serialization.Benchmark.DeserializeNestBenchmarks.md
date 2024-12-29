```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |-------------------- |---------:|---------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | {&quot;A&quot;(...)e&quot;}} [891] | 19.39 μs | 1.129 μs | 0.062 μs | 19.35 μs | 19.46 μs | 0.0305 |   3.22 KB |
| SystemTextJsonSourceGen | {&quot;A&quot;(...)e&quot;}} [891] | 18.99 μs | 2.744 μs | 0.150 μs | 18.84 μs | 19.14 μs | 0.0305 |   3.22 KB |
