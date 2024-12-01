```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,326.4 ns** |     **22.41 ns** |     **1.23 ns** |     **1,325.2 ns** |     **1,327.6 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,463.8 ns |     15.96 ns |     0.87 ns |     1,463.0 ns |     1,464.7 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,699.8 ns |    296.21 ns |    16.24 ns |     1,689.7 ns |     1,718.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,667.1 ns |     49.77 ns |     2.73 ns |     2,664.0 ns |     2,669.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.1 ns |      1.46 ns |     0.08 ns |       201.0 ns |       201.2 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       290.1 ns |     14.27 ns |     0.78 ns |       289.3 ns |       290.8 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       523.7 ns |     12.93 ns |     0.71 ns |       523.2 ns |       524.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,897.0 ns** |  **9,787.06 ns** |   **536.46 ns** | **1,545,387.6 ns** | **1,546,457.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,285.4 ns |  1,080.42 ns |    59.22 ns |   614,242.8 ns |   614,353.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   656,756.1 ns | 27,399.36 ns | 1,501.85 ns |   655,026.0 ns |   657,724.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,374,211.0 ns | 57,291.81 ns | 3,140.36 ns | 1,372,257.5 ns | 1,377,833.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,229.5 ns |  1,730.78 ns |    94.87 ns |   162,161.3 ns |   162,337.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,498.0 ns |  1,089.99 ns |    59.75 ns |    91,429.9 ns |    91,541.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,663.9 ns |  4,490.23 ns |   246.12 ns |    65,497.8 ns |    65,946.6 ns |      - |      40 B |
