```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **779.2 ns** |   **215.1 ns** | **11.79 ns** |   **771.0 ns** |   **792.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   754.9 ns |   592.7 ns | 32.49 ns |   718.9 ns |   782.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   734.3 ns |   383.3 ns | 21.01 ns |   712.3 ns |   754.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   767.5 ns |   381.4 ns | 20.91 ns |   748.3 ns |   789.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   759.8 ns |   230.9 ns | 12.66 ns |   750.7 ns |   774.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,282.1 ns** | **1,207.3 ns** | **66.18 ns** | **2,211.9 ns** | **2,343.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,247.5 ns | 1,628.7 ns | 89.27 ns | 2,144.8 ns | 2,305.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,167.0 ns | 1,602.9 ns | 87.86 ns | 2,068.0 ns | 2,235.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,299.1 ns |   861.0 ns | 47.19 ns | 2,261.5 ns | 2,352.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,233.2 ns |   998.1 ns | 54.71 ns | 2,175.2 ns | 2,283.9 ns | 0.0343 | 0.0305 |   3.07 KB |
