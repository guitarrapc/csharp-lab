```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error    | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|---------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   835.0 ns | 35.37 ns | 1.94 ns |   833.5 ns |   837.2 ns |      - |         - |
| StringSplit        | 1      | 1,511.1 ns | 59.67 ns | 3.27 ns | 1,508.3 ns | 1,514.7 ns | 0.0381 |    3208 B |
