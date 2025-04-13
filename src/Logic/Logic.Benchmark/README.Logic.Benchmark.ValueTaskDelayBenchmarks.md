```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.26 ms | 0.125 ms | 0.007 ms | 10.26 ms | 10.27 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.17 ms | 0.618 ms | 0.034 ms | 10.15 ms | 10.21 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.23 ms | 0.612 ms | 0.034 ms | 10.20 ms | 10.27 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.16 ms | 0.854 ms | 0.047 ms | 10.12 ms | 10.21 ms |     128 B |
