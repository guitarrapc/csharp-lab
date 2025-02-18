```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   884.4 ns |  27.80 ns |  1.52 ns |   882.7 ns |   885.8 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,503.0 ns | 319.72 ns | 17.52 ns | 1,485.0 ns | 1,520.0 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.9 ns |   2.33 ns |  0.13 ns |   850.8 ns |   851.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,437.5 ns | 563.40 ns | 30.88 ns | 1,408.3 ns | 1,469.8 ns | 0.1907 | 0.0019 |    3208 B |
