```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **761.1 ns** |   **107.26 ns** |   **5.88 ns** |   **755.3 ns** |   **767.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   714.8 ns |    69.52 ns |   3.81 ns |   710.4 ns |   717.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   690.8 ns |   153.54 ns |   8.42 ns |   682.9 ns |   699.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.1 ns |   511.76 ns |  28.05 ns |   714.5 ns |   766.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   715.0 ns |   191.58 ns |  10.50 ns |   708.2 ns |   727.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,588.3 ns** |   **808.38 ns** |  **44.31 ns** | **7,562.2 ns** | **7,639.5 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,277.1 ns | 3,455.86 ns | 189.43 ns | 7,076.6 ns | 7,453.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,914.9 ns | 6,621.76 ns | 362.96 ns | 6,614.5 ns | 7,318.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,328.1 ns | 2,944.88 ns | 161.42 ns | 7,187.0 ns | 7,504.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,239.0 ns |   200.83 ns |  11.01 ns | 7,228.7 ns | 7,250.6 ns | 0.1221 | 0.1144 |  10.23 KB |
