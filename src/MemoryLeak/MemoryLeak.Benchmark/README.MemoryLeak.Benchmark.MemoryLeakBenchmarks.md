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
| **AllocateStringStatic** | **1**      |   **751.6 ns** |   **340.7 ns** |  **18.68 ns** |   **732.9 ns** |   **770.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.7 ns |   232.5 ns |  12.75 ns |   702.1 ns |   727.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.9 ns |   396.8 ns |  21.75 ns |   671.1 ns |   711.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.6 ns |   205.1 ns |  11.24 ns |   728.9 ns |   751.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.2 ns |   154.7 ns |   8.48 ns |   714.6 ns |   731.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,577.3 ns** | **3,194.1 ns** | **175.08 ns** | **7,431.5 ns** | **7,771.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,358.7 ns | 2,249.2 ns | 123.29 ns | 7,216.3 ns | 7,431.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,240.7 ns | 1,390.8 ns |  76.24 ns | 7,160.5 ns | 7,312.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,501.8 ns | 1,911.0 ns | 104.75 ns | 7,416.1 ns | 7,618.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,257.7 ns | 2,747.7 ns | 150.61 ns | 7,134.6 ns | 7,425.6 ns | 0.1221 | 0.1144 |  10.23 KB |
