```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,008.58 ns |  14.270 ns |  0.782 ns | 1,007.71 ns | 1,009.21 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   918.71 ns | 206.929 ns | 11.342 ns |   910.89 ns |   931.72 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.54 ns |   5.568 ns |  0.305 ns |    95.29 ns |    95.88 ns | 0.0014 |     120 B |
