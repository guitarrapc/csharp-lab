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
| SystemTextJson          | Seria(...)Class [26] | 405.81 ns | 37.900 ns | 2.077 ns | 403.88 ns | 408.01 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 319.32 ns | 69.208 ns | 3.794 ns | 315.05 ns | 322.29 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  86.16 ns |  8.921 ns | 0.489 ns |  85.63 ns |  86.60 ns | 0.0076 |     128 B |
