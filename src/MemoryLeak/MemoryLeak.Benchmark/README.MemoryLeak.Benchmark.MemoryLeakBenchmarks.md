```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **786.2 ns** |   **355.7 ns** |  **19.50 ns** |   **769.0 ns** |   **807.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.2 ns |   787.1 ns |  43.14 ns |   695.2 ns |   777.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   699.2 ns |   470.6 ns |  25.79 ns |   675.8 ns |   726.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   757.0 ns |   391.6 ns |  21.46 ns |   732.5 ns |   772.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   727.5 ns |   216.3 ns |  11.86 ns |   714.8 ns |   738.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,929.2 ns** | **3,496.9 ns** | **191.68 ns** | **7,721.7 ns** | **8,099.7 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,398.1 ns | 1,710.8 ns |  93.78 ns | 7,290.5 ns | 7,462.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,209.3 ns | 3,586.0 ns | 196.56 ns | 6,992.1 ns | 7,375.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,448.2 ns | 3,466.9 ns | 190.03 ns | 7,256.7 ns | 7,636.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,291.0 ns | 2,097.0 ns | 114.94 ns | 7,165.6 ns | 7,391.4 ns | 0.1221 | 0.1144 |  10.23 KB |
