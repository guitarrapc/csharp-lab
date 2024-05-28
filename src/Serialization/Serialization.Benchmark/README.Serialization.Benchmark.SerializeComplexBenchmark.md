```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 634.88 ns | 21.588 ns | 1.183 ns | 634.12 ns | 636.24 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 688.47 ns | 11.033 ns | 0.605 ns | 687.77 ns | 688.83 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.12 ns |  5.837 ns | 0.320 ns |  57.79 ns |  58.43 ns | 0.0014 |     120 B |
