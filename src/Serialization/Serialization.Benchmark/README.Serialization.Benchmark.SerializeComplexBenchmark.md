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
| SystemTextJson          | Seria(...)Class [29] | 673.31 ns | 27.927 ns | 1.531 ns | 671.73 ns | 674.79 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 700.05 ns | 84.417 ns | 4.627 ns | 697.12 ns | 705.39 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.92 ns |  5.413 ns | 0.297 ns |  57.70 ns |  58.26 ns | 0.0014 |     120 B |
