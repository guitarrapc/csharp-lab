```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **780.1 ns** |   **642.8 ns** | **35.23 ns** |   **739.6 ns** |   **804.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.5 ns |   112.9 ns |  6.19 ns |   728.3 ns |   739.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   729.8 ns |   287.9 ns | 15.78 ns |   714.2 ns |   745.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   759.9 ns |   656.6 ns | 35.99 ns |   726.8 ns |   798.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   734.8 ns |   433.1 ns | 23.74 ns |   710.6 ns |   758.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,324.0 ns** | **1,390.4 ns** | **76.21 ns** | **2,270.0 ns** | **2,411.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,243.7 ns | 1,440.2 ns | 78.94 ns | 2,181.4 ns | 2,332.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,130.1 ns |   798.7 ns | 43.78 ns | 2,087.2 ns | 2,174.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,217.4 ns | 1,105.2 ns | 60.58 ns | 2,150.9 ns | 2,269.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,127.8 ns | 1,177.6 ns | 64.55 ns | 2,057.0 ns | 2,183.3 ns | 0.0343 | 0.0305 |   3.07 KB |
