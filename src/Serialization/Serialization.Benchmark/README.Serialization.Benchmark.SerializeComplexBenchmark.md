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
| SystemTextJson          | Seria(...)Class [29] | 665.40 ns | 23.880 ns | 1.309 ns | 663.95 ns | 666.50 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 693.23 ns | 43.196 ns | 2.368 ns | 691.52 ns | 695.93 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  62.51 ns |  4.180 ns | 0.229 ns |  62.38 ns |  62.78 ns | 0.0014 |     120 B |
