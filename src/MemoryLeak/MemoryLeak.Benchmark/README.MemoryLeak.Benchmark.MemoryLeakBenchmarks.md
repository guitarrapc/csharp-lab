```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.9 ns** |   **351.4 ns** | **19.26 ns** |   **722.8 ns** |   **758.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   721.7 ns |   226.7 ns | 12.43 ns |   708.0 ns |   732.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   715.8 ns |   494.5 ns | 27.11 ns |   693.0 ns |   745.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   745.9 ns |   495.9 ns | 27.18 ns |   720.8 ns |   774.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   743.9 ns |   430.0 ns | 23.57 ns |   729.3 ns |   771.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,245.9 ns** |   **941.9 ns** | **51.63 ns** | **2,186.6 ns** | **2,280.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,198.0 ns |   653.0 ns | 35.79 ns | 2,158.2 ns | 2,227.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,142.2 ns | 1,266.7 ns | 69.43 ns | 2,062.5 ns | 2,189.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,092.1 ns |   921.2 ns | 50.49 ns | 2,044.3 ns | 2,144.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,262.3 ns |   576.7 ns | 31.61 ns | 2,226.3 ns | 2,285.2 ns | 0.0343 | 0.0305 |   3.07 KB |
