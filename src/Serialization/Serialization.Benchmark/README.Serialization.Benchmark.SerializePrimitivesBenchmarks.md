```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,013.37 ns | 246.076 ns | 13.488 ns | 1,001.03 ns | 1,027.77 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   922.87 ns |  16.587 ns |  0.909 ns |   921.97 ns |   923.79 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.51 ns |   4.434 ns |  0.243 ns |    93.37 ns |    93.79 ns | 0.0014 |     120 B |
