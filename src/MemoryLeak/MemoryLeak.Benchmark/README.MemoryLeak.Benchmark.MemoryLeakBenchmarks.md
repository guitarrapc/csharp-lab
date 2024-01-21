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
| **AllocateStringStatic** | **1**      |   **725.1 ns** |   **125.8 ns** |   **6.90 ns** |   **717.1 ns** |   **729.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   737.4 ns |   167.3 ns |   9.17 ns |   729.8 ns |   747.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   696.9 ns |   190.8 ns |  10.46 ns |   687.9 ns |   708.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   711.4 ns |   384.8 ns |  21.09 ns |   695.2 ns |   735.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   707.4 ns |   339.0 ns |  18.58 ns |   686.0 ns |   718.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,415.3 ns** | **4,316.9 ns** | **236.63 ns** | **7,266.2 ns** | **7,688.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,358.3 ns | 2,975.0 ns | 163.07 ns | 7,222.4 ns | 7,539.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,112.1 ns | 2,018.6 ns | 110.65 ns | 7,044.8 ns | 7,239.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,362.9 ns | 2,527.8 ns | 138.56 ns | 7,266.5 ns | 7,521.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,205.1 ns |   846.1 ns |  46.38 ns | 7,169.8 ns | 7,257.6 ns | 0.1221 | 0.1144 |  10.23 KB |
