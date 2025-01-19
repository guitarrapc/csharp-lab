```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 393.80 ns | 16.304 ns | 0.894 ns | 393.04 ns | 394.79 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 328.54 ns | 31.478 ns | 1.725 ns | 327.01 ns | 330.41 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  83.39 ns |  9.755 ns | 0.535 ns |  82.95 ns |  83.99 ns | 0.0076 |     128 B |
