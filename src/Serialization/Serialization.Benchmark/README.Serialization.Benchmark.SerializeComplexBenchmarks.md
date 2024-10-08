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
| SystemTextJson          | Seria(...)Class [29] | 664.62 ns | 29.479 ns | 1.616 ns | 662.75 ns | 665.57 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 695.07 ns | 80.944 ns | 4.437 ns | 690.92 ns | 699.74 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.36 ns |  2.032 ns | 0.111 ns |  59.24 ns |  59.44 ns | 0.0014 |     120 B |
