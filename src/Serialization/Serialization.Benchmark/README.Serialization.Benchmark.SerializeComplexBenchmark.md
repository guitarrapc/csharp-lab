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
| SystemTextJson          | Seria(...)Class [29] | 637.54 ns | 13.644 ns | 0.748 ns | 637.01 ns | 638.39 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 699.98 ns |  6.842 ns | 0.375 ns | 699.63 ns | 700.37 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.00 ns |  2.580 ns | 0.141 ns |  57.91 ns |  58.17 ns | 0.0014 |     120 B |
