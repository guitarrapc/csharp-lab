```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,624.0 ns** |  **3,364.32 ns** |   **184.41 ns** |     **1,411.1 ns** |     **1,734.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,464.2 ns |    143.21 ns |     7.85 ns |     1,457.1 ns |     1,472.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,686.3 ns |     64.00 ns |     3.51 ns |     1,682.3 ns |     1,689.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,742.3 ns |     57.11 ns |     3.13 ns |     2,740.0 ns |     2,745.8 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       204.8 ns |     49.34 ns |     2.70 ns |       203.1 ns |       207.9 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.6 ns |     27.75 ns |     1.52 ns |       289.8 ns |       292.6 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       485.4 ns |     27.31 ns |     1.50 ns |       483.7 ns |       486.5 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,875.6 ns** |  **3,455.76 ns** |   **189.42 ns** | **1,545,668.6 ns** | **1,546,040.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   615,275.1 ns | 20,826.64 ns | 1,141.58 ns |   614,600.3 ns |   616,593.2 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,098.7 ns |  1,123.83 ns |    61.60 ns |   655,036.5 ns |   655,159.7 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,453,706.1 ns | 48,072.38 ns | 2,635.01 ns | 1,450,804.4 ns | 1,455,949.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,300.7 ns |    447.37 ns |    24.52 ns |   162,272.5 ns |   162,317.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,631.1 ns |  7,446.43 ns |   408.16 ns |    91,367.7 ns |    92,101.3 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,319.9 ns |  1,959.55 ns |   107.41 ns |    65,217.8 ns |    65,431.9 ns |      - |      40 B |
