```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data     | json                | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------- |-------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **MemoryPack**              | **Byte[89]** | **?**                   |  **54.77 ns** |   **2.410 ns** |  **0.132 ns** |  **54.64 ns** |  **54.91 ns** | **0.0012** |     **104 B** |
| **SystemTextJson**          | **?**        | **{&quot;Gn(...)&quot;:0} [182]** | **973.01 ns** | **409.164 ns** | **22.428 ns** | **959.65 ns** | **998.90 ns** |      **-** |     **104 B** |
| SystemTextJsonSourceGen | ?        | {&quot;Gn(...)&quot;:0} [182] | 950.89 ns | 299.754 ns | 16.431 ns | 931.98 ns | 961.65 ns |      - |     104 B |
