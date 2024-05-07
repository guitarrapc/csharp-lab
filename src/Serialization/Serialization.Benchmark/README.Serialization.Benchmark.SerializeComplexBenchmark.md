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
| SystemTextJson          | Seria(...)Class [29] | 641.91 ns |  9.734 ns | 0.534 ns | 641.36 ns | 642.42 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 690.36 ns | 13.442 ns | 0.737 ns | 689.56 ns | 691.01 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  64.13 ns |  2.307 ns | 0.126 ns |  63.99 ns |  64.24 ns | 0.0014 |     120 B |
