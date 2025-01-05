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
| SystemTextJson          | Seria(...)Class [26] | 356.54 ns | 43.266 ns | 2.372 ns | 353.92 ns | 358.53 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 319.10 ns | 47.360 ns | 2.596 ns | 316.84 ns | 321.94 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  85.25 ns |  4.335 ns | 0.238 ns |  85.06 ns |  85.52 ns | 0.0076 |     128 B |
