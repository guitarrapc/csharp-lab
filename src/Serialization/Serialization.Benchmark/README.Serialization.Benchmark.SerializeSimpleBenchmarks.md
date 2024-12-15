```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 391.74 ns |  6.113 ns | 0.335 ns | 391.54 ns | 392.13 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 324.24 ns | 42.184 ns | 2.312 ns | 321.75 ns | 326.31 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  89.50 ns |  8.410 ns | 0.461 ns |  89.23 ns |  90.03 ns | 0.0014 |     128 B |
