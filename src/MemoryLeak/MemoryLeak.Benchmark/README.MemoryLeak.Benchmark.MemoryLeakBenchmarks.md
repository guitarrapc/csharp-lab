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
| **AllocateStringStatic** | **1**      |   **755.8 ns** |   **372.8 ns** | **20.43 ns** |   **736.8 ns** |   **777.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   726.2 ns |   329.0 ns | 18.04 ns |   705.6 ns |   738.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.6 ns |   428.2 ns | 23.47 ns |   707.5 ns |   750.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.5 ns |   420.7 ns | 23.06 ns |   719.1 ns |   764.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   726.0 ns |   361.2 ns | 19.80 ns |   705.0 ns |   744.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,281.1 ns** |   **759.4 ns** | **41.63 ns** | **2,242.6 ns** | **2,325.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,158.4 ns |   697.0 ns | 38.20 ns | 2,116.1 ns | 2,190.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,074.6 ns | 1,510.9 ns | 82.82 ns | 2,012.8 ns | 2,168.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,173.4 ns |   708.6 ns | 38.84 ns | 2,128.5 ns | 2,195.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,162.6 ns | 1,127.0 ns | 61.77 ns | 2,094.6 ns | 2,215.3 ns | 0.0343 | 0.0305 |   3.07 KB |
