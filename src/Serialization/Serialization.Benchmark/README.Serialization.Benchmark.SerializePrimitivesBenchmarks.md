```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 979.64 ns | 47.479 ns | 2.603 ns | 976.67 ns | 981.54 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 909.49 ns | 40.473 ns | 2.218 ns | 907.25 ns | 911.68 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  95.48 ns |  1.210 ns | 0.066 ns |  95.42 ns |  95.55 ns | 0.0014 |     120 B |
