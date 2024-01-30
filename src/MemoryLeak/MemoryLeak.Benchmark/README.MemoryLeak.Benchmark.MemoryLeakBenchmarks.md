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
| **AllocateStringStatic** | **1**      |   **726.8 ns** |   **291.5 ns** |  **15.98 ns** |   **708.4 ns** |   **737.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   705.7 ns |   546.2 ns |  29.94 ns |   681.2 ns |   739.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.2 ns |   184.7 ns |  10.12 ns |   684.7 ns |   704.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   710.4 ns |   379.7 ns |  20.81 ns |   689.7 ns |   731.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   695.8 ns |   602.3 ns |  33.01 ns |   675.5 ns |   733.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,432.5 ns** | **3,319.8 ns** | **181.97 ns** | **7,237.8 ns** | **7,598.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,209.2 ns | 3,957.3 ns | 216.91 ns | 6,979.8 ns | 7,411.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,946.0 ns | 1,001.3 ns |  54.88 ns | 6,882.8 ns | 6,981.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,187.8 ns | 2,530.4 ns | 138.70 ns | 7,091.7 ns | 7,346.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,118.9 ns | 1,727.5 ns |  94.69 ns | 7,012.1 ns | 7,192.7 ns | 0.1221 | 0.1144 |  10.23 KB |
