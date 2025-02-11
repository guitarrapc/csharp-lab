```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                  | Runtime  | data     | json                | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |--------- |-------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **.NET 8.0** | **Byte[89]** | **?**                   |  **60.34 ns** |   **3.354 ns** | **0.184 ns** |  **60.14 ns** |  **60.49 ns** | **0.0062** |     **104 B** |
| MemoryPack              | .NET 9.0 | Byte[89] | ?                   |  42.47 ns |   8.149 ns | 0.447 ns |  42.05 ns |  42.94 ns | 0.0062 |     104 B |
| **SystemTextJson**          | **.NET 8.0** | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **966.73 ns** | **105.644 ns** | **5.791 ns** | **962.55 ns** | **973.34 ns** | **0.0057** |     **104 B** |
| SystemTextJsonSourceGen | .NET 8.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 934.99 ns |  55.443 ns | 3.039 ns | 932.65 ns | 938.43 ns | 0.0057 |     104 B |
| SystemTextJson          | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 946.80 ns |   7.623 ns | 0.418 ns | 946.32 ns | 947.07 ns | 0.0057 |     104 B |
| SystemTextJsonSourceGen | .NET 9.0 | ?        | {&quot;Gn(...)&quot;:0} [182] | 929.77 ns |  52.151 ns | 2.859 ns | 927.23 ns | 932.86 ns | 0.0057 |     104 B |
