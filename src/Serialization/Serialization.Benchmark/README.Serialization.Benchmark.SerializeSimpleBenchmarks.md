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
| SystemTextJson          | Seria(...)Class [26] | 403.52 ns |  9.834 ns | 0.539 ns | 402.91 ns | 403.94 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 324.92 ns |  6.927 ns | 0.380 ns | 324.59 ns | 325.34 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  87.62 ns | 25.198 ns | 1.381 ns |  86.79 ns |  89.21 ns | 0.0014 |     128 B |
