```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **728.8 ns** |   **888.3 ns** |  **48.69 ns** |   **698.1 ns** |   **784.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   753.0 ns |   214.4 ns |  11.75 ns |   741.2 ns |   764.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   690.9 ns |   386.9 ns |  21.21 ns |   675.4 ns |   715.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   729.6 ns |   421.0 ns |  23.07 ns |   703.6 ns |   747.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.0 ns |   621.6 ns |  34.07 ns |   682.1 ns |   745.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,211.4 ns** | **2,044.6 ns** | **112.07 ns** | **2,139.9 ns** | **2,340.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,186.0 ns | 1,447.7 ns |  79.36 ns | 2,103.1 ns | 2,261.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,149.0 ns | 1,907.0 ns | 104.53 ns | 2,040.6 ns | 2,249.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,131.0 ns | 2,047.0 ns | 112.21 ns | 2,038.0 ns | 2,255.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,191.2 ns | 1,896.5 ns | 103.95 ns | 2,080.3 ns | 2,286.3 ns | 0.0343 | 0.0305 |   3.07 KB |
