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
| SystemTextJson          | Seria(...)Class [28] | 3.812 μs | 0.5817 μs | 0.0319 μs | 3.792 μs | 3.849 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 3.074 μs | 0.2533 μs | 0.0139 μs | 3.066 μs | 3.090 μs | 0.0267 |    2.2 KB |
