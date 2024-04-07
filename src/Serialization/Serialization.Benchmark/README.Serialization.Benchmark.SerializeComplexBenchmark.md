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
| SystemTextJson          | Seria(...)Class [29] | 670.13 ns | 49.771 ns | 2.728 ns | 667.77 ns | 673.12 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 696.81 ns | 15.128 ns | 0.829 ns | 696.06 ns | 697.70 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.14 ns |  6.211 ns | 0.340 ns |  58.84 ns |  59.51 ns | 0.0014 |     120 B |
