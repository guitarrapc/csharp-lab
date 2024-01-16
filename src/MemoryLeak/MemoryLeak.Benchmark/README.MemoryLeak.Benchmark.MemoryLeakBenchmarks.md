```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **745.5 ns** |   **366.27 ns** |  **20.08 ns** |   **731.7 ns** |   **768.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   720.4 ns |     3.44 ns |   0.19 ns |   720.3 ns |   720.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   714.8 ns |    57.67 ns |   3.16 ns |   711.2 ns |   717.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   743.3 ns |   224.82 ns |  12.32 ns |   735.8 ns |   757.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.2 ns |   393.90 ns |  21.59 ns |   706.3 ns |   744.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,815.7 ns** | **3,864.76 ns** | **211.84 ns** | **7,607.6 ns** | **8,031.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,287.4 ns | 1,668.74 ns |  91.47 ns | 7,198.3 ns | 7,381.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,042.0 ns | 5,485.50 ns | 300.68 ns | 6,696.6 ns | 7,245.6 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,557.8 ns | 4,405.77 ns | 241.49 ns | 7,363.0 ns | 7,828.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,288.5 ns | 2,901.45 ns | 159.04 ns | 7,161.9 ns | 7,467.0 ns | 0.1221 | 0.1144 |  10.23 KB |
