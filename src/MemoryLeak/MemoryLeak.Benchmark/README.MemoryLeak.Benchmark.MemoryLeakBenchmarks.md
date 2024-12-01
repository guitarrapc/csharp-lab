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
| **AllocateStringStatic** | **1**      |   **731.7 ns** |   **166.5 ns** |  **9.13 ns** |   **721.3 ns** |   **738.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   707.2 ns |   604.4 ns | 33.13 ns |   685.9 ns |   745.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   696.5 ns |   408.7 ns | 22.40 ns |   681.1 ns |   722.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   722.7 ns |   555.3 ns | 30.44 ns |   692.5 ns |   753.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   713.3 ns |   214.5 ns | 11.76 ns |   701.6 ns |   725.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,206.5 ns** |   **548.4 ns** | **30.06 ns** | **2,175.3 ns** | **2,235.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,137.2 ns | 1,360.2 ns | 74.56 ns | 2,051.3 ns | 2,185.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,058.1 ns |   739.9 ns | 40.55 ns | 2,028.4 ns | 2,104.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,168.7 ns | 1,156.6 ns | 63.39 ns | 2,107.0 ns | 2,233.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,131.2 ns |   773.1 ns | 42.38 ns | 2,101.3 ns | 2,179.7 ns | 0.0343 | 0.0305 |   3.07 KB |
