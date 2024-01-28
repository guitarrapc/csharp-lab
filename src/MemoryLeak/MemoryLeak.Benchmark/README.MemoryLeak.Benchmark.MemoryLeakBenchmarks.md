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
| **AllocateStringStatic** | **1**      |   **746.9 ns** |   **611.6 ns** |  **33.52 ns** |   **708.5 ns** |   **770.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   701.5 ns |   244.7 ns |  13.41 ns |   687.4 ns |   714.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   690.0 ns |   346.5 ns |  18.99 ns |   668.2 ns |   702.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   719.2 ns |   204.7 ns |  11.22 ns |   706.6 ns |   727.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   697.4 ns |   322.7 ns |  17.69 ns |   679.4 ns |   714.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,471.5 ns** | **1,598.4 ns** |  **87.62 ns** | **7,385.0 ns** | **7,560.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,229.6 ns | 1,981.3 ns | 108.60 ns | 7,104.9 ns | 7,303.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,112.5 ns | 2,236.0 ns | 122.57 ns | 6,993.4 ns | 7,238.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,343.0 ns | 1,413.4 ns |  77.47 ns | 7,281.4 ns | 7,430.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,258.9 ns | 1,348.5 ns |  73.92 ns | 7,212.9 ns | 7,344.1 ns | 0.1221 | 0.1144 |  10.23 KB |
