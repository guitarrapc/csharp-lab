```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   845.1 ns |  23.71 ns |  1.30 ns |   843.9 ns |   846.5 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,456.9 ns | 325.46 ns | 17.84 ns | 1,437.2 ns | 1,471.9 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   852.3 ns | 123.56 ns |  6.77 ns |   844.6 ns |   857.4 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,347.5 ns | 162.02 ns |  8.88 ns | 1,340.7 ns | 1,357.5 ns | 0.1907 | 0.0019 |    3208 B |
