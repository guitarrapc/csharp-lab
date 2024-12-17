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
| SystemTextJson          | Seria(...)Class [26] | 393.80 ns | 16.333 ns | 0.895 ns | 393.08 ns | 394.80 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 322.63 ns | 54.421 ns | 2.983 ns | 320.49 ns | 326.04 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  88.01 ns |  3.765 ns | 0.206 ns |  87.80 ns |  88.21 ns | 0.0014 |     128 B |
