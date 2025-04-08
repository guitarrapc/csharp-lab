```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   841.3 ns |  38.36 ns |  2.10 ns |   839.3 ns |   843.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,478.2 ns | 324.71 ns | 17.80 ns | 1,460.6 ns | 1,496.2 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.7 ns |   5.34 ns |  0.29 ns |   850.4 ns |   851.0 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,438.0 ns | 290.27 ns | 15.91 ns | 1,426.0 ns | 1,456.1 ns | 0.1907 | 0.0019 |    3208 B |
