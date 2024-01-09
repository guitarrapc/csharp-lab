```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **722.1 ns** |   **524.0 ns** |  **28.72 ns** |   **701.9 ns** |   **755.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   724.2 ns |   275.0 ns |  15.07 ns |   707.8 ns |   737.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   726.6 ns |   188.8 ns |  10.35 ns |   714.9 ns |   734.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   741.7 ns |   261.7 ns |  14.34 ns |   728.3 ns |   756.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.1 ns |   464.3 ns |  25.45 ns |   706.3 ns |   756.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,598.8 ns** | **2,227.2 ns** | **122.08 ns** | **7,457.9 ns** | **7,672.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,280.0 ns | 2,211.5 ns | 121.22 ns | 7,165.9 ns | 7,407.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,208.2 ns | 3,100.6 ns | 169.95 ns | 7,027.0 ns | 7,364.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,627.6 ns | 5,408.8 ns | 296.48 ns | 7,380.6 ns | 7,956.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,162.4 ns | 5,128.1 ns | 281.09 ns | 6,875.1 ns | 7,436.8 ns | 0.1221 | 0.1144 |  10.23 KB |
