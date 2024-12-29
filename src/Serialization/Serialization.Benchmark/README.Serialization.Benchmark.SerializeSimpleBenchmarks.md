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
| SystemTextJson          | Seria(...)Class [26] | 391.04 ns |  2.743 ns | 0.150 ns | 390.89 ns | 391.19 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 325.95 ns | 42.588 ns | 2.334 ns | 324.60 ns | 328.65 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  88.16 ns |  5.485 ns | 0.301 ns |  87.96 ns |  88.50 ns | 0.0014 |     128 B |
