```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **734.1 ns** |   **268.5 ns** |  **14.72 ns** |   **717.4 ns** |   **745.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   717.9 ns |   346.9 ns |  19.01 ns |   699.4 ns |   737.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   726.1 ns |   526.2 ns |  28.84 ns |   707.3 ns |   759.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   723.0 ns |   562.7 ns |  30.84 ns |   690.3 ns |   751.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   711.4 ns |   229.2 ns |  12.56 ns |   697.8 ns |   722.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,570.7 ns** | **3,281.2 ns** | **179.85 ns** | **7,422.9 ns** | **7,771.0 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,457.4 ns | 2,226.2 ns | 122.03 ns | 7,316.5 ns | 7,529.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,145.6 ns | 5,316.8 ns | 291.43 ns | 6,831.1 ns | 7,406.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,378.0 ns | 2,219.7 ns | 121.67 ns | 7,303.1 ns | 7,518.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,165.9 ns | 1,760.7 ns |  96.51 ns | 7,074.3 ns | 7,266.7 ns | 0.1221 | 0.1144 |  10.23 KB |
