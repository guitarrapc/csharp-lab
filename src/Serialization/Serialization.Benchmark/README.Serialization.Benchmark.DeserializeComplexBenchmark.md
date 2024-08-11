```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev    | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|----------:|----------:|------------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **53.21 ns** |   **1.667 ns** |  **0.091 ns** |  **53.12 ns** |    **53.30 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **996.50 ns** | **915.863 ns** | **50.202 ns** | **964.66 ns** | **1,054.37 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 954.09 ns |  29.930 ns |  1.641 ns | 952.68 ns |   955.89 ns |      - |     104 B |
