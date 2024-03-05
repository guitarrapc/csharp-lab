```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | json                | Mean     | Error    | StdDev  | Min      | Max      | Allocated |
|------------------------ |-------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| SystemTextJson          | {&quot;Gn(...)&quot;:1} [182] | 980.8 ns | 48.85 ns | 2.68 ns | 978.0 ns | 983.4 ns |     104 B |
| SystemTextJsonSourceGen | {&quot;Gn(...)&quot;:1} [182] | 940.7 ns | 48.52 ns | 2.66 ns | 937.9 ns | 943.2 ns |     104 B |
