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
| SystemTextJson          | Seria(...)Class [26] | 397.11 ns |  1.735 ns | 0.095 ns | 397.02 ns | 397.21 ns | 0.0196 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 326.75 ns | 15.159 ns | 0.831 ns | 326.00 ns | 327.64 ns | 0.0219 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  84.31 ns | 10.478 ns | 0.574 ns |  83.91 ns |  84.97 ns | 0.0076 |     128 B |
