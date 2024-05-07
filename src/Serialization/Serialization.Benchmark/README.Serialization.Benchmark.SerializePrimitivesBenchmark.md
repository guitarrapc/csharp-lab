```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,031.27 ns | 41.56 ns | 2.278 ns | 1,029.43 ns | 1,033.82 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   960.53 ns | 32.04 ns | 1.756 ns |   959.48 ns |   962.55 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.06 ns | 27.61 ns | 1.513 ns |    94.89 ns |    97.77 ns | 0.0014 |     120 B |
