```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 999.25 ns | 35.076 ns | 1.923 ns | 997.03 ns | 1,000.43 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 936.07 ns |  7.358 ns | 0.403 ns | 935.83 ns |   936.54 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.59 ns |  7.993 ns | 0.438 ns |  92.27 ns |    93.09 ns | 0.0014 |     120 B |
