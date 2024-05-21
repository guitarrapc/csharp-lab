```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **770.7 ns** |   **101.3 ns** |  **5.55 ns** |   **767.0 ns** |   **777.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   768.6 ns |   286.2 ns | 15.69 ns |   750.7 ns |   780.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.2 ns |   117.1 ns |  6.42 ns |   718.4 ns |   730.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   735.8 ns |   249.2 ns | 13.66 ns |   720.7 ns |   747.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   747.2 ns |   708.7 ns | 38.84 ns |   715.7 ns |   790.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,168.2 ns** |   **572.6 ns** | **31.38 ns** | **2,132.7 ns** | **2,192.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,126.6 ns | 1,423.5 ns | 78.03 ns | 2,038.8 ns | 2,188.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,129.3 ns |   936.0 ns | 51.31 ns | 2,070.1 ns | 2,161.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,155.6 ns | 1,428.7 ns | 78.31 ns | 2,092.8 ns | 2,243.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,178.4 ns |   127.4 ns |  6.98 ns | 2,171.1 ns | 2,185.0 ns | 0.0343 | 0.0305 |   3.07 KB |
