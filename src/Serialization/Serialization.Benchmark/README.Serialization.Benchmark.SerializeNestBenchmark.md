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
| SystemTextJson          | Seria(...)Class [28] | 3.612 μs | 0.9230 μs | 0.0506 μs | 3.581 μs | 3.670 μs | 0.0229 |   2.07 KB |
| SystemTextJsonSourceGen | Seria(...)Class [28] | 3.061 μs | 0.1602 μs | 0.0088 μs | 3.056 μs | 3.072 μs | 0.0267 |    2.2 KB |