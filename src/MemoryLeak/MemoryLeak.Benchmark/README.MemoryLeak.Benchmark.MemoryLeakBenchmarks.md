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
| **AllocateStringStatic** | **1**      |   **758.2 ns** |   **668.3 ns** |  **36.63 ns** |   **715.9 ns** |   **780.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   733.8 ns |   250.9 ns |  13.75 ns |   719.3 ns |   746.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   686.7 ns |   544.2 ns |  29.83 ns |   663.4 ns |   720.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.0 ns |   702.9 ns |  38.53 ns |   709.2 ns |   783.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   694.4 ns |   580.4 ns |  31.81 ns |   676.0 ns |   731.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,541.5 ns** | **4,573.4 ns** | **250.68 ns** | **7,259.9 ns** | **7,740.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,362.1 ns | 1,706.5 ns |  93.54 ns | 7,259.2 ns | 7,441.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,981.0 ns | 1,902.6 ns | 104.29 ns | 6,908.5 ns | 7,100.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,563.7 ns | 1,811.4 ns |  99.29 ns | 7,459.4 ns | 7,657.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,262.5 ns | 2,080.7 ns | 114.05 ns | 7,156.0 ns | 7,382.8 ns | 0.1221 | 0.1144 |  10.23 KB |
