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
| SystemTextJson          | Seria(...)Class [29] | 661.70 ns | 63.152 ns | 3.462 ns | 659.43 ns | 665.68 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 701.92 ns | 54.461 ns | 2.985 ns | 700.13 ns | 705.36 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.03 ns |  1.489 ns | 0.082 ns |  57.94 ns |  58.09 ns | 0.0014 |     120 B |
