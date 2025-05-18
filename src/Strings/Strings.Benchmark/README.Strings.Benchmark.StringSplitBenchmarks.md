```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   862.9 ns | 307.68 ns | 16.86 ns |   852.5 ns |   882.4 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,465.5 ns | 874.84 ns | 47.95 ns | 1,410.1 ns | 1,493.3 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   854.0 ns |  44.80 ns |  2.46 ns |   851.4 ns |   856.4 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,264.3 ns | 152.16 ns |  8.34 ns | 1,257.5 ns | 1,273.6 ns | 0.1907 | 0.0019 |    3208 B |
