```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 646.83 ns | 53.671 ns | 2.942 ns | 644.89 ns | 650.21 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 698.31 ns | 53.822 ns | 2.950 ns | 695.24 ns | 701.12 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.51 ns |  3.116 ns | 0.171 ns |  58.38 ns |  58.70 ns | 0.0014 |     120 B |
