```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.737 μs | 0.2778 μs | 0.0152 μs | 3.722 μs | 3.753 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 3.014 μs | 0.1164 μs | 0.0064 μs | 3.009 μs | 3.022 μs | 0.0267 |    2.2 KB |
