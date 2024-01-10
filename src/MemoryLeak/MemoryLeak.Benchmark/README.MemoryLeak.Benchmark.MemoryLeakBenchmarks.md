```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **746.6 ns** |   **541.9 ns** |  **29.70 ns** |   **713.7 ns** |   **771.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   719.6 ns |   285.0 ns |  15.62 ns |   701.7 ns |   730.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   688.5 ns |   438.7 ns |  24.05 ns |   667.3 ns |   714.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   751.8 ns |   537.7 ns |  29.47 ns |   720.4 ns |   778.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   730.1 ns |   391.0 ns |  21.43 ns |   717.0 ns |   754.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,503.6 ns** |   **610.1 ns** |  **33.44 ns** | **7,465.3 ns** | **7,527.1 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,372.6 ns | 3,632.6 ns | 199.12 ns | 7,151.9 ns | 7,538.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,201.8 ns | 1,147.2 ns |  62.88 ns | 7,129.4 ns | 7,242.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,566.0 ns | 2,240.3 ns | 122.80 ns | 7,467.0 ns | 7,703.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,488.4 ns | 1,778.6 ns |  97.49 ns | 7,383.6 ns | 7,576.4 ns | 0.1221 | 0.1144 |  10.23 KB |
