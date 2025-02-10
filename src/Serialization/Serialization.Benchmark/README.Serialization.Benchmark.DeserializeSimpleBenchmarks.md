```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data      | json                 | Mean      | Error     | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |---------- |--------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[103]** | **?**                    |  **86.11 ns** |  **38.41 ns** |  **2.105 ns** |  **83.86 ns** |  **88.02 ns** | **0.0148** |     **248 B** |
| **SystemTextJson**          | **?**         | **{&quot;X&quot;(...)\\n&quot;} [150]** | **588.93 ns** | **197.04 ns** | **10.800 ns** | **582.46 ns** | **601.40 ns** | **0.0143** |     **248 B** |
| SystemTextJsonSourceGen | ?         | {&quot;X&quot;(...)\\n&quot;} [150] | 574.19 ns |  23.75 ns |  1.302 ns | 572.75 ns | 575.27 ns | 0.0143 |     248 B |
