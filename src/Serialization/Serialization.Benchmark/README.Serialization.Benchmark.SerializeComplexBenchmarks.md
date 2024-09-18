```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 626.03 ns | 23.385 ns | 1.282 ns | 624.55 ns | 626.79 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 693.87 ns | 38.537 ns | 2.112 ns | 692.62 ns | 696.31 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  56.85 ns |  2.278 ns | 0.125 ns |  56.70 ns |  56.94 ns | 0.0014 |     120 B |
