```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.668 μs | 0.0484 μs | 0.0027 μs | 3.666 μs | 3.671 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 3.053 μs | 0.1985 μs | 0.0109 μs | 3.042 μs | 3.064 μs | 0.0267 |    2.2 KB |
