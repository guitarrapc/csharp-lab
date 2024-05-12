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
| SystemTextJson          | Seria(...)Class [29] | 631.03 ns | 17.995 ns | 0.986 ns | 630.05 ns | 632.02 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 686.06 ns | 24.874 ns | 1.363 ns | 684.52 ns | 687.10 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.19 ns |  1.953 ns | 0.107 ns |  58.12 ns |  58.31 ns | 0.0014 |     120 B |
