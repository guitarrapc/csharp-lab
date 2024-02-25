```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **762.0 ns** |   **575.46 ns** |  **31.54 ns** |   **725.7 ns** |   **782.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   734.7 ns |   416.37 ns |  22.82 ns |   716.2 ns |   760.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   689.9 ns |    68.43 ns |   3.75 ns |   687.1 ns |   694.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   701.9 ns |   453.36 ns |  24.85 ns |   676.6 ns |   726.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   699.9 ns |   630.54 ns |  34.56 ns |   678.1 ns |   739.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,370.8 ns** | **2,043.44 ns** | **112.01 ns** | **7,283.6 ns** | **7,497.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,254.4 ns | 1,530.39 ns |  83.89 ns | 7,193.7 ns | 7,350.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,933.2 ns | 4,791.52 ns | 262.64 ns | 6,654.3 ns | 7,175.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,308.5 ns | 2,542.56 ns | 139.37 ns | 7,185.7 ns | 7,460.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,122.1 ns | 3,324.29 ns | 182.22 ns | 6,915.0 ns | 7,257.8 ns | 0.1221 | 0.1144 |  10.23 KB |
