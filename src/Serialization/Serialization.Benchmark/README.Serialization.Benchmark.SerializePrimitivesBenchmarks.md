```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,020.25 ns | 109.002 ns | 5.975 ns | 1,013.97 ns | 1,025.86 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   927.33 ns |  29.095 ns | 1.595 ns |   925.52 ns |   928.54 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    98.31 ns |   1.949 ns | 0.107 ns |    98.25 ns |    98.44 ns | 0.0014 |     120 B |
