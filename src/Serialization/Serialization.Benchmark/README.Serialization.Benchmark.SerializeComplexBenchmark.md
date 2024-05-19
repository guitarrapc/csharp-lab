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
| SystemTextJson          | Seria(...)Class [29] | 637.90 ns | 45.246 ns | 2.480 ns | 635.25 ns | 640.17 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 694.91 ns | 20.812 ns | 1.141 ns | 693.92 ns | 696.16 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.42 ns |  3.368 ns | 0.185 ns |  58.29 ns |  58.63 ns | 0.0014 |     120 B |
