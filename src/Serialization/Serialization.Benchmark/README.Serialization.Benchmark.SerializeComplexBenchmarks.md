```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 612.04 ns | 72.339 ns | 3.965 ns | 608.65 ns | 616.40 ns | 0.0229 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 698.87 ns | 17.576 ns | 0.963 ns | 698.01 ns | 699.91 ns | 0.0277 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  44.68 ns |  2.956 ns | 0.162 ns |  44.50 ns |  44.80 ns | 0.0072 |     120 B |
