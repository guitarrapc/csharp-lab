```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **81.86 ns** |   **3.004 ns** |  **0.165 ns** |  **81.68 ns** |  **82.01 ns** | **0.0148** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **593.91 ns** | **200.333 ns** | **10.981 ns** | **585.85 ns** | **606.42 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 567.47 ns |  18.256 ns |  1.001 ns | 566.70 ns | 568.60 ns | 0.0143 |     248 B |
