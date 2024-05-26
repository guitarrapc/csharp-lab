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
| SystemTextJson          | Seria(...)Class [29] | 640.74 ns | 34.422 ns | 1.887 ns | 639.12 ns | 642.81 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 692.03 ns | 39.277 ns | 2.153 ns | 690.46 ns | 694.49 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.05 ns |  1.217 ns | 0.067 ns |  57.97 ns |  58.09 ns | 0.0014 |     120 B |
