```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 631.67 ns | 21.957 ns | 1.204 ns | 630.58 ns | 632.96 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 729.64 ns | 15.915 ns | 0.872 ns | 729.12 ns | 730.65 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.89 ns |  2.612 ns | 0.143 ns |  57.72 ns |  57.98 ns | 0.0014 |     120 B |
