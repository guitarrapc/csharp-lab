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
| SystemTextJson          | Seria(...)tives [29] | 1,009.75 ns | 111.429 ns | 6.108 ns | 1,006.07 ns | 1,016.80 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   931.55 ns |   6.680 ns | 0.366 ns |   931.23 ns |   931.95 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.26 ns |  10.528 ns | 0.577 ns |    92.64 ns |    93.79 ns | 0.0014 |     120 B |
