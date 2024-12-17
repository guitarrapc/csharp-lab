```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 393.83 ns | 20.708 ns | 1.135 ns | 392.74 ns | 395.01 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 327.74 ns | 57.678 ns | 3.162 ns | 324.10 ns | 329.80 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  86.35 ns |  2.783 ns | 0.153 ns |  86.22 ns |  86.52 ns | 0.0014 |     128 B |
