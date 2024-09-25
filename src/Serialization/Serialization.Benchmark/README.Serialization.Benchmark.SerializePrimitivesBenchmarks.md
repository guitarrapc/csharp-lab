```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,018.86 ns | 54.999 ns | 3.015 ns | 1,016.68 ns | 1,022.30 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   952.19 ns | 56.433 ns | 3.093 ns |   949.84 ns |   955.69 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.50 ns |  4.056 ns | 0.222 ns |    93.35 ns |    93.76 ns | 0.0014 |     120 B |
