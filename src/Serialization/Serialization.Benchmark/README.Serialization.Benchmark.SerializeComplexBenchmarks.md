```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 634.38 ns | 16.453 ns | 0.902 ns | 633.59 ns | 635.36 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 692.86 ns |  6.348 ns | 0.348 ns | 692.52 ns | 693.22 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  61.11 ns |  2.795 ns | 0.153 ns |  61.01 ns |  61.28 ns | 0.0014 |     120 B |
