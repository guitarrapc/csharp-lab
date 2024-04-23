```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 636.24 ns | 10.290 ns | 0.564 ns | 635.66 ns | 636.78 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 692.68 ns |  4.080 ns | 0.224 ns | 692.47 ns | 692.92 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.47 ns |  0.674 ns | 0.037 ns |  57.43 ns |  57.50 ns | 0.0014 |     120 B |
