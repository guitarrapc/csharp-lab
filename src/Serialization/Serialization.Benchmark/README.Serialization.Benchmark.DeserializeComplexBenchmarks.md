```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **44.51 ns** |  **5.332 ns** | **0.292 ns** |  **44.19 ns** |  **44.76 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **955.56 ns** | **78.136 ns** | **4.283 ns** | **950.63 ns** | **958.32 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 912.38 ns | 80.307 ns | 4.402 ns | 909.59 ns | 917.46 ns | 0.0010 |     104 B |
