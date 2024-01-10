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
| **AllocateStringStatic** | **1**      |   **746.2 ns** |   **365.90 ns** |  **20.06 ns** |   **727.8 ns** |   **767.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.9 ns |   483.99 ns |  26.53 ns |   704.3 ns |   756.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.9 ns |    88.65 ns |   4.86 ns |   718.6 ns |   728.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   747.1 ns |   282.24 ns |  15.47 ns |   731.2 ns |   762.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   719.4 ns |   300.50 ns |  16.47 ns |   701.6 ns |   734.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **8,004.0 ns** | **2,527.52 ns** | **138.54 ns** | **7,896.9 ns** | **8,160.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,505.5 ns | 1,223.47 ns |  67.06 ns | 7,428.2 ns | 7,547.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,459.1 ns | 2,314.07 ns | 126.84 ns | 7,315.6 ns | 7,556.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,500.8 ns | 5,405.57 ns | 296.30 ns | 7,200.3 ns | 7,792.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,404.5 ns | 3,194.32 ns | 175.09 ns | 7,225.7 ns | 7,575.6 ns | 0.1221 | 0.1144 |  10.23 KB |
