```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **768.6 ns** |   **366.7 ns** | **20.10 ns** |   **747.4 ns** |   **787.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   730.3 ns |   450.5 ns | 24.69 ns |   714.9 ns |   758.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   720.3 ns |   390.5 ns | 21.41 ns |   707.1 ns |   745.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   731.6 ns |   474.0 ns | 25.98 ns |   707.0 ns |   758.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.3 ns |   128.4 ns |  7.04 ns |   713.6 ns |   727.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,221.9 ns** |   **732.9 ns** | **40.18 ns** | **2,176.1 ns** | **2,251.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,195.9 ns | 1,627.2 ns | 89.19 ns | 2,094.5 ns | 2,262.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,140.2 ns |   978.8 ns | 53.65 ns | 2,078.3 ns | 2,171.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,189.6 ns | 1,369.0 ns | 75.04 ns | 2,103.0 ns | 2,235.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,197.9 ns | 1,386.3 ns | 75.99 ns | 2,127.7 ns | 2,278.6 ns | 0.0343 | 0.0305 |   3.07 KB |
