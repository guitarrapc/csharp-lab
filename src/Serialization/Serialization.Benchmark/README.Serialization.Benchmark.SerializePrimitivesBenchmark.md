```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,028.03 ns | 172.360 ns | 9.448 ns | 1,021.89 ns | 1,038.91 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   945.62 ns |   3.986 ns | 0.219 ns |   945.40 ns |   945.84 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    98.24 ns |   3.891 ns | 0.213 ns |    98.01 ns |    98.44 ns | 0.0014 |     120 B |
