```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 994.45 ns |  64.478 ns | 3.534 ns | 992.10 ns | 998.52 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 921.90 ns | 100.318 ns | 5.499 ns | 918.38 ns | 928.23 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.75 ns |   2.080 ns | 0.114 ns |  93.62 ns |  93.85 ns | 0.0014 |     120 B |
