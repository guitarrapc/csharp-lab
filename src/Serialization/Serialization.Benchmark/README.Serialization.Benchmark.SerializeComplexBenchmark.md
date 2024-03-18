```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 643.59 ns | 10.925 ns | 0.599 ns | 643.01 ns | 644.21 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 675.55 ns | 10.510 ns | 0.576 ns | 674.89 ns | 675.96 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.64 ns |  2.549 ns | 0.140 ns |  58.51 ns |  58.79 ns | 0.0014 |     120 B |
