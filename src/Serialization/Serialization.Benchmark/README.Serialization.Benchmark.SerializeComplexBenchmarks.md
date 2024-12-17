```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 606.43 ns | 31.105 ns | 1.705 ns | 604.47 ns | 607.58 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 644.06 ns | 19.546 ns | 1.071 ns | 642.87 ns | 644.93 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  47.12 ns |  3.664 ns | 0.201 ns |  46.91 ns |  47.31 ns | 0.0014 |     120 B |
