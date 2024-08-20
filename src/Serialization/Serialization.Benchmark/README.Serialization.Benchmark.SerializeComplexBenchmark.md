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
| SystemTextJson          | Seria(...)Class [29] | 658.35 ns | 73.401 ns | 4.023 ns | 654.78 ns | 662.71 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 693.12 ns |  7.478 ns | 0.410 ns | 692.88 ns | 693.60 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.67 ns |  6.530 ns | 0.358 ns |  57.36 ns |  58.06 ns | 0.0014 |     120 B |
