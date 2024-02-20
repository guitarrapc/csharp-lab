```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.4 ns** |   **434.9 ns** |  **23.84 ns** |   **728.8 ns** |   **771.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   724.9 ns |   189.8 ns |  10.40 ns |   714.6 ns |   735.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   701.4 ns |   237.7 ns |  13.03 ns |   688.9 ns |   714.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   723.0 ns |   301.5 ns |  16.53 ns |   707.4 ns |   740.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   700.8 ns |   331.4 ns |  18.16 ns |   680.1 ns |   714.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,428.2 ns** | **4,911.1 ns** | **269.19 ns** | **7,133.0 ns** | **7,660.0 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,059.3 ns | 5,362.7 ns | 293.95 ns | 6,726.3 ns | 7,282.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,864.3 ns | 3,924.4 ns | 215.11 ns | 6,626.5 ns | 7,045.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,363.8 ns | 3,514.1 ns | 192.62 ns | 7,226.8 ns | 7,584.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,371.9 ns | 3,708.4 ns | 203.27 ns | 7,137.2 ns | 7,490.9 ns | 0.1221 | 0.1144 |  10.23 KB |
