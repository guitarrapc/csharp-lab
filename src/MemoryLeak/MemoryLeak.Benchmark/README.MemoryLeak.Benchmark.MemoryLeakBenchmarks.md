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
| **AllocateStringStatic** | **1**      |   **764.4 ns** |   **400.3 ns** |  **21.94 ns** |   **740.4 ns** |   **783.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   711.0 ns |   353.0 ns |  19.35 ns |   692.0 ns |   730.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   692.4 ns |   373.1 ns |  20.45 ns |   674.4 ns |   714.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   765.4 ns |   579.9 ns |  31.78 ns |   733.6 ns |   797.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   748.1 ns |   205.2 ns |  11.25 ns |   741.0 ns |   761.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,920.7 ns** | **6,441.1 ns** | **353.06 ns** | **7,552.5 ns** | **8,256.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,637.1 ns | 5,661.1 ns | 310.31 ns | 7,412.0 ns | 7,991.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,297.4 ns | 5,112.1 ns | 280.21 ns | 6,995.4 ns | 7,548.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,634.0 ns | 5,168.4 ns | 283.30 ns | 7,436.5 ns | 7,958.6 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,396.2 ns | 2,354.8 ns | 129.08 ns | 7,255.8 ns | 7,509.8 ns | 0.1221 | 0.1144 |  10.23 KB |
