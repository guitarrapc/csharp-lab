```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev    | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|----------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [28] | 3.596 μs | 0.2388 μs | 0.0131 μs | 3.585 μs | 3.610 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 3.036 μs | 0.1268 μs | 0.0069 μs | 3.031 μs | 3.044 μs | 0.0267 |    2.2 KB |
