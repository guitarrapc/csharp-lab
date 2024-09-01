```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,034.60 ns | 70.182 ns | 3.847 ns | 1,031.43 ns | 1,038.88 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   911.64 ns | 21.097 ns | 1.156 ns |   910.30 ns |   912.36 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.88 ns |  3.561 ns | 0.195 ns |    93.74 ns |    94.11 ns | 0.0014 |     120 B |
