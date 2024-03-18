```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.487 μs | 0.1946 μs | 0.0107 μs | 3.479 μs | 3.499 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 2.995 μs | 0.0775 μs | 0.0042 μs | 2.992 μs | 3.000 μs | 0.0267 |    2.2 KB |
