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
| **AllocateStringStatic** | **1**      |   **735.1 ns** |   **456.28 ns** |  **25.01 ns** |   **707.6 ns** |   **756.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   718.4 ns |   155.16 ns |   8.50 ns |   709.9 ns |   726.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   699.7 ns |   217.45 ns |  11.92 ns |   687.4 ns |   711.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   710.5 ns |   187.60 ns |  10.28 ns |   703.8 ns |   722.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.9 ns |    17.30 ns |   0.95 ns |   717.0 ns |   718.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,485.0 ns** | **2,225.20 ns** | **121.97 ns** | **7,370.9 ns** | **7,613.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,098.6 ns |   259.86 ns |  14.24 ns | 7,082.1 ns | 7,107.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,019.1 ns | 2,943.61 ns | 161.35 ns | 6,925.7 ns | 7,205.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,271.8 ns | 2,467.49 ns | 135.25 ns | 7,119.5 ns | 7,378.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,164.7 ns | 3,790.66 ns | 207.78 ns | 6,995.2 ns | 7,396.5 ns | 0.1221 | 0.1144 |  10.23 KB |
